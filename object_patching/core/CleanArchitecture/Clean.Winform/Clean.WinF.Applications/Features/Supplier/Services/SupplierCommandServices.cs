using Clean.WinF.Applications.Features.Supplier.DTOs;
using Clean.WinF.Applications.Features.Supplier.Interfaces;
using Clean.WinF.Applications.MappingProfiles;
using Clean.WinF.Common.Utilities;
using Clean.WinF.Domain.IRepository;
using Clean.WinF.Shared.Constants;
using Clean.WinF.Shared.ErrorMessage;
using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Clean.WinF.Applications.Features.Supplier.Services
{
    public class SupplierCommandServices : ISupplierCommandServices
    {
        private readonly IAsyncRepository<Clean.WinF.Domain.Entities.Supplier> _supplierRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly AutoMapper.IMapper _mapper;//implement automapper

        public SupplierCommandServices(IAsyncRepository<Clean.WinF.Domain.Entities.Supplier> supplierRepository, IUnitOfWork unitOfWork)
        {
            _supplierRepository = supplierRepository;
            _unitOfWork = unitOfWork;
            _mapper = AutoMapperConfig.Configure();
        }

        static string GetCellAddress(int row, int col)
        {
            string columnName = GetColumnName(col);
            return $"{columnName}{row}";
        }
        static string GetColumnName(int columnNumber)
        {
            const int baseNumber = 'Z' - 'A' + 1;
            string columnName = "";

            while (columnNumber > 0)
            {
                int remainder = (columnNumber - 1) % baseNumber;
                columnName = (char)('A' + remainder) + columnName;
                columnNumber = (columnNumber - 1) / baseNumber;
            }

            return columnName;
        }
        public void ExportBulk(List<SupplierDto> dtos, string filePath)
        {

            // Create a new Excel package
            using (var workbook = new XLWorkbook())
            {
                // Get the default worksheet
                var worksheet = workbook.Worksheets.Add("Sheet1");

                worksheet.Range(GetCellAddress(1, 1)).Value = "h1";
                worksheet.Range(GetCellAddress(1, 2)).Value = "Supplier Code";
                worksheet.Range(GetCellAddress(1, 3)).Value = "Supplier Name";
                worksheet.Range(GetCellAddress(1, 4)).Value = "Phone";
                worksheet.Range(GetCellAddress(1, 5)).Value = "Fax";
                worksheet.Range(GetCellAddress(1, 6)).Value = "Zip";
                worksheet.Range(GetCellAddress(1, 7)).Value = "City";
                worksheet.Range(GetCellAddress(1, 8)).Value = "Street";
                worksheet.Range(GetCellAddress(1, 9)).Value = "Remark";
                worksheet.Range(GetCellAddress(1, 10)).Value = "createTime";
                worksheet.Range(GetCellAddress(1, 11)).Value = "createName";
                worksheet.Range(GetCellAddress(1, 12)).Value = "updateTime";
                worksheet.Range(GetCellAddress(1, 13)).Value = "updateName";

                int row = 2;
                foreach (var dataItem in dtos)
                {
                    worksheet.Range(GetCellAddress(row, 1)).Value = "r";
                    worksheet.Range(GetCellAddress(row, 2)).Value = dataItem.Code;
                    worksheet.Range(GetCellAddress(row, 3)).Value = dataItem.Name;
                    worksheet.Range(GetCellAddress(row, 4)).Value = dataItem.Telephone;
                    worksheet.Range(GetCellAddress(row, 5)).Value = dataItem.Fax;
                    worksheet.Range(GetCellAddress(row, 6)).Value = dataItem.Zip;
                    worksheet.Range(GetCellAddress(row, 7)).Value = dataItem.Place;
                    worksheet.Range(GetCellAddress(row, 8)).Value = dataItem.Street;
                    worksheet.Range(GetCellAddress(row, 9)).Value = dataItem.Remark;
                    worksheet.Range(GetCellAddress(row, 10)).Value = dataItem.CreatedOn.ToString("yyyy-MM-dd HH:mm:ss");
                    worksheet.Range(GetCellAddress(row, 11)).Value = dataItem.CreatedBy;
                    worksheet.Range(GetCellAddress(row, 12)).Value = dataItem.UpdatedOn.ToString("yyyy-MM-dd HH:mm:ss");
                    worksheet.Range(GetCellAddress(row, 13)).Value = dataItem.UpdatedBy;

                    row++;
                }

                for (int i = 1; i < 100; i++)
                {
                    worksheet.Column(i).AdjustToContents();
                }
                workbook.SaveAs(filePath);
            }
        }
        public List<SupplierDto> ImportBulk(List<SupplierDto> incomingDtos, string filePath)
        {
            List<SupplierDto> dtos = new List<SupplierDto>();
            using (var workbook = new XLWorkbook(filePath))
            {
                if (workbook != null)
                {
                    IXLWorksheet worksheet = workbook.Worksheets.FirstOrDefault(); // Get the first worksheet, for example

                    if (worksheet != null)
                    {
                        int rowCount = worksheet.LastCellUsed().Address.RowNumber;
                        for (int row = 2; row <= rowCount; row++)
                        {
                            SupplierDto dataItem = incomingDtos.FirstOrDefault(dataItem => dataItem.Code == worksheet.Cell(GetCellAddress(row, 2)).Value.ToString());
                            if (dataItem == null)
                            {
                                dataItem = new SupplierDto();
                            }
                            else
                            {
                                continue;
                            }
                            dataItem.Code = worksheet.Cell(GetCellAddress(row, 2)).Value.ToString();
                            dataItem.Name = worksheet.Cell(GetCellAddress(row, 3)).Value.ToString();
                            dataItem.Telephone = worksheet.Cell(GetCellAddress(row, 4)).Value.ToString();
                            dataItem.Fax = worksheet.Cell(GetCellAddress(row, 5)).Value.ToString();
                            dataItem.Zip = worksheet.Cell(GetCellAddress(row, 6)).Value.ToString();
                            dataItem.Place = worksheet.Cell(GetCellAddress(row, 7)).Value.ToString();
                            dataItem.Street = worksheet.Cell(GetCellAddress(row, 8)).Value.ToString();
                            dataItem.Remark = worksheet.Cell(GetCellAddress(row, 9)).Value.ToString();
                            dataItem.CreatedOn = DateTime.Parse(worksheet.Cell(GetCellAddress(row, 10)).Value.ToString());
                            dataItem.CreatedBy = worksheet.Cell(GetCellAddress(row, 11)).Value.ToString();
                            dataItem.UpdatedOn = DateTime.Parse(worksheet.Cell(GetCellAddress(row, 12)).Value.ToString());
                            dataItem.UpdatedBy = worksheet.Cell(GetCellAddress(row, 13)).Value.ToString();
                            dataItem.IsActive = true;
                            dataItem.IsAdd = true;
                            dtos.Add(dataItem);
                        }
                        Console.WriteLine();
                        return dtos;
                    }
                }
            }
            return dtos;
        }

        public async Task<bool> CreateBulkSuppliers(List<SupplierDto> addedSuppliers)
        {
            var result = true;
            try
            {
                if (addedSuppliers != null)
                {
                    var bulkSuppliers = new List<Domain.Entities.Supplier>();
                    foreach (var supplierDto in addedSuppliers)
                    {
                        var supplier = _mapper.Map<Domain.Entities.Supplier>(supplierDto);
                        bulkSuppliers.Add(supplier);
                    }

                    if (bulkSuppliers != null && bulkSuppliers.Count > 0)
                        result = await _unitOfWork.SupplierRepository.AddBulkEntitiesAsync(bulkSuppliers);
                }
            }
            catch (Exception ex)
            {
                Log.Error($"CreateBulkSuppliers() error: {ex.ToString()}");
                return result;
            }

            return result;
        }
        public async Task<bool> UpdateBulkSupliers(List<SupplierDto> updatedSuppliers)
        {
            var result = true;
            try
            {
                if (updatedSuppliers != null)
                {
                    var bulkSuppliers = new List<Domain.Entities.Supplier>();
                    foreach (var supplierDto in updatedSuppliers)
                    {
                        var supplier = _mapper.Map<Domain.Entities.Supplier>(supplierDto);
                        bulkSuppliers.Add(supplier);
                    }

                    if (bulkSuppliers != null && bulkSuppliers.Count > 0)
                        result = await _unitOfWork.SupplierRepository.UpdateBulkEntitiesAsync(bulkSuppliers);
                }
            }
            catch (Exception ex)
            {
                Log.Error($"UpdateBulkSuppliers() error: {ex.ToString()}");
                return result;
            }

            return result;
        }
        public async Task<SupplierDto> CreateNewSupplier(SupplierDto addSupplier)
        {
            var result = new SupplierDto();

            if (string.IsNullOrEmpty(addSupplier.Name.Trim()))
            {
                result.CustomErrorCode = CustomErrorCode.APP_SUPPLIER_NAME_EMPTY;
                result.MessageRet = string.Format(CustomErrorMessage.APP_SUPPLIER_NAME_EMPTY);
                return result;
            }

            if (string.IsNullOrEmpty(addSupplier.Code.Trim()))
            {
                result.CustomErrorCode = CustomErrorCode.APP_SUPPLIER_CODE_EMPTY;
                result.MessageRet = string.Format(CustomErrorMessage.APP_SUPPLIER_CODE_EMPTY);
                return result;
            }

            var existedSupplier = await _unitOfWork.SupplierRepository.Query().FirstOrDefaultAsync(x => x.Code.Equals(addSupplier.Code) && x.IsActive == true);
            if (existedSupplier != null)
            {
                result.MessageRet = string.Format(CustomErrorMessage.APP_SUPPLIER_CODE_EXISTED_ALREADY);
                return result;
            }

            if (CleanWinFUtility.HasSpecialCharacters(addSupplier.Code.Trim()))
            {
                result.CustomErrorCode = CustomErrorCode.APP_SUPPLIER_INVALID_CODE;
                result.MessageRet = CustomErrorMessage.APP_SUPPLIER_INVALID_CODE;
                return result;
            }

            if (CleanWinFUtility.HasSpecialCharacters(addSupplier.Name.Trim()))
            {
                result.CustomErrorCode = CustomErrorCode.APP_SUPPLIER_INVALID_NAME;
                result.MessageRet = CustomErrorMessage.APP_SUPPLIER_INVALID_NAME;
                return result;
            }

            //add new to db
            var newSupplier = _mapper.Map<Domain.Entities.Supplier>(addSupplier);
            newSupplier.CreatedOn = DateTime.Now;
            newSupplier.UpdatedOn = DateTime.Now;


            try
            {
                var supplierResult = await _unitOfWork.SupplierRepository.AddAsync(newSupplier);
                var resultAdd = _unitOfWork.Complete();
                if (resultAdd > 0)
                {
                    result.CustomErrorCode = CustomOperationCodes.APP_SUPPLIER_ADD_SUCCESS;
                    result.MessageRet = CustomOperationCodes.APP_SUPPLIER_ADD_SUCCESS;

                }
                else
                {
                    result.CustomErrorCode = CustomOperationCodes.APP_SUPPLIER_ADD_FAIL;
                    result.MessageRet = CustomOperationCodes.APP_SUPPLIER_ADD_FAIL;
                }
            }
            catch (Exception ex)
            {
                Log.Error(string.Concat("CreateNewSupplier() ", ex.ToString()));
                result.MessageRet = CustomOperationCodes.APP_SUPPLIER_ADD_FAIL;
                return result;
            }

            return result;
        }
        public async Task<SupplierDto> DeleteSupplier(SupplierDto deletedSupplier)
        {
            var result = new SupplierDto();

            var existedSupplier = await _unitOfWork.SupplierRepository.Query().FirstOrDefaultAsync(x => x.ID == deletedSupplier.ID);

            if (existedSupplier is null || existedSupplier.IsActive == false)
            {
                result.MessageRet = string.Format(CustomErrorMessage.APP_SUPPLIER_NOT_FOUND, deletedSupplier.ID);
                return result;
            }

            existedSupplier.UpdatedOn = DateTime.UtcNow;
            existedSupplier.UpdatedBy = "Test";
            existedSupplier.IsActive = false;

            try
            {
                var resultUpdated = await _unitOfWork.SupplierRepository.UpdateAsync(existedSupplier);
            }
            catch (Exception ex)
            {
                Log.Error($"DeleteSupplier() error: {ex.ToString()}");
                result.MessageRet = string.Format(CustomErrorMessage.APP_SUPPLIER_REMOVED_FAIL, existedSupplier.Code);
                return result;
            }

            return result;
        }
        public async Task<SupplierDto> UpdateSupplier(SupplierDto updatedSupplier)
        {
            var result = new SupplierDto();

            if (string.IsNullOrEmpty(updatedSupplier.Name.Trim()))
            {
                result.MessageRet = string.Format(CustomErrorMessage.APP_SUPPLIER_NAME_EMPTY);
                return result;
            }

            if (string.IsNullOrEmpty(updatedSupplier.Code.Trim()))
            {
                result.MessageRet = string.Format(CustomErrorMessage.APP_SUPPLIER_CODE_EMPTY);
                return result;
            }

            if (CleanWinFUtility.HasSpecialCharacters(updatedSupplier.Name) || CleanWinFUtility.HasSpecialCharacters(updatedSupplier.Code))
            {
                result.MessageRet = string.Format(CustomErrorMessage.APP_SUPPLIER_NAME_NOT_ALLOW_SPECIAL_CHARS);
                return result;
            }

            var existedSupplier = _mapper.Map<Domain.Entities.Supplier>(updatedSupplier);
            existedSupplier.UpdatedOn = DateTime.Now;
            try
            {
                var resultUpdated = await _unitOfWork.SupplierRepository.UpdateAsync(existedSupplier);
                result = UpdateSuppilerInfo(resultUpdated);
            }
            catch (Exception ex)
            {
                Log.Error($"UpdateGroup() error: {ex.ToString()}");
                return result;
            }

            return result;
        }
        #region private functions
        private SupplierDto UpdateSuppilerInfo(Domain.Entities.Supplier supplier)
        {
            if (supplier is null) return null;

            var supplierDTO = _mapper.Map<SupplierDto>(supplier);
            supplierDTO.CustomErrorCode = CustomOperationCodes.APP_SUPPLIER_UPDATE_SUCCESS;
            supplierDTO.MessageRet = CustomOperationCodes.APP_SUPPLIER_UPDATE_SUCCESS;
            return supplierDTO;
        }
        #endregion
    }
}
