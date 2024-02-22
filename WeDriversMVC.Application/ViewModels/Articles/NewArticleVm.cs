using AutoMapper;
using FluentValidation;
using WeDriversMVC.Application.Mapping;
using WeDriversMVC.Domain.Model;

namespace WeDriversMVC.Application.ViewModels.Articles
{
    public class NewArticleVm : IMapFrom<Article>
    {
        public int Id { get; set; }

        public string Author {  get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<NewArticleVm, Article>().ReverseMap();
        }
    }

    public class NewArticleValidation : AbstractValidator<NewArticleVm>
    {
        public NewArticleValidation()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.Author).NotNull();
            RuleFor(x => x.Title).NotNull().MinimumLength(10).MaximumLength(255);
            RuleFor(x => x.Content).NotNull();

        }
    }
}
