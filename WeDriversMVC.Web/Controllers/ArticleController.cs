using Microsoft.AspNetCore.Mvc;
using WeDriversMVC.Application.Interfaces;
using WeDriversMVC.Application.Services;

namespace WeDriversMVC.Web.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;

        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }
        public IActionResult Index()
        {
            var articles = _articleService.GetAllArticlesForList();
            return View(articles);
        }

        public IActionResult ViewArticle(int articleId)
        {
            var articleModel = _articleService.GetArticleById(articleId);
            return View(articleModel);
        }

        public IActionResult Category(int categoryId)
        {
            var articleModel = _articleService.GetArticlesByCategoryId(categoryId);
            return View(articleModel);
        }
    }
}
