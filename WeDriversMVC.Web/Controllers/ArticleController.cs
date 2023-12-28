using Microsoft.AspNetCore.Mvc;
using WeDriversMVC.Application.Interfaces;
using WeDriversMVC.Application.Services;
using WeDriversMVC.Application.ViewModels.Articles;

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

        [Route("Article/ViewArticle/{articleId}")]
        public IActionResult ViewArticle(int articleId)
        {
            var articleModel = _articleService.GetArticleById(articleId);
            return View(articleModel);
        }

        [Route("Article/Category/{categoryId}")]
        public IActionResult Category(int categoryId)
        {
            var articleModel = _articleService.GetArticlesByCategoryId(categoryId);
            return View(articleModel);
        }

        [HttpGet]
        public IActionResult AddNewArticle()
        {
            return View(new NewArticleVm());
        }

        [HttpPost]
        public IActionResult AddNewArticle(NewArticleVm model)
        {
            var id = _articleService.NewArticle(model);
            return RedirectToAction("Index");
        }
    }
}
