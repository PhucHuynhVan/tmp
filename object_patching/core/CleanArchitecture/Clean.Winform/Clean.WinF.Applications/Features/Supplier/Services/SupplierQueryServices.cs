using Clean.WinF.Applications.Features.Supplier.DTOs;
using Clean.WinF.Applications.Features.Supplier.Interfaces;
using Clean.WinF.Applications.MappingProfiles;
using Clean.WinF.Domain.IRepository;
using Clean.WinF.Shared.ErrorMessage;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.Supplier.Services
{
    public sealed class SupplierQueryServices : ISupplierQueryServices
    {
        private readonly IAsyncRepository<Clean.WinF.Domain.Entities.Supplier> _supplierRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly AutoMapper.IMapper _mapper;
        public SupplierQueryServices(IAsyncRepository<Clean.WinF.Domain.Entities.Supplier> supplierRepository, IUnitOfWork unitOfWork)
        {
            _supplierRepository = supplierRepository;
            _unitOfWork = unitOfWork;
            _mapper = AutoMapperConfig.Configure();
        }

        public async Task<SupplierDto> GetSupplierById(long id)
        {
            var result = new SupplierDto();

            if (id <= 0)
            {
                result.MessageRet = string.Format(CustomErrorMessage.APP_SUPPLIER_NOT_FOUND);
                return result;
            }

            try
            {
                var existedSupplier = await _unitOfWork.SupplierRepository.Query().FirstOrDefaultAsync(x => x.ID == id && x.IsActive == true);
                if (existedSupplier != null)
                {
                    return _mapper.Map<Clean.WinF.Domain.Entities.Supplier, SupplierDto>(existedSupplier);
                }
            }
            catch (Exception ex)
            {
                Log.Error(string.Concat("GetSupplierById() ", ex.ToString()));
                result.MessageRet = CustomErrorMessage.APP_SUPPLIER_NOT_FOUND;
                return result;
            }

            return result;
        }
        public async Task<List<SupplierDto>> GetSupplierByCode(string code)
        {
            var result = new List<SupplierDto>();

            try
            {
                IQueryable<Clean.WinF.Domain.Entities.Supplier> existedSuppliers = null;
                if (!string.IsNullOrEmpty(code))
                {
                    existedSuppliers = (IQueryable<Clean.WinF.Domain.Entities.Supplier>)_supplierRepository.Query().Where(p => p.Name.Contains(code) && p.IsActive == true).ToList();
                }
                else
                {
                    existedSuppliers = (IQueryable<Clean.WinF.Domain.Entities.Supplier>)_supplierRepository.Query().Where(p => p.IsActive == true).ToList();
                }

                if (existedSuppliers != null)
                {
                    foreach (var supplier in existedSuppliers)
                    {
                        var supplierDto = _mapper.Map<Clean.WinF.Domain.Entities.Supplier, SupplierDto>(supplier);
                        result.Add(supplierDto);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(string.Concat("GetSupplierByCode() ", ex.ToString()));
                return null;
            }

            return result;
        }
        public async Task<List<SupplierDto>> GetSupplierByName(string name)
        {
            var result = new List<SupplierDto>();

            try
            {
                IQueryable<Clean.WinF.Domain.Entities.Supplier> existedSuppliers = null;
                if (!string.IsNullOrEmpty(name))
                {
                    existedSuppliers = (IQueryable<Clean.WinF.Domain.Entities.Supplier>)_supplierRepository.Query().Where(p => p.Name.Contains(name) && p.IsActive == true).ToList();
                }
                else
                {
                    existedSuppliers = (IQueryable<Clean.WinF.Domain.Entities.Supplier>)_supplierRepository.Query().Where(p => p.IsActive == true).ToList();
                }

                if (existedSuppliers != null)
                {
                    foreach (var supplier in existedSuppliers)
                    {
                        var supplierDto = _mapper.Map<Clean.WinF.Domain.Entities.Supplier, SupplierDto>(supplier);
                        result.Add(supplierDto);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(string.Concat("GetSupplierByName() ", ex.ToString()));
                return null;
            }

            return result;
        }
        public async Task<List<SupplierDto>> GetAllSuppliers()
        {
            var result = new List<SupplierDto>();

            try
            {
                IQueryable<Clean.WinF.Domain.Entities.Supplier> existedSuppliers = null;
                existedSuppliers = (IQueryable<Clean.WinF.Domain.Entities.Supplier>)_supplierRepository.Query().Where(p => p.IsActive == true).ToList();
                if (existedSuppliers != null)
                {
                    foreach (var supplier in existedSuppliers)
                    {
                        var supplierDto = _mapper.Map<Clean.WinF.Domain.Entities.Supplier, SupplierDto>(supplier);
                        result.Add(supplierDto);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(string.Concat("GetAllSuppliers() ", ex.ToString()));
                return null;
            }
            return result;
        }
        public async Task<List<SupplierDto>> ListAllAsync()
        {
            var result = new List<SupplierDto>();

            try
            {
                IEnumerable<Domain.Entities.Supplier> existedSuppliers = null;
                existedSuppliers = _unitOfWork.SupplierRepository.Query();

                if (existedSuppliers != null)
                {
                    foreach (var supplier in existedSuppliers)
                    {
                        var supplierDto = _mapper.Map<Clean.WinF.Domain.Entities.Supplier, SupplierDto>(supplier);
                        result.Add(supplierDto);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(string.Concat("ListAllAsync() ", ex.ToString()));
                return null;
            }

            return result;
        }
    }
}
