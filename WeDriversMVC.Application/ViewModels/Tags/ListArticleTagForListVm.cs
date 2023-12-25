using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeDriversMVC.Application.ViewModels.Articles;

namespace WeDriversMVC.Application.ViewModels.Tags
{
    public class ListArticleTagForListVm
    {
        public List<ArticleTagForListVm> Tags { get; set; }

        public int Count { get; set; }
    }
}
