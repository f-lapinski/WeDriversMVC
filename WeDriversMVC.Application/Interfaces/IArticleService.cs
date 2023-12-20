using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeDriversMVC.Application.ViewModels.Article;

namespace WeDriversMVC.Application.Interfaces
{
    public interface IArticleService
    {
        ListArticleForListVm GetAllArticlesForList();

        int NewArticle(NewArticleVm article);

        ArticleDetailsVm GetArticleDetails(int articleId);
    }
}
