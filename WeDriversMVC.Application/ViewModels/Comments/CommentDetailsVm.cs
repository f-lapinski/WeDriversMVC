using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeDriversMVC.Application.Mapping;
using WeDriversMVC.Domain.Model;

namespace WeDriversMVC.Application.ViewModels.Comments
{
    public class CommentDetailsVm : IMapFrom<ArticleComment>
    {
        public int Id { get; set; }

        public string Author { get; set; }

        public string Comment { get; set; }
    }
}
