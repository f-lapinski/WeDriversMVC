using WeDriversMVC.Domain.Model;

namespace WeDriversMVC.Application.ViewModels.Articles
{
    public class NewArticleVm
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public List<ArticleTag> Tags { get; set; }
    }
}
