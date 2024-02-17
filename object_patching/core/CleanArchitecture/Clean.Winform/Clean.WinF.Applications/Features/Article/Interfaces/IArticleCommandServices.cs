using Clean.WinF.Applications.Features.Article.DTOs;
using Clean.WinF.Applications.Features.Part.DTOs;
using Clean.WinF.Applications.Features.Thread.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Clean.WinF.Applications.Features.Article.Interfaces
{
    public interface IArticleCommandServices
    {
        Task<ArticleDto> CreateNewArticle(ArticleDto addedArticle);
        Task<ArticleDto> UpdateArticle(ArticleDto updatedArticle);
        Task<ArticleDto> DeleteArticle(ArticleDto deletedArticle);
        Task<bool> CreateBulkArticles(List<ArticleDto> addedArticles);
        Task<bool> UpdateBulkArticles(List<ArticleDto> updatedArticles);
        void ExportBulkArticles(List<ArticleDto> updatedArticles, string filePath);
        List<ArticleDto> ImportBulkArticles(List<ArticleDto> updatedArticles, List<AutomatDto> automatDtos, IEnumerable<ThreadDto> _dataThread, IEnumerable<PartDto> _dataPart, string filePath);

    }
}
