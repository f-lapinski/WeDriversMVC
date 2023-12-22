using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeDriversMVC.Application.ViewModels.Comments;
using WeDriversMVC.Application.ViewModels.Tags;
using WeDriversMVC.Domain.Model;

namespace WeDriversMVC.Application.ViewModels.Articles
{
    public class ArticleDetailsVm
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public List<ListArticleTagForListVm> Tags { get; set; }

        public List<ListArticleCommentForListVm> Comments { get; set; }
    }
}
