using Clean.WinF.Applications.Features.Supplier.DTOs;
using Clean.WinF.Applications.Features.Thread.DTOs;
using Clean.WinF.Applications.Features.Thread.Interfaces;
using Clean.WinF.Applications.MappingProfiles;
using Clean.WinF.Domain.IRepository;
using Clean.WinF.Shared.Constants;
using Serilog;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.Supplier.Services
{
    public class ThreadCommandServices : IThreadCommandServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly AutoMapper.IMapper _mapper;

        public ThreadCommandServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = AutoMapperConfig.Configure();
        }

        public async Task<bool> CreateBulk(List<ThreadDto> dtos)
        {
            var result = true;
            try
            {
                if (dtos != null)
                {
                    var bulks = new List<Domain.Entities.Thread>();
                    foreach (var supplierDto in dtos)
                    {
                        bulks.Add(_mapper.Map<Domain.Entities.Thread>(supplierDto));
                    }

                    if (bulks != null && bulks.Count > 0)
                        result = await _unitOfWork.ThreadRepository.AddBulkEntitiesAsync(bulks);
                }
            }
            catch (Exception ex)
            {
                Log.Error($"CreateBulkThreads() error: {ex.ToString()}");
                return result;
            }

            return result;
        }

        public async Task<bool> UpdateBulk(List<ThreadDto> dtos)
        {
            var result = true;
            try
            {
                if (dtos != null)
                {
                    var bulks = new List<Domain.Entities.Thread>();
                    foreach (var dto in dtos)
                    {
                        bulks.Add(_mapper.Map<Domain.Entities.Thread>(dto));
                    }

                    if (bulks != null && bulks.Count > 0)
                        result = await _unitOfWork.ThreadRepository.UpdateBulkEntitiesAsync(bulks);
                }
            }
            catch (Exception ex)
            {
                Log.Error($"UpdateBulkThreads() error: {ex.ToString()}");
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
