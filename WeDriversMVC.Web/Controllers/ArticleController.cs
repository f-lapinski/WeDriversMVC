using Microsoft.AspNetCore.Mvc;

namespace WeDriversMVC.Web.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewArticle(int articleId)
        {
            var articleModel = _articleService.GetArticleById(articleId);
            return View(articleModel);
        }
    }
}
