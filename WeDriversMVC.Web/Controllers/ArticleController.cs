using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SQLitePCL;
using WeDriversMVC.Application.Interfaces;
using WeDriversMVC.Application.Services;
using WeDriversMVC.Application.ViewModels.Articles;
using WeDriversMVC.Web.Filters;

namespace WeDriversMVC.Web.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;

        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        [CheckPermissons("Read")]
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

        public IActionResult Details(int id)
        {
            var articleModel = _articleService.GetArticleById(id);
            return View(articleModel);
        }

        [Route("Article/Category/{categoryId}")]
        public IActionResult Category(int categoryId)
        {
            var articleModel = _articleService.GetArticlesByCategoryId(categoryId);
            return View(articleModel);
        }

        [Authorize]
        [HttpGet]
        public IActionResult Create()
        {
            return View(new NewArticleVm());
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(NewArticleVm model)
        {
            model.Author = HttpContext.User.Identity.Name;
            var id = _articleService.NewArticle(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var article = _articleService.GetArticleForEdit(id);
            return View(article);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(NewArticleVm model)
        {
            if (ModelState.IsValid)
            {
                _articleService.UpdateArticle(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var article = _articleService.GetArticleById(id);
            return View(article);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(ArticleDetailsVm model)
        {
            _articleService.DeleteArticle(model);
            return RedirectToAction("Index");
        }
    }
}
