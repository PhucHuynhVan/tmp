using Clean.WinF.Applications.Features.Protocol.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.Protocol.Interfaces
{
    public interface IProtocolQueryServices
    {
        Task<ProtocolDto> GetProtocolById(int id);
        Task<ProtocolDto> GetProtocolByName(string name);
        Task<List<ProtocolDto>> GetAllProtocols();
        Task<IEnumerable<ProtocolDto>> ListAllAsync();
    }
}
