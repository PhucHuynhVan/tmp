using Clean.WinF.Applications.Features.Protocol.DTOs;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.Protocol.Interfaces
{
    public interface IProtocolCommandServices
    {
        Task<ProtocolDto> CreateNewProtocol(ProtocolDto addedProtocol);
        Task<ProtocolDto> UpdateProtocol(ProtocolDto updatedProtocol);
        Task<ProtocolDto> DeleteProtocol(ProtocolDto deletedProtocol);
    }
}
