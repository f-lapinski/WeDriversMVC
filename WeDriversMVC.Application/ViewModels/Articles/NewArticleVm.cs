using AutoMapper;
using WeDriversMVC.Application.Mapping;
using WeDriversMVC.Domain.Model;

namespace WeDriversMVC.Application.ViewModels.Articles
{
    public class NewArticleVm : IMapFrom<Article>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<NewArticleVm, Article>();
        }
    }
}
