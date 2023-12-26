using AutoMapper;
using AutoMapper.QueryableExtensions;
using WeDriversMVC.Application.Interfaces;
using WeDriversMVC.Application.ViewModels.Articles;
using WeDriversMVC.Application.ViewModels.Comments;
using WeDriversMVC.Domain.Interface;

namespace WeDriversMVC.Application.Services
{
    public class ArticleService : IArticleService
    {
        private readonly IArticleRepository _articleRepository;

        private readonly IMapper _mapper;

        public ArticleService(IArticleRepository articleRepository, IMapper mapper)
        {
            _articleRepository = articleRepository;
            _mapper = mapper;
        }
        public ListArticleForListVm GetAllArticlesForList()
        {
            var articles = _articleRepository.GetAllPublishedArticles()
                .ProjectTo<ArticleForListVm>(_mapper.ConfigurationProvider).ToList();
            var articleList = new ListArticleForListVm()
            {
                Articles = articles,
                Count = articles.Count
            };

            return articleList;
        }

        public int NewArticle(NewArticleVm article)
        {
            throw new NotImplementedException();
        }

        public ArticleDetailsVm GetArticleById(int articleId)
        {
            var article = _articleRepository.GetArticleById(articleId);
            var articleVm = _mapper.Map<ArticleDetailsVm>(article);

            //articleVm.Comments = new ListArticleCommentForListVm();

            return articleVm;
        }

        public ListArticleForListVm GetArticlesByCategoryId(int categoryId)
        {
            var articles = _articleRepository.GetArticlesByCategoryId(categoryId)
                .ProjectTo<ArticleForListVm>(_mapper.ConfigurationProvider).ToList();
            var articleList = new ListArticleForListVm()
            {
                Articles = articles,
                Count = articles.Count
            };

            return articleList;
        }
    }
}
