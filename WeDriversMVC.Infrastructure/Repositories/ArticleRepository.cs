using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeDriversMVC.Domain.Interface;
using WeDriversMVC.Domain.Model;

namespace WeDriversMVC.Infrastructure.Repositories
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly Context _context;
        public ArticleRepository(Context context)
        {
            _context = context;
        }

        public int CreateArticle(Article article)
        {
            _context.Articles.Add(article);
            _context.SaveChanges();
            return article.Id;
        }
        public int DeleteArticle(int articleId)
        {
            var article = _context.Articles.FirstOrDefault(a => a.Id == articleId);
            if (article != null)
            {
                _context.Articles.Remove(article);
                _context.SaveChanges();
            }
            return articleId;
        }

        public Article GetArticleById(int articleId)
        {
            var article = _context.Articles.FirstOrDefault(a => a.Id == articleId);
            return article;
        }

        public IQueryable<Article> GetArticlesByCategoryId(int categoryId)
        {
            var articles = _context.Articles.Where(a => a.CategoryId == categoryId);
            return articles;
        }
        public IEnumerable<Article> GetAllArticles()
        {
            var articles = _context.Articles;
            return articles;
        }

        public IQueryable<ArticleComment> GetAllCommentsByArticleId(int articleId)
        {
            var comments = _context.ArticleComments.Where(a => a.ArticleId == articleId);
            return comments;
        }

        public IQueryable<Tag> AllTags()
        {
            var tags = _context.Tags;
            return tags;
        }

        public IQueryable<ArticleCategory> AllCategories()
        {
            var categories = _context.ArticleCategories;
            return categories;
        }
    }
}
