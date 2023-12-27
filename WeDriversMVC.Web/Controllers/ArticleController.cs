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
            var articles = _articleService.GetAllArticlesForList(2, 1, "");
            return View(articles);
        }

        [HttpPost]
        public IActionResult Index(int pageSize, int? pageNo, string searchString)
        {
            if (!pageNo.HasValue)
            {
                pageNo = 1;
            }
            if (searchString is null)
            {
                searchString = String.Empty;
            }
            var articles = _articleService.GetAllArticlesForList(pageSize, pageNo.Value, searchString);
            return View(articles);
        }

        public IActionResult ViewArticle(int id)
        {
            int articleId = id;
            var articleModel = _articleService.GetArticleById(articleId);
            return View(articleModel);
        }

        public IActionResult Category(int id)
        {
            int categoryId = id;
            var articleModel = _articleService.GetArticlesByCategoryId(categoryId);
            return View(articleModel);
        }
    }
}
