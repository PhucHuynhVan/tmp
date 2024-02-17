using Clean.WinF.Applications.Features.Supplier.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.Supplier.Interfaces
{
    public interface ISupplierQueryServices
    {
        Task<SupplierDto> GetSupplierById(long id);
        Task<List<SupplierDto>> GetSupplierByName(string supplierName);
        Task<List<SupplierDto>> GetSupplierByCode(string supplierCode);
        Task<List<SupplierDto>> GetAllSuppliers();
        Task<List<SupplierDto>> ListAllAsync();
    }
}
