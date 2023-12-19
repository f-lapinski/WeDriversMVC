using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeDriversMVC.Application.ViewModels.Comment
{
    public class ArticleCommentForListVm
    {
        public int Id { get; set; }

        public string Author { get; set; }

        public string Content { get; set; }
    }
}
