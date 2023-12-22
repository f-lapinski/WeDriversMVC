using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeDriversMVC.Application.ViewModels.Articles;

namespace WeDriversMVC.Application.ViewModels.Comments
{
    public class ListArticleCommentForListVm
    {
        public List<ArticleCommentForListVm> Comments { get; set; }

        public int Count { get; set; }
    }
}
