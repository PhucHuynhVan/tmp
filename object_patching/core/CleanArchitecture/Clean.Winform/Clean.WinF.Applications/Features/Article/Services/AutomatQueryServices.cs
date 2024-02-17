using Clean.WinF.Applications.Features.Article.DTOs;
using Clean.WinF.Applications.Features.Automat.Interfaces;
using Clean.WinF.Applications.MappingProfiles;
using Clean.WinF.Domain.IRepository;
using Clean.WinF.Shared.ErrorMessage;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.Automat.Services
{
    public sealed class AutomatQueryServices : IAutomatQueryServices
    {
        private readonly IAsyncRepository<Clean.WinF.Domain.Entities.Automat> _articleRepository;
        private readonly IUnitOfWork _unitOfWork;

        private readonly AutoMapper.IMapper _mapper;//implement automapper
        public AutomatQueryServices(IAsyncRepository<Clean.WinF.Domain.Entities.Automat> articleRepository, IUnitOfWork unitOfWork)
        {
            _articleRepository = articleRepository;
            _unitOfWork = unitOfWork;
            _mapper = AutoMapperConfig.Configure();
        }

        public async Task<AutomatDto> GetAutomatById(int id)
        {
            var result = new AutomatDto();

            if (id <= 0)
            {
                result.MessageRet = string.Format(CustomErrorMessage.APP_PART_NOT_FOUND);
                return result;
            }

            try
            {
                var existedAutomat = await _unitOfWork.AutomatRepository.Query().FirstOrDefaultAsync(x => x.ID == id && x.IsActive == true);
                if (existedAutomat != null)
                {
                    result.MessageRet = string.Format(CustomErrorMessage.APP_PART_NOT_FOUND);
                    return result;
                }
            }
            catch (Exception ex)
            {
                Log.Error(string.Concat("GetAutomatById() ", ex.ToString()));
                result.MessageRet = CustomErrorMessage.APP_PART_NOT_FOUND;
                return result;
            }

            return result;
        }

        public async Task<List<AutomatDto>> GetAutomatByName(string name)
        {
            var result = new List<AutomatDto>();

            try
            {
                IQueryable<Clean.WinF.Domain.Entities.Automat> existedAutomats = null;
                if (!string.IsNullOrEmpty(name))
                {
                    existedAutomats = (IQueryable<Clean.WinF.Domain.Entities.Automat>)_articleRepository.Query().Where(p => p.Name.Contains(name) && p.IsActive == true).ToList();
                }
                else
                {
                    existedAutomats = (IQueryable<Clean.WinF.Domain.Entities.Automat>)_articleRepository.Query().Where(p => p.IsActive == true).ToList();
                }

                if (existedAutomats != null)
                {

                    foreach (var automat in existedAutomats)
                    {

                        var automatDTO = _mapper.Map<AutomatDto>(automat);
                        result.Add(automatDTO);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(string.Concat("GetAutomatByName() ", ex.ToString()));
                return null;
            }

            return result;
        }

        public async Task<List<AutomatDto>> GetAutomatByCode(string code)
        {
            var result = new List<AutomatDto>();

            try
            {
                IQueryable<Clean.WinF.Domain.Entities.Automat> existedAutomats = null;
                if (!string.IsNullOrEmpty(code))
                {
                    existedAutomats = (IQueryable<Clean.WinF.Domain.Entities.Automat>)_articleRepository.Query().Where(p => p.Name.Contains(code) && p.IsActive == true).ToList();
                }
                else
                {
                    existedAutomats = (IQueryable<Clean.WinF.Domain.Entities.Automat>)_articleRepository.Query().Where(p => p.IsActive == true).ToList();
                }

                if (existedAutomats != null)
                {
                    foreach (var automat in existedAutomats)
                    {

                        var automatDTO = _mapper.Map<AutomatDto>(automat);
                        result.Add(automatDTO);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(string.Concat("GetAutomatByCode() ", ex.ToString()));
                return null;
            }

            return result;
        }

        public async Task<List<AutomatDto>> GetAllAutomats()
        {
            var result = new List<AutomatDto>();

            try
            {
                IQueryable<Clean.WinF.Domain.Entities.Automat> existedAutomats = null;
                existedAutomats = (IQueryable<Clean.WinF.Domain.Entities.Automat>)_articleRepository.Query().Where(p => p.IsActive == true).ToList();

                if (existedAutomats != null)
                {
                    foreach (var automat in existedAutomats)
                    {
                        var automatDTO = _mapper.Map<AutomatDto>(automat);
                        result.Add(automatDTO);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(string.Concat("GetAllAutomats() ", ex.ToString()));
                return null;
            }

            return result;
        }

        public async Task<List<AutomatDto>> ListAllAsync()
        {
            var result = new List<AutomatDto>();

            try
            {
                IEnumerable<Domain.Entities.Automat> existedAutomats = null;
                existedAutomats = _unitOfWork.AutomatRepository.ListAllAsync().Result;

                if (existedAutomats != null)
                {
                    foreach (var automat in existedAutomats)
                    {
                        var automatDTO = _mapper.Map<AutomatDto>(automat);
                        result.Add(automatDTO);
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
