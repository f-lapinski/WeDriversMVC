using AutoMapper;
using WeDriversMVC.Application.Mapping;
using WeDriversMVC.Application.ViewModels.Articles;
using WeDriversMVC.Domain.Model;

namespace WeDriversMVC.Application.ViewModels.Comments
{
    public class ArticleCommentForListVm : IMapFrom<ArticleComment>
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public string Author { get; set; }

        public string Content { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<ArticleComment, ArticleCommentForListVm>();
        }
    }
}
