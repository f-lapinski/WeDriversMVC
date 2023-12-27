using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeDriversMVC.Application.Mapping;
using WeDriversMVC.Domain.Model;

namespace WeDriversMVC.Application.ViewModels.Tags
{
    public class ArticleTagForListVm : IMapFrom<ArticleTag>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
