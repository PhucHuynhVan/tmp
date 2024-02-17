using Clean.WinF.Applications.Features.Article.DTOs;
using Clean.WinF.Applications.Features.Article.Interfaces;
using Clean.WinF.Applications.Features.Part.DTOs;
using Clean.WinF.Applications.Features.Thread.DTOs;
using Clean.WinF.Applications.MappingProfiles;
using Clean.WinF.Common.Utilities;
using Clean.WinF.Domain.IRepository;
using Clean.WinF.Shared.Constants;
using Clean.WinF.Shared.ErrorMessage;
using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Clean.WinF.Applications.Features.Article.Services
{
    public class ArticleCommandServices : IArticleCommandServices
    {
        private readonly IAsyncRepository<Clean.WinF.Domain.Entities.Article> _articleRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly AutoMapper.IMapper _mapper;//implement automapper


        public ArticleCommandServices(IAsyncRepository<Clean.WinF.Domain.Entities.Article> articleRepository, IUnitOfWork unitOfWork)
        {
            _articleRepository = articleRepository;
            _unitOfWork = unitOfWork;
            _mapper = AutoMapperConfig.Configure();
        }

        public async Task<ArticleDto> CreateNewArticle(ArticleDto addArticle)
        {
            var result = new ArticleDto();

            if (string.IsNullOrEmpty(addArticle.Name.Trim()))
            {
                result.CustomErrorCode = CustomErrorCode.APP_ARTICLE_CODE_EMPTY;
                result.MessageRet = string.Format(CustomErrorMessage.APP_ARTICLE_NAME_EMPTY);
                return result;
            }

            if (string.IsNullOrEmpty(addArticle.Code.Trim()))
            {
                result.CustomErrorCode = CustomErrorCode.APP_ARTICLE_NAME_EMPTY;
                result.MessageRet = string.Format(CustomErrorMessage.APP_ARTICLE_NAME_EMPTY);
                return result;
            }

            var existedArticle = await _unitOfWork.ArticleRepository.Query().FirstOrDefaultAsync(x => x.Code.Equals(addArticle.Code) && x.IsActive == true);
            if (existedArticle != null)
            {
                result.MessageRet = string.Format(CustomErrorMessage.APP_ARTICLE_CODE_EXISTED_ALREADY);
                return result;
            }

            if (CleanWinFUtility.HasSpecialCharacters(addArticle.Code.Trim()))
            {
                result.CustomErrorCode = CustomErrorCode.APP_ARTICLE_INVALID_NAME;
                result.MessageRet = CustomErrorMessage.APP_ARTICLE_INVALID_NAME;
                return result;
            }

            if (CleanWinFUtility.HasSpecialCharacters(addArticle.Name.Trim()))
            {
                result.CustomErrorCode = CustomErrorCode.APP_ARTICLE_INVALID_CODE;
                result.MessageRet = CustomErrorMessage.APP_ARTICLE_INVALID_CODE;
                return result;
            }

            //add new to db
            var newArticle = _mapper.Map<Domain.Entities.Article>(addArticle);
            newArticle.AutomatID = newArticle.Automat.ID;
            newArticle.Automat = null;
            newArticle.CreatedOn = DateTime.Now;
            newArticle.UpdatedOn = DateTime.Now;


            try
            {
                var articleResult = await _unitOfWork.ArticleRepository.AddAsync(newArticle);
                var resultAdd = _unitOfWork.Complete();
                if (resultAdd > 0)
                {
                    result.CustomErrorCode = CustomOperationCodes.APP_ARTICLE_ADD_SUCCESS;
                    result.MessageRet = CustomOperationCodes.APP_ARTICLE_ADD_SUCCESS;

                }
                else
                {
                    result.CustomErrorCode = CustomOperationCodes.APP_ARTICLE_ADD_FAIL;
                    result.MessageRet = CustomOperationCodes.APP_ARTICLE_ADD_FAIL;
                }
            }
            catch (Exception ex)
            {
                Log.Error(string.Concat("CreateNewArticle() ", ex.ToString()));
                result.MessageRet = CustomOperationCodes.APP_ARTICLE_ADD_FAIL;
                return result;
            }

            return result;
        }

        public async Task<bool> CreateBulkArticles(List<ArticleDto> addedArticles)
        {
            var result = true;
            try
            {
                if (addedArticles != null)
                {
                    var bulkArticles = new List<Domain.Entities.Article>();
                    foreach (var articleDto in addedArticles)
                    {
                        var article = _mapper.Map<Domain.Entities.Article>(articleDto);
                        article.AutomatID = article.Automat.ID;
                        article.Automat = null;
                        bulkArticles.Add(article);
                    }

                    if (bulkArticles != null && bulkArticles.Count > 0)
                        result = await _unitOfWork.ArticleRepository.AddBulkEntitiesAsync(bulkArticles);
                }
            }
            catch (Exception ex)
            {
                Log.Error($"CreateBulkArticles() error: {ex.ToString()}");
                return result;
            }

            return result;
        }

        public async Task<ArticleDto> UpdateArticle(ArticleDto updatedArticle)
        {
            var result = new ArticleDto();

            if (string.IsNullOrEmpty(updatedArticle.Name.Trim()))
            {
                result.MessageRet = string.Format(CustomErrorMessage.APP_ARTICLE_NAME_EMPTY);
                return result;
            }

            if (string.IsNullOrEmpty(updatedArticle.Code.Trim()))
            {
                result.MessageRet = string.Format(CustomErrorMessage.APP_ARTICLE_NAME_EMPTY);
                return result;
            }

            if (CleanWinFUtility.HasSpecialCharacters(updatedArticle.Name) || CleanWinFUtility.HasSpecialCharacters(updatedArticle.Code))
            {
                result.MessageRet = string.Format(CustomErrorMessage.APP_ARTICLE_NAME_EMPTY);
                return result;
            }

            // existedArticle = await _unitOfWork.ArticleRepository.Query().FirstOrDefaultAsync(x => x.Code.Equals(updatedArticle.Code) && x.IsActive == true);

            //if (existedArticle != null)
            //{
            //    result.MessageRet = string.Format(CustomErrorMessage.APP_ARTICLE_IS_EXIST, existedArticle.ID);
            //    return result;
            //}
            var existedArticle = _mapper.Map<Domain.Entities.Article>(updatedArticle);
            existedArticle.AutomatID = existedArticle.Automat.ID;
            existedArticle.Automat = null;
            existedArticle.UpdatedOn = DateTime.Now;
            try
            {
                var resultUpdated = await _unitOfWork.ArticleRepository.UpdateAsync(existedArticle);
                result = UpdateArticleInfo(resultUpdated);
            }
            catch (Exception ex)
            {
                Log.Error($"UpdateGroup() error: {ex.ToString()}");
                return result;
            }

            return result;
        }

        public async Task<bool> UpdateBulkArticles(List<ArticleDto> updatedArticles)
        {
            var result = true;
            try
            {
                if (updatedArticles != null)
                {
                    var bulkArticles = new List<Domain.Entities.Article>();
                    foreach (var articleDto in updatedArticles)
                    {
                        var article = _mapper.Map<Domain.Entities.Article>(articleDto);
                        article.AutomatID = article.Automat.ID;
                        article.Automat = null;
                        bulkArticles.Add(article);
                    }

                    if (bulkArticles != null && bulkArticles.Count > 0)
                        result = await _unitOfWork.ArticleRepository.UpdateBulkEntitiesAsync(bulkArticles);
                }
            }
            catch (Exception ex)
            {
                Log.Error($"UpdateBulkArticles() error: {ex.ToString()}");
                return result;
            }

            return result;
        }

        public async Task<ArticleDto> DeleteArticle(ArticleDto deletedArticle)
        {
            var result = new ArticleDto();

            var existedArticle = await _unitOfWork.ArticleRepository.Query().FirstOrDefaultAsync(x => x.ID == deletedArticle.ID);

            if (existedArticle is null || existedArticle.IsActive == false)
            {
                result.MessageRet = string.Format(CustomErrorMessage.APP_ARTICLE_NOT_FOUND, deletedArticle.ID);
                return result;
            }

            existedArticle.UpdatedOn = DateTime.UtcNow;
            existedArticle.UpdatedBy = "Test";
            existedArticle.IsActive = false;

            try
            {
                var resultUpdated = await _unitOfWork.ArticleRepository.UpdateAsync(existedArticle);
            }
            catch (Exception ex)
            {
                Log.Error($"DeleteArticle() error: {ex.ToString()}");
                result.MessageRet = string.Format(CustomErrorMessage.APP_ARTICLE_REMOVED_FAIL, existedArticle.Code);
                return result;
            }

            return result;
        }

        #region private functions
        private ArticleDto UpdateArticleInfo(Domain.Entities.Article article)
        {
            if (article is null) return null;

            var articleDTO = _mapper.Map<ArticleDto>(article);
            articleDTO.CustomErrorCode = CustomOperationCodes.APP_ARTICLE_UPDATE_SUCCESS;
            articleDTO.MessageRet = CustomOperationCodes.APP_ARTICLE_UPDATE_SUCCESS;
            return articleDTO;
        }
        static string GetCellAddress(int row, int col)
        {
            string columnName = GetColumnName(col);
            return $"{columnName}{row}";
        }

        // Custom function to get the column name based on the column index
        static string GetColumnName(int columnNumber)
        {
            const int baseNumber = 'Z' - 'A' + 1;
            string columnName = "";

            while (columnNumber > 0)
            {
                int remainder = (columnNumber - 1) % baseNumber;
                columnName = (char)('A' + remainder) + columnName;
                columnNumber = (columnNumber - 1) / baseNumber;
            }

            return columnName;
        }


        public void ExportBulkArticles(List<ArticleDto> updatedArticles, string filePath)
        {

            // Create a new Excel package
            using (var workbook = new XLWorkbook())
            {
                // Get the default worksheet
                var worksheet = workbook.Worksheets.Add("Sheet1");

                var cellRange1 = worksheet.Range("B1:Q1");
                cellRange1.Merge();
                cellRange1.Style.Border.TopBorder = XLBorderStyleValues.Thin;
                cellRange1.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                cellRange1.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                cellRange1.Style.Border.RightBorder = XLBorderStyleValues.Thin;
                cellRange1.Style.Fill.PatternType = XLFillPatternValues.Solid;
                cellRange1.Style.Fill.BackgroundColor = XLColor.FromHtml("#D9D9D9");
                cellRange1.Style.Font.Bold = true;
                var cellRange2 = worksheet.Range("R1:W1");
                cellRange2.Merge();
                cellRange2.Style.Border.TopBorder = XLBorderStyleValues.Thin;
                cellRange2.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                cellRange2.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                cellRange2.Style.Border.RightBorder = XLBorderStyleValues.Thin;
                cellRange2.Style.Fill.PatternType = XLFillPatternValues.Solid;
                cellRange2.Style.Fill.BackgroundColor = XLColor.FromHtml("#D9D9D9");
                cellRange2.Style.Font.Bold = true;
                var cellRange3 = worksheet.Range("X1:AC1");
                cellRange3.Merge();
                cellRange3.Style.Border.TopBorder = XLBorderStyleValues.Thin;
                cellRange3.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                cellRange3.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                cellRange3.Style.Border.RightBorder = XLBorderStyleValues.Thin;
                cellRange3.Style.Fill.PatternType = XLFillPatternValues.Solid;
                cellRange3.Style.Fill.BackgroundColor = XLColor.FromHtml("#D9D9D9");
                cellRange3.Style.Font.Bold = true;
                var cellRange4 = worksheet.Range("AD1:AI1");
                cellRange4.Merge();
                cellRange4.Style.Border.TopBorder = XLBorderStyleValues.Thin;
                cellRange4.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                cellRange4.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                cellRange4.Style.Border.RightBorder = XLBorderStyleValues.Thin;
                cellRange4.Style.Fill.PatternType = XLFillPatternValues.Solid;
                cellRange4.Style.Fill.BackgroundColor = XLColor.FromHtml("#D9D9D9");
                cellRange4.Style.Font.Bold = true;
                var cellRange5 = worksheet.Range("AJ1:AO1");
                cellRange5.Merge();
                cellRange5.Style.Border.TopBorder = XLBorderStyleValues.Thin;
                cellRange5.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                cellRange5.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                cellRange5.Style.Border.RightBorder = XLBorderStyleValues.Thin;
                cellRange5.Style.Fill.PatternType = XLFillPatternValues.Solid;
                cellRange5.Style.Fill.BackgroundColor = XLColor.FromHtml("#D9D9D9");
                cellRange5.Style.Font.Bold = true;
                var cellRange6 = worksheet.Range("AP1:AU1");
                cellRange6.Merge();
                cellRange6.Style.Border.TopBorder = XLBorderStyleValues.Thin;
                cellRange6.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                cellRange6.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                cellRange6.Style.Border.RightBorder = XLBorderStyleValues.Thin;
                cellRange6.Style.Fill.PatternType = XLFillPatternValues.Solid;
                cellRange6.Style.Fill.BackgroundColor = XLColor.FromHtml("#D9D9D9");
                cellRange6.Style.Font.Bold = true;
                var cellRange7 = worksheet.Range("AV1:AW1");
                cellRange7.Merge();
                cellRange7.Style.Border.TopBorder = XLBorderStyleValues.Thin;
                cellRange7.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                cellRange7.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                cellRange7.Style.Border.RightBorder = XLBorderStyleValues.Thin;
                cellRange7.Style.Fill.PatternType = XLFillPatternValues.Solid;
                cellRange7.Style.Fill.BackgroundColor = XLColor.FromHtml("#D9D9D9");
                cellRange7.Style.Font.Bold = true;
                var cellRange8 = worksheet.Range("AX1:BA1");
                cellRange8.Merge();
                cellRange8.Style.Border.TopBorder = XLBorderStyleValues.Thin;
                cellRange8.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                cellRange8.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                cellRange8.Style.Border.RightBorder = XLBorderStyleValues.Thin;
                cellRange8.Style.Fill.PatternType = XLFillPatternValues.Solid;
                cellRange8.Style.Fill.BackgroundColor = XLColor.FromHtml("#D9D9D9");
                cellRange8.Style.Font.Bold = true;
                var cellRange9 = worksheet.Range("BB1:BD1");
                cellRange9.Merge();
                cellRange9.Style.Border.TopBorder = XLBorderStyleValues.Thin;
                cellRange9.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                cellRange9.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                cellRange9.Style.Border.RightBorder = XLBorderStyleValues.Thin;
                cellRange9.Style.Fill.PatternType = XLFillPatternValues.Solid;
                cellRange9.Style.Fill.BackgroundColor = XLColor.FromHtml("#D9D9D9");
                cellRange9.Style.Font.Bold = true;
                var cellRange10 = worksheet.Range("BE1:BG1");
                cellRange10.Merge();
                cellRange10.Style.Border.TopBorder = XLBorderStyleValues.Thin;
                cellRange10.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                cellRange10.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                cellRange10.Style.Border.RightBorder = XLBorderStyleValues.Thin;
                cellRange10.Style.Fill.PatternType = XLFillPatternValues.Solid;
                cellRange10.Style.Fill.BackgroundColor = XLColor.FromHtml("#D9D9D9");
                cellRange10.Style.Font.Bold = true;
                var cellRange11 = worksheet.Range("BH1:BJ1");
                cellRange11.Merge();
                cellRange11.Style.Border.TopBorder = XLBorderStyleValues.Thin;
                cellRange11.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                cellRange11.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                cellRange11.Style.Border.RightBorder = XLBorderStyleValues.Thin;
                cellRange11.Style.Fill.PatternType = XLFillPatternValues.Solid;
                cellRange11.Style.Fill.BackgroundColor = XLColor.FromHtml("#D9D9D9");
                cellRange11.Style.Font.Bold = true;
                var cellRange12 = worksheet.Range("BK1:BM1");
                cellRange12.Merge();
                cellRange12.Style.Border.TopBorder = XLBorderStyleValues.Thin;
                cellRange12.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                cellRange12.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                cellRange12.Style.Border.RightBorder = XLBorderStyleValues.Thin;
                cellRange12.Style.Fill.PatternType = XLFillPatternValues.Solid;
                cellRange12.Style.Fill.BackgroundColor = XLColor.FromHtml("#D9D9D9");
                cellRange12.Style.Font.Bold = true;
                var cellRange13 = worksheet.Range("BN1:BP1");
                cellRange13.Merge();
                cellRange13.Style.Border.TopBorder = XLBorderStyleValues.Thin;
                cellRange13.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                cellRange13.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                cellRange13.Style.Border.RightBorder = XLBorderStyleValues.Thin;
                cellRange13.Style.Fill.PatternType = XLFillPatternValues.Solid;
                cellRange13.Style.Fill.BackgroundColor = XLColor.FromHtml("#D9D9D9");
                cellRange13.Style.Font.Bold = true;
                var cellRange14 = worksheet.Range("BQ1:BT1");
                cellRange14.Merge();
                cellRange14.Style.Border.TopBorder = XLBorderStyleValues.Thin;
                cellRange14.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                cellRange14.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                cellRange14.Style.Border.RightBorder = XLBorderStyleValues.Thin;
                cellRange14.Style.Fill.PatternType = XLFillPatternValues.Solid;
                cellRange14.Style.Fill.BackgroundColor = XLColor.FromHtml("#D9D9D9");
                cellRange14.Style.Font.Bold = true;
                var cellRange15 = worksheet.Range("BU1:BX1");
                cellRange15.Merge();
                cellRange15.Style.Border.TopBorder = XLBorderStyleValues.Thin;
                cellRange15.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                cellRange15.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                cellRange15.Style.Border.RightBorder = XLBorderStyleValues.Thin;
                cellRange15.Style.Fill.PatternType = XLFillPatternValues.Solid;
                cellRange15.Style.Fill.BackgroundColor = XLColor.FromHtml("#D9D9D9");
                cellRange15.Style.Font.Bold = true;
                var cellRange16 = worksheet.Range("BY1:BZ1");
                cellRange16.Merge();
                cellRange16.Style.Border.TopBorder = XLBorderStyleValues.Thin;
                cellRange16.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                cellRange16.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                cellRange16.Style.Border.RightBorder = XLBorderStyleValues.Thin;
                cellRange16.Style.Fill.PatternType = XLFillPatternValues.Solid;
                cellRange16.Style.Fill.BackgroundColor = XLColor.FromHtml("#D9D9D9");
                cellRange16.Style.Font.Bold = true;
                var cellRange17 = worksheet.Range("CA1:CE1");
                cellRange17.Merge();
                cellRange17.Style.Border.TopBorder = XLBorderStyleValues.Thin;
                cellRange17.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                cellRange17.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                cellRange17.Style.Border.RightBorder = XLBorderStyleValues.Thin;
                cellRange17.Style.Fill.PatternType = XLFillPatternValues.Solid;
                cellRange17.Style.Fill.BackgroundColor = XLColor.FromHtml("#D9D9D9");
                cellRange17.Style.Font.Bold = true;
                var cellRange18 = worksheet.Range("CF1:CJ1");
                cellRange18.Merge();
                cellRange18.Style.Border.TopBorder = XLBorderStyleValues.Thin;
                cellRange18.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                cellRange18.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                cellRange18.Style.Border.RightBorder = XLBorderStyleValues.Thin;
                cellRange18.Style.Fill.PatternType = XLFillPatternValues.Solid;
                cellRange18.Style.Fill.BackgroundColor = XLColor.FromHtml("#D9D9D9");
                cellRange18.Style.Font.Bold = true;
                var cellRange19 = worksheet.Range("CK1:CM1");
                cellRange19.Merge();
                cellRange19.Style.Border.TopBorder = XLBorderStyleValues.Thin;
                cellRange19.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                cellRange19.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                cellRange19.Style.Border.RightBorder = XLBorderStyleValues.Thin;
                cellRange19.Style.Fill.PatternType = XLFillPatternValues.Solid;
                cellRange19.Style.Fill.BackgroundColor = XLColor.FromHtml("#D9D9D9");
                cellRange19.Style.Font.Bold = true;
                var cellRange20 = worksheet.Range("CN1:CP1");
                cellRange20.Merge();
                cellRange20.Style.Border.TopBorder = XLBorderStyleValues.Thin;
                cellRange20.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                cellRange20.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                cellRange20.Style.Border.RightBorder = XLBorderStyleValues.Thin;
                cellRange20.Style.Fill.PatternType = XLFillPatternValues.Solid;
                cellRange20.Style.Fill.BackgroundColor = XLColor.FromHtml("#D9D9D9");
                cellRange20.Style.Font.Bold = true;
                var cellRange21 = worksheet.Range("CQ1:CS1");
                cellRange21.Merge();
                cellRange21.Style.Border.TopBorder = XLBorderStyleValues.Thin;
                cellRange21.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                cellRange21.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                cellRange21.Style.Border.RightBorder = XLBorderStyleValues.Thin;
                cellRange21.Style.Fill.PatternType = XLFillPatternValues.Solid;
                cellRange21.Style.Fill.BackgroundColor = XLColor.FromHtml("#D9D9D9");
                cellRange21.Style.Font.Bold = true;
                var cellRange22 = worksheet.Range("CT1:CV1");
                cellRange22.Merge();
                cellRange22.Style.Border.TopBorder = XLBorderStyleValues.Thin;
                cellRange22.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                cellRange22.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                cellRange22.Style.Border.RightBorder = XLBorderStyleValues.Thin;
                cellRange22.Style.Fill.PatternType = XLFillPatternValues.Solid;
                cellRange22.Style.Fill.BackgroundColor = XLColor.FromHtml("#D9D9D9");
                cellRange22.Style.Font.Bold = true;
                var cellRange23 = worksheet.Range("CW1:DC1");
                cellRange23.Merge();
                cellRange23.Style.Border.TopBorder = XLBorderStyleValues.Thin;
                cellRange23.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                cellRange23.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                cellRange23.Style.Border.RightBorder = XLBorderStyleValues.Thin;
                cellRange23.Style.Fill.PatternType = XLFillPatternValues.Solid;
                cellRange23.Style.Fill.BackgroundColor = XLColor.FromHtml("#D9D9D9");
                cellRange23.Style.Font.Bold = true;

                worksheet.Range("B1").Value = "Article";
                worksheet.Range("R1").Value = "SAB Seam Section1: Stitches";
                worksheet.Range("X1").Value = "SAB Seam Section2: Stitches";
                worksheet.Range("AD1").Value = "SAB Seam Section3: Stitches";
                worksheet.Range("AJ1").Value = "SAB Seam Section4: Stitches";
                worksheet.Range("AP1").Value = "SAB Seam Section5: Stitches";
                worksheet.Range("AV1").Value = "Steps Backward SAB Seam";
                worksheet.Range("AX1").Value = "Stitches Endlabel Seam";
                worksheet.Range("BB1").Value = "Fabric/Leather 1";
                worksheet.Range("BE1").Value = "Fabric/Leather 2";
                worksheet.Range("BH1").Value = "Fabric/Leather 3";
                worksheet.Range("BK1").Value = "Fabric/Leather 4";
                worksheet.Range("BN1").Value = "Fabric/Leather 5";
                worksheet.Range("BQ1").Value = "Upper Thread";
                worksheet.Range("BU1").Value = "Lower Thread";
                worksheet.Range("BY1").Value = "Thread Tension";
                worksheet.Range("CA1").Value = "Thread Tension Seam1";
                worksheet.Range("CF1").Value = "Thread Tension Seam2 (Endlabel)";
                worksheet.Range("CK1").Value = "Backtack Start Seam1";
                worksheet.Range("CN1").Value = "Backtack End Seam1";
                worksheet.Range("CQ1").Value = "Backtack Start Seam2 (Endlabel)";
                worksheet.Range("CT1").Value = "Backtack End Seam2 (Endlabel)";
                worksheet.Range("CW1").Value = "Miscellaneous";


                worksheet.Range(GetCellAddress(2, 1)).Value = "h_S2";
                worksheet.Range(GetCellAddress(2, 2)).Value = "ArticleCode";
                worksheet.Range(GetCellAddress(2, 2)).Value = "ArticleCode";
                worksheet.Range(GetCellAddress(2, 3)).Value = "ArticleName";
                worksheet.Range(GetCellAddress(2, 4)).Value = "ArticleLabel";
                worksheet.Range(GetCellAddress(2, 5)).Value = "Label Definition";
                worksheet.Range(GetCellAddress(2, 6)).Value = "Endlabel Druckscript";
                worksheet.Range(GetCellAddress(2, 7)).Value = "AutomatName";
                worksheet.Range(GetCellAddress(2, 8)).Value = "Seam Profile";
                worksheet.Range(GetCellAddress(2, 9)).Value = "FreeSeamCountStart";
                worksheet.Range(GetCellAddress(2, 10)).Value = "MaxStitches FreeSeam";
                worksheet.Range(GetCellAddress(2, 11)).Value = "MaxSpeed Crit.Section";
                worksheet.Range(GetCellAddress(2, 12)).Value = "MaxSpeed NotCrit.Section";
                worksheet.Range(GetCellAddress(2, 13)).Value = "Version";
                worksheet.Range(GetCellAddress(2, 14)).Value = "CreateTime";
                worksheet.Range(GetCellAddress(2, 15)).Value = "CreateName";
                worksheet.Range(GetCellAddress(2, 16)).Value = "UpdateTime";
                worksheet.Range(GetCellAddress(2, 17)).Value = "UpdateName";

                worksheet.Range(GetCellAddress(2, 18)).Value = "Reference";
                worksheet.Range(GetCellAddress(2, 19)).Value = "Min";
                worksheet.Range(GetCellAddress(2, 20)).Value = "Max";
                worksheet.Range(GetCellAddress(2, 21)).Value = "Tol.Err.Allowed";
                worksheet.Range(GetCellAddress(2, 22)).Value = "SL";
                worksheet.Range(GetCellAddress(2, 23)).Value = "Steps";

                worksheet.Range(GetCellAddress(2, 24)).Value = "Reference";
                worksheet.Range(GetCellAddress(2, 25)).Value = "Min";
                worksheet.Range(GetCellAddress(2, 26)).Value = "Max";
                worksheet.Range(GetCellAddress(2, 27)).Value = "Tol.Err.Allowed";
                worksheet.Range(GetCellAddress(2, 28)).Value = "SL";
                worksheet.Range(GetCellAddress(2, 29)).Value = "Steps";

                worksheet.Range(GetCellAddress(2, 30)).Value = "Reference";
                worksheet.Range(GetCellAddress(2, 31)).Value = "Min";
                worksheet.Range(GetCellAddress(2, 32)).Value = "Max";
                worksheet.Range(GetCellAddress(2, 33)).Value = "Tol.Err.Allowed";
                worksheet.Range(GetCellAddress(2, 34)).Value = "SL";
                worksheet.Range(GetCellAddress(2, 35)).Value = "Steps";

                worksheet.Range(GetCellAddress(2, 36)).Value = "Reference";
                worksheet.Range(GetCellAddress(2, 37)).Value = "Min";
                worksheet.Range(GetCellAddress(2, 38)).Value = "Max";
                worksheet.Range(GetCellAddress(2, 39)).Value = "Tol.Err.Allowed";
                worksheet.Range(GetCellAddress(2, 40)).Value = "SL";
                worksheet.Range(GetCellAddress(2, 41)).Value = "Steps";

                worksheet.Range(GetCellAddress(2, 42)).Value = "Reference";
                worksheet.Range(GetCellAddress(2, 43)).Value = "Min";
                worksheet.Range(GetCellAddress(2, 44)).Value = "Max";
                worksheet.Range(GetCellAddress(2, 45)).Value = "Tol.Err.Allowed";
                worksheet.Range(GetCellAddress(2, 46)).Value = "SL";
                worksheet.Range(GetCellAddress(2, 47)).Value = "Steps";

                worksheet.Range(GetCellAddress(2, 48)).Value = "Seam Start";
                worksheet.Range(GetCellAddress(2, 49)).Value = "Seam End";

                worksheet.Range(GetCellAddress(2, 50)).Value = "MaxStiche";//MaxStiche => Stitches Endlabel Seam			
                worksheet.Range(GetCellAddress(2, 51)).Value = "SL";//SL
                worksheet.Range(GetCellAddress(2, 52)).Value = "Steps";//Steps
                worksheet.Range(GetCellAddress(2, 53)).Value = "Steps Back";//Steps Back

                worksheet.Range(GetCellAddress(2, 54)).Value = "Batch";
                worksheet.Range(GetCellAddress(2, 55)).Value = "Material Code";
                worksheet.Range(GetCellAddress(2, 56)).Value = "Material Name";

                worksheet.Range(GetCellAddress(2, 57)).Value = "Batch";
                worksheet.Range(GetCellAddress(2, 58)).Value = "Material Code";
                worksheet.Range(GetCellAddress(2, 59)).Value = "Material Name";

                worksheet.Range(GetCellAddress(2, 60)).Value = "Batch";
                worksheet.Range(GetCellAddress(2, 61)).Value = "Material Code";
                worksheet.Range(GetCellAddress(2, 62)).Value = "Material Name";

                worksheet.Range(GetCellAddress(2, 63)).Value = "Batch";
                worksheet.Range(GetCellAddress(2, 64)).Value = "Material Code";
                worksheet.Range(GetCellAddress(2, 65)).Value = "Material Name";

                worksheet.Range(GetCellAddress(2, 66)).Value = "Batch";
                worksheet.Range(GetCellAddress(2, 67)).Value = "Material Code";
                worksheet.Range(GetCellAddress(2, 68)).Value = "Material Name";

                worksheet.Range(GetCellAddress(2, 69)).Value = "Material Code";
                worksheet.Range(GetCellAddress(2, 70)).Value = "Material Name";
                worksheet.Range(GetCellAddress(2, 71)).Value = "Info1";
                worksheet.Range(GetCellAddress(2, 72)).Value = "Info2";

                worksheet.Range(GetCellAddress(2, 73)).Value = "Material Code";
                worksheet.Range(GetCellAddress(2, 74)).Value = "Material Name";
                worksheet.Range(GetCellAddress(2, 75)).Value = "Info1";
                worksheet.Range(GetCellAddress(2, 76)).Value = "Info2";

                worksheet.Range(GetCellAddress(2, 77)).Value = "Monitoring Type";
                worksheet.Range(GetCellAddress(2, 78)).Value = "ID";

                worksheet.Range(GetCellAddress(2, 79)).Value = "Reference";
                worksheet.Range(GetCellAddress(2, 80)).Value = "Min";
                worksheet.Range(GetCellAddress(2, 81)).Value = "Max";
                worksheet.Range(GetCellAddress(2, 82)).Value = "StopFilter";
                worksheet.Range(GetCellAddress(2, 83)).Value = "Start Monitoring";

                worksheet.Range(GetCellAddress(2, 84)).Value = "Reference";
                worksheet.Range(GetCellAddress(2, 85)).Value = "Min";
                worksheet.Range(GetCellAddress(2, 86)).Value = "Max";
                worksheet.Range(GetCellAddress(2, 87)).Value = "StopFilter";
                worksheet.Range(GetCellAddress(2, 88)).Value = "Start Monitoring";

                worksheet.Range(GetCellAddress(2, 89)).Value = "Forward";
                worksheet.Range(GetCellAddress(2, 90)).Value = "Backward";
                worksheet.Range(GetCellAddress(2, 91)).Value = "Repetition";

                worksheet.Range(GetCellAddress(2, 92)).Value = "Forward";
                worksheet.Range(GetCellAddress(2, 93)).Value = "Backward";
                worksheet.Range(GetCellAddress(2, 94)).Value = "Repetition";

                worksheet.Range(GetCellAddress(2, 95)).Value = "Forward";
                worksheet.Range(GetCellAddress(2, 96)).Value = "Backward";
                worksheet.Range(GetCellAddress(2, 97)).Value = "Repetition";

                worksheet.Range(GetCellAddress(2, 98)).Value = "Forward";
                worksheet.Range(GetCellAddress(2, 99)).Value = "Backward";
                worksheet.Range(GetCellAddress(2, 100)).Value = "Repetition";

                worksheet.Range(GetCellAddress(2, 101)).Value = "Info1";
                worksheet.Range(GetCellAddress(2, 102)).Value = "Info2";
                worksheet.Range(GetCellAddress(2, 103)).Value = "Info3";
                worksheet.Range(GetCellAddress(2, 104)).Value = "Info4";
                worksheet.Range(GetCellAddress(2, 105)).Value = "Info5";
                worksheet.Range(GetCellAddress(2, 106)).Value = "Info6";
                worksheet.Range(GetCellAddress(2, 107)).Value = "Info7";

                var cellRange26 = worksheet.Range("B2:DC2");
                cellRange26.Style.Border.TopBorder = XLBorderStyleValues.Thin;
                cellRange26.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                cellRange26.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                cellRange26.Style.Border.RightBorder = XLBorderStyleValues.Thin;
                cellRange26.Style.Fill.PatternType = XLFillPatternValues.Solid;
                cellRange26.Style.Fill.BackgroundColor = XLColor.FromHtml("#D9D9D9");


                int row = 3;
                foreach (var dataItem in updatedArticles)
                {

                    worksheet.Range(GetCellAddress(row, 1)).Value = "r";
                    worksheet.Range(GetCellAddress(row, 2)).Value = dataItem.Code;
                    worksheet.Range(GetCellAddress(row, 3)).Value = dataItem.Name;
                    worksheet.Range(GetCellAddress(row, 4)).Value = dataItem.Label;
                    worksheet.Range(GetCellAddress(row, 5)).Value = dataItem.LabelDefinition;
                    worksheet.Range(GetCellAddress(row, 6)).Value = dataItem.Endlabel;
                    worksheet.Range(GetCellAddress(row, 7)).Value = dataItem.Automat.Name;
                    worksheet.Range(GetCellAddress(row, 8)).Value = dataItem.SeamProfile;
                    worksheet.Range(GetCellAddress(row, 9)).Value = dataItem.FreeSeamCountStart;
                    worksheet.Range(GetCellAddress(row, 10)).Value = dataItem.MaxStitchesFreeSeam;
                    worksheet.Range(GetCellAddress(row, 11)).Value = dataItem.MaxSpeedCritSection;
                    worksheet.Range(GetCellAddress(row, 12)).Value = dataItem.MaxSpeedNotCritSection;
                    worksheet.Range(GetCellAddress(row, 13)).Value = dataItem.Version;
                    worksheet.Range(GetCellAddress(row, 14)).Value = dataItem.CreatedOn.ToString("yyyy-MM-dd HH:mm:ss");
                    worksheet.Range(GetCellAddress(row, 15)).Value = dataItem.CreatedBy;
                    worksheet.Range(GetCellAddress(row, 16)).Value = dataItem.UpdatedOn.ToString("yyyy-MM-dd HH:mm:ss");
                    worksheet.Range(GetCellAddress(row, 17)).Value = dataItem.UpdatedBy;

                    worksheet.Range(GetCellAddress(row, 18)).Value = dataItem.Section1Reference;
                    worksheet.Range(GetCellAddress(row, 19)).Value = dataItem.Section1Min;
                    worksheet.Range(GetCellAddress(row, 20)).Value = dataItem.Section1Max;
                    worksheet.Range(GetCellAddress(row, 21)).Value = dataItem.Section1TolErrAllowed;
                    worksheet.Range(GetCellAddress(row, 22)).Value = dataItem.Section1SL;
                    worksheet.Range(GetCellAddress(row, 23)).Value = dataItem.Section1Steps;

                    worksheet.Range(GetCellAddress(row, 24)).Value = dataItem.Section2Reference;
                    worksheet.Range(GetCellAddress(row, 25)).Value = dataItem.Section2Min;
                    worksheet.Range(GetCellAddress(row, 26)).Value = dataItem.Section2Max;
                    worksheet.Range(GetCellAddress(row, 27)).Value = dataItem.Section2TolErrAllowed;
                    worksheet.Range(GetCellAddress(row, 28)).Value = dataItem.Section2SL;
                    worksheet.Range(GetCellAddress(row, 29)).Value = dataItem.Section2Steps;

                    worksheet.Range(GetCellAddress(row, 30)).Value = dataItem.Section3Reference;
                    worksheet.Range(GetCellAddress(row, 31)).Value = dataItem.Section3Min;
                    worksheet.Range(GetCellAddress(row, 32)).Value = dataItem.Section3Max;
                    worksheet.Range(GetCellAddress(row, 33)).Value = dataItem.Section3TolErrAllowed;
                    worksheet.Range(GetCellAddress(row, 34)).Value = dataItem.Section3SL;
                    worksheet.Range(GetCellAddress(row, 35)).Value = dataItem.Section3Steps;

                    worksheet.Range(GetCellAddress(row, 36)).Value = dataItem.Section4Reference;
                    worksheet.Range(GetCellAddress(row, 37)).Value = dataItem.Section4Min;
                    worksheet.Range(GetCellAddress(row, 38)).Value = dataItem.Section4Max;
                    worksheet.Range(GetCellAddress(row, 39)).Value = dataItem.Section4TolErrAllowed;
                    worksheet.Range(GetCellAddress(row, 40)).Value = dataItem.Section4SL;
                    worksheet.Range(GetCellAddress(row, 41)).Value = dataItem.Section4Steps;


                    worksheet.Range(GetCellAddress(row, 42)).Value = dataItem.Section5Reference;
                    worksheet.Range(GetCellAddress(row, 43)).Value = dataItem.Section5Min;
                    worksheet.Range(GetCellAddress(row, 44)).Value = dataItem.Section5Max;
                    worksheet.Range(GetCellAddress(row, 45)).Value = dataItem.Section5TolErrAllowed;
                    worksheet.Range(GetCellAddress(row, 46)).Value = dataItem.Section5SL;
                    worksheet.Range(GetCellAddress(row, 47)).Value = dataItem.Section5Steps;

                    worksheet.Range(GetCellAddress(row, 48)).Value = dataItem.SeamStart;
                    worksheet.Range(GetCellAddress(row, 49)).Value = dataItem.SeamEnd;

                    worksheet.Range(GetCellAddress(row, 50)).Value = "";//MaxStiche => Stitches Endlabel Seam			
                    worksheet.Range(GetCellAddress(row, 51)).Value = "";//SL
                    worksheet.Range(GetCellAddress(row, 52)).Value = "";//Steps
                    worksheet.Range(GetCellAddress(row, 53)).Value = "";//Steps Back

                    worksheet.Range(GetCellAddress(row, 54)).Value = dataItem.FabricLeather1Batch;
                    worksheet.Range(GetCellAddress(row, 55)).Value = dataItem.FabricLeather1MaterialCode;
                    worksheet.Range(GetCellAddress(row, 56)).Value = dataItem.FabricLeather1MaterialName;

                    worksheet.Range(GetCellAddress(row, 57)).Value = dataItem.FabricLeather2Batch;
                    worksheet.Range(GetCellAddress(row, 58)).Value = dataItem.FabricLeather2MaterialCode;
                    worksheet.Range(GetCellAddress(row, 59)).Value = dataItem.FabricLeather2MaterialName;

                    worksheet.Range(GetCellAddress(row, 60)).Value = dataItem.FabricLeather3Batch;
                    worksheet.Range(GetCellAddress(row, 61)).Value = dataItem.FabricLeather3MaterialCode;
                    worksheet.Range(GetCellAddress(row, 62)).Value = dataItem.FabricLeather3MaterialName;

                    worksheet.Range(GetCellAddress(row, 63)).Value = dataItem.FabricLeather4Batch;
                    worksheet.Range(GetCellAddress(row, 64)).Value = dataItem.FabricLeather4MaterialCode;
                    worksheet.Range(GetCellAddress(row, 65)).Value = dataItem.FabricLeather4MaterialName;

                    worksheet.Range(GetCellAddress(row, 66)).Value = dataItem.FabricLeather5Batch;
                    worksheet.Range(GetCellAddress(row, 67)).Value = dataItem.FabricLeather5MaterialCode;
                    worksheet.Range(GetCellAddress(row, 68)).Value = dataItem.FabricLeather5MaterialName;

                    worksheet.Range(GetCellAddress(row, 69)).Value = dataItem.UpperThreadMaterialCode;
                    worksheet.Range(GetCellAddress(row, 70)).Value = dataItem.UpperThreadMaterialName;
                    worksheet.Range(GetCellAddress(row, 71)).Value = dataItem.UpperThreadInfo1;
                    worksheet.Range(GetCellAddress(row, 72)).Value = dataItem.UpperThreadInfo2;

                    worksheet.Range(GetCellAddress(row, 73)).Value = dataItem.LowerThreadMaterialCode;
                    worksheet.Range(GetCellAddress(row, 74)).Value = dataItem.LowerThreadMaterialName;
                    worksheet.Range(GetCellAddress(row, 75)).Value = dataItem.LowerThreadInfo1;
                    worksheet.Range(GetCellAddress(row, 76)).Value = dataItem.LowerThreadInfo2;

                    worksheet.Range(GetCellAddress(row, 77)).Value = dataItem.ThreadTensionMonitoringType;
                    worksheet.Range(GetCellAddress(row, 78)).Value = dataItem.ThreadTensionId;

                    worksheet.Range(GetCellAddress(row, 79)).Value = dataItem.ThreadTensionSeam1Reference;
                    worksheet.Range(GetCellAddress(row, 80)).Value = dataItem.ThreadTensionSeam1Min;
                    worksheet.Range(GetCellAddress(row, 81)).Value = dataItem.ThreadTensionSeam1Max;
                    worksheet.Range(GetCellAddress(row, 82)).Value = dataItem.ThreadTensionSeam1StopFilter;
                    worksheet.Range(GetCellAddress(row, 83)).Value = dataItem.ThreadTensionSeam1StartMonitoring;

                    worksheet.Range(GetCellAddress(row, 84)).Value = dataItem.ThreadTensionSeam2Reference;
                    worksheet.Range(GetCellAddress(row, 85)).Value = dataItem.ThreadTensionSeam2Min;
                    worksheet.Range(GetCellAddress(row, 86)).Value = dataItem.ThreadTensionSeam2Max;
                    worksheet.Range(GetCellAddress(row, 87)).Value = dataItem.ThreadTensionSeam2StopFilter;
                    worksheet.Range(GetCellAddress(row, 88)).Value = dataItem.ThreadTensionSeam2StartMonitoring;

                    worksheet.Range(GetCellAddress(row, 89)).Value = dataItem.BacktackStartSeam1Forward;
                    worksheet.Range(GetCellAddress(row, 90)).Value = dataItem.BacktackStartSeam1Backward;
                    worksheet.Range(GetCellAddress(row, 91)).Value = dataItem.BacktackStartSeam1Repetition;

                    worksheet.Range(GetCellAddress(row, 92)).Value = dataItem.BacktackEndSeam1Forward;
                    worksheet.Range(GetCellAddress(row, 93)).Value = dataItem.BacktackEndSeam1Backward;
                    worksheet.Range(GetCellAddress(row, 94)).Value = dataItem.BacktackEndSeam1Repetition;

                    worksheet.Range(GetCellAddress(row, 95)).Value = dataItem.BacktackStartSeam2Forward;
                    worksheet.Range(GetCellAddress(row, 96)).Value = dataItem.BacktackStartSeam2Backward;
                    worksheet.Range(GetCellAddress(row, 97)).Value = dataItem.BacktackStartSeam2Repetition;

                    worksheet.Range(GetCellAddress(row, 98)).Value = dataItem.BacktackEndSeam2Forward;
                    worksheet.Range(GetCellAddress(row, 99)).Value = dataItem.BacktackEndSeam2Backward;
                    worksheet.Range(GetCellAddress(row, 100)).Value = dataItem.BacktackEndSeam2Repetition;

                    worksheet.Range(GetCellAddress(row, 101)).Value = dataItem.MiscellaneousInfo1;
                    worksheet.Range(GetCellAddress(row, 102)).Value = dataItem.MiscellaneousInfo2;
                    worksheet.Range(GetCellAddress(row, 103)).Value = dataItem.MiscellaneousInfo3;
                    worksheet.Range(GetCellAddress(row, 104)).Value = dataItem.MiscellaneousInfo4;
                    worksheet.Range(GetCellAddress(row, 105)).Value = dataItem.MiscellaneousInfo5;
                    worksheet.Range(GetCellAddress(row, 106)).Value = dataItem.MiscellaneousInfo6;
                    worksheet.Range(GetCellAddress(row, 107)).Value = dataItem.MiscellaneousInfo7;

                    row++;

                }
                var cellRange27 = worksheet.Range("A1:A" + (row - 1));
                cellRange27.Style.Border.TopBorder = XLBorderStyleValues.Thin;
                cellRange27.Style.Border.BottomBorder = XLBorderStyleValues.Thin;
                cellRange27.Style.Border.LeftBorder = XLBorderStyleValues.Thin;
                cellRange27.Style.Border.RightBorder = XLBorderStyleValues.Thin;
                cellRange27.Style.Fill.PatternType = XLFillPatternValues.Solid;
                cellRange27.Style.Fill.BackgroundColor = XLColor.FromHtml("#D9D9D9");
                cellRange27.Style.Font.FontColor = XLColor.FromHtml("#C00000");

                for (int i = 1; i < 100; i++)
                {
                    worksheet.Column(i).AdjustToContents();
                }

                workbook.SaveAs(filePath);
            }
        }

        public List<ArticleDto> ImportBulkArticles(List<ArticleDto> updatedArticles, List<AutomatDto> automatDtos, IEnumerable<ThreadDto> _dataThread, IEnumerable<PartDto> _dataPart, string filePath)
        {
            List<ArticleDto> articles = new List<ArticleDto>();
            using (var workbook = new XLWorkbook(filePath))
            {

                if (workbook != null)
                {
                    // You can now access the worksheets in the workbook and manipulate the data
                    IXLWorksheet worksheet = workbook.Worksheets.FirstOrDefault(); // Get the first worksheet, for example

                    if (worksheet != null)
                    {
                        int rowCount = worksheet.LastCellUsed().Address.RowNumber;
                        for (int row = 3; row <= rowCount; row++)
                        {
                            ArticleDto dataItem = updatedArticles.FirstOrDefault(dataItem => dataItem.Code == worksheet.Cell(GetCellAddress(row, 2)).Value.ToString());
                            if (dataItem == null)
                            {
                                dataItem = new ArticleDto() { CreatedOn = DateTime.Now, UpdatedOn = DateTime.Now, IsActive = true, IsCreated = true };
                                AutomatDto automatDto = automatDtos.FirstOrDefault(dataItem => dataItem.Name == worksheet.Cell(GetCellAddress(row, 7)).Value.ToString());
                                if (automatDto == null)
                                {
                                    Console.WriteLine("Cannot find Automat");
                                    continue;
                                }
                                dataItem.Automat = automatDto;

                            }
                            else
                            {
                                continue;
                            }
                            dataItem.Code = worksheet.Cell(GetCellAddress(row, 2)).Value.ToString();
                            dataItem.Name = worksheet.Cell(GetCellAddress(row, 3)).Value.ToString();
                            dataItem.Label = worksheet.Cell(GetCellAddress(row, 4)).Value.ToString();
                            dataItem.LabelDefinition = worksheet.Cell(GetCellAddress(row, 5)).Value.ToString();
                            dataItem.Endlabel = worksheet.Cell(GetCellAddress(row, 6)).Value.ToString();
                            dataItem.SeamProfile = worksheet.Cell(GetCellAddress(row, 8)).Value.ToString();
                            dataItem.FreeSeamCountStart = worksheet.Cell(GetCellAddress(row, 9)).Value.ToString();
                            dataItem.MaxStitchesFreeSeam = worksheet.Cell(GetCellAddress(row, 10)).Value.ToString();
                            dataItem.MaxSpeedCritSection = worksheet.Cell(GetCellAddress(row, 11)).Value.ToString();
                            dataItem.MaxSpeedNotCritSection = worksheet.Cell(GetCellAddress(row, 12)).Value.ToString();
                            dataItem.Version = worksheet.Cell(GetCellAddress(row, 13)).Value.ToString();
                            dataItem.CreatedOn = DateTime.Parse(worksheet.Cell(GetCellAddress(row, 14)).Value.ToString());
                            dataItem.CreatedBy = worksheet.Cell(GetCellAddress(row, 15)).Value.ToString();
                            dataItem.UpdatedOn = DateTime.Parse(worksheet.Cell(GetCellAddress(row, 16)).Value.ToString());
                            dataItem.UpdatedBy = worksheet.Cell(GetCellAddress(row, 17)).Value.ToString();

                            dataItem.Section1Reference = worksheet.Cell(GetCellAddress(row, 18)).Value.ToString();
                            dataItem.Section1Min = worksheet.Cell(GetCellAddress(row, 19)).Value.ToString();
                            dataItem.Section1Max = worksheet.Cell(GetCellAddress(row, 20)).Value.ToString();
                            dataItem.Section1TolErrAllowed = worksheet.Cell(GetCellAddress(row, 21)).Value.ToString() != null ? worksheet.Cell(GetCellAddress(row, 21)).Value.ToString().Equals("True") : false;
                            dataItem.Section1SL = worksheet.Cell(GetCellAddress(row, 22)).Value.ToString();
                            dataItem.Section1Steps = worksheet.Cell(GetCellAddress(row, 23)).Value.ToString();

                            dataItem.Section2Reference = worksheet.Cell(GetCellAddress(row, 24)).Value.ToString();
                            dataItem.Section2Min = worksheet.Cell(GetCellAddress(row, 25)).Value.ToString();
                            dataItem.Section2Max = worksheet.Cell(GetCellAddress(row, 26)).Value.ToString();
                            dataItem.Section2TolErrAllowed = worksheet.Cell(GetCellAddress(row, 27)).Value.ToString() != null ? worksheet.Cell(GetCellAddress(row, 27)).Value.ToString().Equals("True") : false;
                            dataItem.Section2SL = worksheet.Cell(GetCellAddress(row, 28)).Value.ToString();
                            dataItem.Section2Steps = worksheet.Cell(GetCellAddress(row, 29)).Value.ToString();

                            dataItem.Section3Reference = worksheet.Cell(GetCellAddress(row, 30)).Value.ToString();
                            dataItem.Section3Min = worksheet.Cell(GetCellAddress(row, 31)).Value.ToString();
                            dataItem.Section3Max = worksheet.Cell(GetCellAddress(row, 32)).Value.ToString();
                            dataItem.Section3TolErrAllowed = worksheet.Cell(GetCellAddress(row, 33)).Value.ToString() != null ? worksheet.Cell(GetCellAddress(row, 33)).Value.ToString().Equals("True") : false;
                            dataItem.Section3SL = worksheet.Cell(GetCellAddress(row, 34)).Value.ToString();
                            dataItem.Section3Steps = worksheet.Cell(GetCellAddress(row, 35)).Value.ToString();

                            dataItem.Section4Reference = worksheet.Cell(GetCellAddress(row, 36)).Value.ToString();
                            dataItem.Section4Min = worksheet.Cell(GetCellAddress(row, 37)).Value.ToString();
                            dataItem.Section4Max = worksheet.Cell(GetCellAddress(row, 38)).Value.ToString();
                            dataItem.Section4TolErrAllowed = worksheet.Cell(GetCellAddress(row, 39)).Value.ToString() != null ? worksheet.Cell(GetCellAddress(row, 39)).Value.ToString().Equals("True") : false;
                            dataItem.Section4SL = worksheet.Cell(GetCellAddress(row, 40)).Value.ToString();
                            dataItem.Section4Steps = worksheet.Cell(GetCellAddress(row, 41)).Value.ToString();


                            dataItem.Section5Reference = worksheet.Cell(GetCellAddress(row, 42)).Value.ToString();
                            dataItem.Section5Min = worksheet.Cell(GetCellAddress(row, 43)).Value.ToString();
                            dataItem.Section5Max = worksheet.Cell(GetCellAddress(row, 44)).Value.ToString();
                            dataItem.Section5TolErrAllowed = worksheet.Cell(GetCellAddress(row, 45)).Value.ToString() != null ? worksheet.Cell(GetCellAddress(row, 45)).Value.ToString().Equals("True") : false;
                            dataItem.Section5SL = worksheet.Cell(GetCellAddress(row, 46)).Value.ToString();
                            dataItem.Section5Steps = worksheet.Cell(GetCellAddress(row, 47)).Value.ToString();

                            dataItem.SeamStart = worksheet.Cell(GetCellAddress(row, 48)).Value.ToString();
                            dataItem.SeamEnd = worksheet.Cell(GetCellAddress(row, 49)).Value.ToString();

                            //=worksheet.Cell( GetCellAddress(row, 50)).Value.ToString() = "";//MaxStiche => Stitches Endlabel Seam			
                            //=worksheet.Cell( GetCellAddress(row, 51)).Value.ToString() = "";//SL
                            //=worksheet.Cell( GetCellAddress(row, 52)).Value.ToString() = "";//Steps
                            //=worksheet.Cell( GetCellAddress(row, 53)).Value.ToString() = "";//Steps Back

                            if (worksheet.Cell(GetCellAddress(row, 55)).Value.ToString() != null)
                            {
                                PartDto partDto = _dataPart.FirstOrDefault(dp => dp.Code == worksheet.Cell(GetCellAddress(row, 55)).Value.ToString());
                                if (partDto != null)
                                {
                                    dataItem.FabricLeather1ID = partDto.ID;
                                    dataItem.FabricLeather1Batch = worksheet.Cell(GetCellAddress(row, 54)).Value.ToString();
                                    dataItem.FabricLeather1MaterialCode = worksheet.Cell(GetCellAddress(row, 55)).Value.ToString();
                                    dataItem.FabricLeather1MaterialName = worksheet.Cell(GetCellAddress(row, 56)).Value.ToString();
                                }

                            }


                            if (worksheet.Cell(GetCellAddress(row, 58)).Value.ToString() != null)
                            {
                                PartDto partDto = _dataPart.FirstOrDefault(dp => dp.Code == worksheet.Cell(GetCellAddress(row, 58)).Value.ToString());
                                if (partDto != null)
                                {
                                    dataItem.FabricLeather2ID = partDto.ID;
                                    dataItem.FabricLeather2Batch = worksheet.Cell(GetCellAddress(row, 57)).Value.ToString();
                                    dataItem.FabricLeather2MaterialCode = worksheet.Cell(GetCellAddress(row, 58)).Value.ToString();
                                    dataItem.FabricLeather2MaterialName = worksheet.Cell(GetCellAddress(row, 59)).Value.ToString();
                                }

                            }

                            if (worksheet.Cell(GetCellAddress(row, 61)).Value.ToString() != null)
                            {
                                PartDto partDto = _dataPart.FirstOrDefault(dp => dp.Code == worksheet.Cell(GetCellAddress(row, 61)).Value.ToString());
                                if (partDto != null)
                                {
                                    dataItem.FabricLeather3ID = partDto.ID;
                                    dataItem.FabricLeather3Batch = worksheet.Cell(GetCellAddress(row, 60)).Value.ToString();
                                    dataItem.FabricLeather3MaterialCode = worksheet.Cell(GetCellAddress(row, 61)).Value.ToString();
                                    dataItem.FabricLeather3MaterialName = worksheet.Cell(GetCellAddress(row, 62)).Value.ToString();
                                }

                            }


                            if (worksheet.Cell(GetCellAddress(row, 64)).Value.ToString() != null)
                            {
                                PartDto partDto = _dataPart.FirstOrDefault(dp => dp.Code == worksheet.Cell(GetCellAddress(row, 64)).Value.ToString());
                                if (partDto != null)
                                {
                                    dataItem.FabricLeather4ID = partDto.ID;
                                    dataItem.FabricLeather4Batch = worksheet.Cell(GetCellAddress(row, 63)).Value.ToString();
                                    dataItem.FabricLeather4MaterialCode = worksheet.Cell(GetCellAddress(row, 64)).Value.ToString();
                                    dataItem.FabricLeather4MaterialName = worksheet.Cell(GetCellAddress(row, 65)).Value.ToString();
                                }

                            }



                            if (worksheet.Cell(GetCellAddress(row, 67)).Value.ToString() != null)
                            {
                                PartDto partDto = _dataPart.FirstOrDefault(dp => dp.Code == worksheet.Cell(GetCellAddress(row, 67)).Value.ToString());
                                if (partDto != null)
                                {
                                    dataItem.FabricLeather5ID = partDto.ID;
                                    dataItem.FabricLeather5Batch = worksheet.Cell(GetCellAddress(row, 66)).Value.ToString();
                                    dataItem.FabricLeather5MaterialCode = worksheet.Cell(GetCellAddress(row, 67)).Value.ToString();
                                    dataItem.FabricLeather5MaterialName = worksheet.Cell(GetCellAddress(row, 68)).Value.ToString();
                                }

                            }


                            if (worksheet.Cell(GetCellAddress(row, 69)).Value.ToString() != null)
                            {
                                ThreadDto threadDto = _dataThread.FirstOrDefault(th => th.Code == worksheet.Cell(GetCellAddress(row, 69)).Value.ToString());
                                if (threadDto != null)
                                {
                                    dataItem.UpperThreadID = threadDto.ID;
                                    dataItem.UpperThreadMaterialCode = worksheet.Cell(GetCellAddress(row, 69)).Value.ToString();
                                    dataItem.UpperThreadMaterialName = worksheet.Cell(GetCellAddress(row, 70)).Value.ToString();
                                    dataItem.UpperThreadInfo1 = worksheet.Cell(GetCellAddress(row, 71)).Value.ToString();
                                    dataItem.UpperThreadInfo2 = worksheet.Cell(GetCellAddress(row, 72)).Value.ToString();
                                }

                            }

                            if (worksheet.Cell(GetCellAddress(row, 73)).Value.ToString() != null)
                            {
                                ThreadDto threadDto = _dataThread.FirstOrDefault(th => th.Code == worksheet.Cell(GetCellAddress(row, 73)).Value.ToString());
                                if (threadDto != null)
                                {

                                    dataItem.LowerThreadID = threadDto.ID;
                                    dataItem.LowerThreadMaterialCode = worksheet.Cell(GetCellAddress(row, 73)).Value.ToString();
                                    dataItem.LowerThreadMaterialName = worksheet.Cell(GetCellAddress(row, 74)).Value.ToString();
                                    dataItem.LowerThreadInfo1 = worksheet.Cell(GetCellAddress(row, 75)).Value.ToString();
                                    dataItem.LowerThreadInfo2 = worksheet.Cell(GetCellAddress(row, 76)).Value.ToString();
                                }

                            }

                            dataItem.ThreadTensionMonitoringType = worksheet.Cell(GetCellAddress(row, 77)).Value.ToString();
                            dataItem.ThreadTensionId = worksheet.Cell(GetCellAddress(row, 78)).Value.ToString();

                            dataItem.ThreadTensionSeam1Reference = worksheet.Cell(GetCellAddress(row, 79)).Value.ToString();
                            dataItem.ThreadTensionSeam1Min = worksheet.Cell(GetCellAddress(row, 80)).Value.ToString();
                            dataItem.ThreadTensionSeam1Max = worksheet.Cell(GetCellAddress(row, 81)).Value.ToString();
                            dataItem.ThreadTensionSeam1StopFilter = worksheet.Cell(GetCellAddress(row, 82)).Value.ToString();
                            dataItem.ThreadTensionSeam1StartMonitoring = worksheet.Cell(GetCellAddress(row, 83)).Value.ToString();

                            dataItem.ThreadTensionSeam2Reference = worksheet.Cell(GetCellAddress(row, 84)).Value.ToString();
                            dataItem.ThreadTensionSeam2Min = worksheet.Cell(GetCellAddress(row, 85)).Value.ToString();
                            dataItem.ThreadTensionSeam2Max = worksheet.Cell(GetCellAddress(row, 86)).Value.ToString();
                            dataItem.ThreadTensionSeam2StopFilter = worksheet.Cell(GetCellAddress(row, 87)).Value.ToString();
                            dataItem.ThreadTensionSeam2StartMonitoring = worksheet.Cell(GetCellAddress(row, 88)).Value.ToString();

                            dataItem.BacktackStartSeam1Forward = worksheet.Cell(GetCellAddress(row, 89)).Value.ToString();
                            dataItem.BacktackStartSeam1Backward = worksheet.Cell(GetCellAddress(row, 90)).Value.ToString();
                            dataItem.BacktackStartSeam1Repetition = worksheet.Cell(GetCellAddress(row, 91)).Value.ToString();

                            dataItem.BacktackEndSeam1Forward = worksheet.Cell(GetCellAddress(row, 92)).Value.ToString();
                            dataItem.BacktackEndSeam1Backward = worksheet.Cell(GetCellAddress(row, 93)).Value.ToString();
                            dataItem.BacktackEndSeam1Repetition = worksheet.Cell(GetCellAddress(row, 94)).Value.ToString();

                            dataItem.BacktackStartSeam2Forward = worksheet.Cell(GetCellAddress(row, 95)).Value.ToString();
                            dataItem.BacktackStartSeam2Backward = worksheet.Cell(GetCellAddress(row, 96)).Value.ToString();
                            dataItem.BacktackStartSeam2Repetition = worksheet.Cell(GetCellAddress(row, 97)).Value.ToString();

                            dataItem.BacktackEndSeam2Forward = worksheet.Cell(GetCellAddress(row, 98)).Value.ToString();
                            dataItem.BacktackEndSeam2Backward = worksheet.Cell(GetCellAddress(row, 99)).Value.ToString();
                            dataItem.BacktackEndSeam2Repetition = worksheet.Cell(GetCellAddress(row, 100)).Value.ToString();

                            dataItem.MiscellaneousInfo1 = worksheet.Cell(GetCellAddress(row, 101)).Value.ToString();
                            dataItem.MiscellaneousInfo2 = worksheet.Cell(GetCellAddress(row, 102)).Value.ToString();
                            dataItem.MiscellaneousInfo3 = worksheet.Cell(GetCellAddress(row, 103)).Value.ToString();
                            dataItem.MiscellaneousInfo4 = worksheet.Cell(GetCellAddress(row, 104)).Value.ToString();
                            dataItem.MiscellaneousInfo5 = worksheet.Cell(GetCellAddress(row, 105)).Value.ToString();
                            dataItem.MiscellaneousInfo6 = worksheet.Cell(GetCellAddress(row, 106)).Value.ToString();
                            dataItem.MiscellaneousInfo7 = worksheet.Cell(GetCellAddress(row, 107)).Value.ToString();
                            articles.Add(dataItem);
                        }
                        Console.WriteLine();
                        return articles;
                    }
                }
            }
            return articles;
        }
        #endregion
    }
}
