using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeDriversMVC.Domain.Model;

namespace WeDriversMVC.Application.ViewModels.Article
{
    public class ArticleForListVm
    {
        public string Title { get; set; }

        public DateTime CreatedAt { get; set; }

        public string ContentPreview { get; set; }

        public string Author { get; set; }
    }
}
