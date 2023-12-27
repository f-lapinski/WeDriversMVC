using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeDriversMVC.Application.Mapping;
using WeDriversMVC.Application.ViewModels.Comments;
using WeDriversMVC.Domain.Model;

namespace WeDriversMVC.Application.ViewModels.Tags
{
    public class ArticleTagDetailsVm : IMapFrom<ArticleTag>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<ArticleTag, ArticleTagDetailsVm>();
        }
    }
}
