using AutoMapper;
using WeDriversMVC.Application.Mapping;
using WeDriversMVC.Domain.Model;

namespace WeDriversMVC.Application.ViewModels.Articles
{
    public class ArticleForListVm : IMapFrom<Article>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime CreatedAt { get; set; }

        public string Author { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Article, ArticleForListVm>();
        }
    }
}
