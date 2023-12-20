using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeDriversMVC.Application.Interfaces;
using WeDriversMVC.Application.ViewModels.Article;
using WeDriversMVC.Domain.Interface;

namespace WeDriversMVC.Application.Services
{
    public class ArticleService : IArticleService
    {
        private readonly IArticleRepository _articleRepository;

        public ListArticleForListVm GetAllArticlesForList()
        {
            var articles = _articleRepository.GetAllArticles();
            ListArticleForListVm result = new ListArticleForListVm();
            result.Articles = new List<ArticleForListVm>();
            foreach (var article in articles)
            {
                var articleVm = new ArticleForListVm()
                {
                    Id = article.Id,
                    Title = article.Title,
                    CreatedAt = article.CreatedAt,
                    ContentPreview = article.Content.Substring(0, 100)
                };

                result.Articles.Add(articleVm);
            }
            result.Count = result.Articles.Count;
            return result;
        }

        public int NewArticle(NewArticleVm article)
        {
            throw new NotImplementedException();
        }

        public ArticleDetailsVm GetArticleDetails(int articleId)
        {
            throw new NotImplementedException();
        }
    }
}
