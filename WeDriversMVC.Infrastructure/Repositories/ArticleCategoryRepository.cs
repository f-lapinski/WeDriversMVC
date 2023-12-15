using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeDriversMVC.Domain.Interface;
using WeDriversMVC.Domain.Model;

namespace WeDriversMVC.Infrastructure.Repositories
{
    public class ArticleCategoryRepository : IArticleCategoryRepository
    {
        private readonly Context _context;

        public ArticleCategoryRepository(Context context)
        {
            context = _context;
        }

        public int CreateArticleCategory(ArticleCategory articleCategory)
        {
            _context.Add(articleCategory);
            return articleCategory.Id;
        }

        public int DeleteArticleCategory(int categoryId)
        {
            var category = _context.ArticleCategories.FirstOrDefault(c => c.Id == categoryId);
            if (category != null)
            {
                _context.ArticleCategories.Remove(category);
                _context.SaveChanges();
            }
            return category.Id;
        }

        public IEnumerable<ArticleCategory> GetAllArticleCategories()
        {
            var categories = _context.ArticleCategories;
            return categories;
        }
    }
}
