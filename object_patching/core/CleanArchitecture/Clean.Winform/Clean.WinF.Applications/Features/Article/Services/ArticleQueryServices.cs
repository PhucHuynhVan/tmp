using Clean.WinF.Applications.Features.Article.DTOs;
using Clean.WinF.Applications.Features.Article.Interfaces;
using Clean.WinF.Applications.MappingProfiles;
using Clean.WinF.Domain.IRepository;
using Clean.WinF.Shared.ErrorMessage;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.Article.Services
{
    public sealed class ArticleQueryServices : IArticleQueryServices
    {
        private readonly IAsyncRepository<Clean.WinF.Domain.Entities.Article> _articleRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly AutoMapper.IMapper _mapper;
        public ArticleQueryServices(IAsyncRepository<Clean.WinF.Domain.Entities.Article> articleRepository, IUnitOfWork unitOfWork)
        {
            _articleRepository = articleRepository;
            _unitOfWork = unitOfWork;
            _mapper = AutoMapperConfig.Configure();
        }

        public async Task<ArticleDto> GetArticleById(long id)
        {
            var result = new ArticleDto();

            if (id <= 0)
            {
                result.MessageRet = string.Format(CustomErrorMessage.APP_PART_NOT_FOUND);
                return result;
            }

            try
            {
                var existedArticle = await _unitOfWork.ArticleRepository.GetQuerywithIncludeAsync("Automat").FirstOrDefaultAsync(x => x.ID == id && x.IsActive == true);
                if (existedArticle != null)
                {
                    return _mapper.Map<Domain.Entities.Article, ArticleDto>(existedArticle);
                }
            }
            catch (Exception ex)
            {
                Log.Error(string.Concat("GetArticleById() ", ex.ToString()));
                result.MessageRet = CustomErrorMessage.APP_PART_NOT_FOUND;
                return result;
            }

            return result;
        }

        public async Task<List<ArticleDto>> GetArticleByName(string name)
        {
            var result = new List<ArticleDto>();

            try
            {
                IQueryable<Clean.WinF.Domain.Entities.Article> existedArticles = null;
                if (!string.IsNullOrEmpty(name))
                {
                    existedArticles = (IQueryable<Clean.WinF.Domain.Entities.Article>)_articleRepository.Query().Where(p => p.Name.Contains(name) && p.IsActive == true).ToList();
                }
                else
                {
                    existedArticles = (IQueryable<Clean.WinF.Domain.Entities.Article>)_articleRepository.Query().Where(p => p.IsActive == true).ToList();
                }

                if (existedArticles != null)
                {
                    foreach (var article in existedArticles)
                    {
                        var articleDto = _mapper.Map<Clean.WinF.Domain.Entities.Article, ArticleDto>(article);
                        result.Add(articleDto);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(string.Concat("GetArticleByName() ", ex.ToString()));
                return null;
            }

            return result;
        }

        public async Task<List<ArticleDto>> GetArticleByCode(string code)
        {
            var result = new List<ArticleDto>();

            try
            {
                IQueryable<Clean.WinF.Domain.Entities.Article> existedArticles = null;
                if (!string.IsNullOrEmpty(code))
                {
                    existedArticles = (IQueryable<Clean.WinF.Domain.Entities.Article>)_articleRepository.Query().Where(p => p.Name.Contains(code) && p.IsActive == true).ToList();
                }
                else
                {
                    existedArticles = (IQueryable<Clean.WinF.Domain.Entities.Article>)_articleRepository.Query().Where(p => p.IsActive == true).ToList();
                }

                if (existedArticles != null)
                {
                    foreach (var article in existedArticles)
                    {
                        var articleDto = _mapper.Map<Clean.WinF.Domain.Entities.Article, ArticleDto>(article);
                        result.Add(articleDto);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(string.Concat("GetArticleByCode() ", ex.ToString()));
                return null;
            }

            return result;
        }

        public async Task<List<ArticleDto>> GetAllArticles()
        {
            var result = new List<ArticleDto>();

            try
            {
                IQueryable<Clean.WinF.Domain.Entities.Article> existedArticles = null;
                existedArticles = (IQueryable<Clean.WinF.Domain.Entities.Article>)_articleRepository.Query().Where(p => p.IsActive == true).ToList();

                if (existedArticles != null)
                {
                    foreach (var article in existedArticles)
                    {
                        var articleDto = _mapper.Map<Clean.WinF.Domain.Entities.Article, ArticleDto>(article);
                        result.Add(articleDto);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(string.Concat("GetAllArticles() ", ex.ToString()));
                return null;
            }

            return result;
        }

        public async Task<List<ArticleDto>> ListAllAsync()
        {
            var result = new List<ArticleDto>();

            try
            {
                IEnumerable<Domain.Entities.Article> existedArticles = null;
                existedArticles = _unitOfWork.ArticleRepository.Query()
                                            .Include(automat => automat.Automat);

                if (existedArticles != null)
                {
                    foreach (var article in existedArticles)
                    {
                        var articleDto = _mapper.Map<Clean.WinF.Domain.Entities.Article, ArticleDto>(article);
                        result.Add(articleDto);
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
