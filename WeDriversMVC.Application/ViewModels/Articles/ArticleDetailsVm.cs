using AutoMapper;
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

        public ListArticleTagForListVm Tags { get; set; }

        public ListArticleCommentForListVm Comments { get; set; }

        public List<ArticleCategory> Categories { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Article, ArticleDetailsVm>()
                  .ForMember(dst => dst.Categories, opt => opt.MapFrom(src => src.Categories))
                  .ForMember(dst => dst.Tags, opt => opt.MapFrom(src => src.Tags))
                  .ForMember(dst => dst.Comments, opt => opt.MapFrom(src => src.Comments));
        }

    }
}
