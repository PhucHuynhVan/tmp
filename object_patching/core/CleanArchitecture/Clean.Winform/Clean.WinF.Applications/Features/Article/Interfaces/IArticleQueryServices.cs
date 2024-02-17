using Clean.WinF.Applications.Features.Article.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.Article.Interfaces
{
    public interface IArticleQueryServices
    {
        Task<ArticleDto> GetArticleById(long id);
        Task<List<ArticleDto>> GetArticleByName(string articleName);
        Task<List<ArticleDto>> GetArticleByCode(string articleNumber);
        Task<List<ArticleDto>> GetAllArticles();
        Task<List<ArticleDto>> ListAllAsync();
    }
}
