using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeDriversMVC.Domain.Model;

namespace WeDriversMVC.Application.ViewModels.Articles
{
    public class ListArticleForListVm
    {
        public List<ArticleForListVm> Articles { get; set; }

        public int Count { get; set; }
    }
}
