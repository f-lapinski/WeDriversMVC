using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeDriversMVC.Domain.Model;

namespace WeDriversMVC.Domain.Interface
{
    public interface IArticleCategoryRepository
    {
        int CreateArticleCategory(ArticleCategory articleCategory);

        int DeleteArticleCategory(int categoryId);

        IEnumerable<ArticleCategory> GetAllArticleCategories();
    }
}
