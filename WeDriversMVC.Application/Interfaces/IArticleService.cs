using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeDriversMVC.Application.ViewModels.Articles;

namespace WeDriversMVC.Application.Interfaces
{
    public interface IArticleService
    {
        ListArticleForListVm GetAllArticlesForList(int pageSize, int pageNo, string searchString);

        int NewArticle(NewArticleVm article);

        ArticleDetailsVm GetArticleById(int articleId);

        ListArticleForListVm GetArticlesByCategoryId(int categoryId);
    }
}
