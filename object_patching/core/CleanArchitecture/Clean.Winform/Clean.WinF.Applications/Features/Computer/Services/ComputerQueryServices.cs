using Clean.WinF.Applications.Features.Computer.DTOs;
using Clean.WinF.Applications.Features.Computer.Interfaces;
using Clean.WinF.Applications.MappingProfiles;
using Clean.WinF.Domain.IRepository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.Computer.Services
{
    public class ComputerQueryServices : IComputerQueryServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly AutoMapper.IMapper _mapper;

        public ComputerQueryServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = AutoMapperConfig.Configure();
        }

        public Task<List<ComputerDto>> GetAllComputers()
        {
            throw new NotImplementedException();
        }

        public Task<ComputerDto> GetComputerById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ComputerDto>> GetComputerByName(string computerName)
        {
            throw new NotImplementedException();
        }

        public Task<ComputerDto> GetComputerNumber(string computerNo)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ComputerDto>> ListAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
