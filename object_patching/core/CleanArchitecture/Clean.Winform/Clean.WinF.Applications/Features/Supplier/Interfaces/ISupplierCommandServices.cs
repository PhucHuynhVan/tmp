using Clean.WinF.Applications.Features.Supplier.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.Supplier.Interfaces
{
    public interface ISupplierCommandServices
    {
        Task<SupplierDto> CreateNewSupplier(SupplierDto addedSupplier);
        Task<SupplierDto> UpdateSupplier(SupplierDto updatedSupplier);
        Task<SupplierDto> DeleteSupplier(SupplierDto deletedSupplier);
        Task<bool> CreateBulkSuppliers(List<SupplierDto> addedSuppliers);
        Task<bool> UpdateBulkSupliers(List<SupplierDto> updatedSuppliers);
        void ExportBulk(List<SupplierDto> dtos, string filePath);
        List<SupplierDto> ImportBulk(List<SupplierDto> dtos, string filePath);
    }
}
