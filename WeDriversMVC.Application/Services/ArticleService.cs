using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Http;
using WeDriversMVC.Application.Interfaces;
using WeDriversMVC.Application.ViewModels.Articles;
using WeDriversMVC.Application.ViewModels.Comments;
using WeDriversMVC.Domain.Interface;
using WeDriversMVC.Domain.Model;
using System.Web;
using Microsoft.AspNetCore.Identity;

namespace WeDriversMVC.Application.Services
{
    public class ArticleService : IArticleService
    {
        private readonly IArticleRepository _articleRepository;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _contextAccessor;

        public ArticleService(IArticleRepository articleRepository, IMapper mapper)
        {
            _articleRepository = articleRepository;
            _mapper = mapper;
        }
        public ListArticleForListVm GetAllArticlesForList(int pageSize, int pageNo, string searchString)
        {
            var articles = _articleRepository.GetAllPublishedArticles().Where(a => a.Title.Contains(searchString))
                .ProjectTo<ArticleForListVm>(_mapper.ConfigurationProvider).ToList();
            var articlesToShow = articles.Skip(pageSize * (pageNo - 1)).Take(pageSize).ToList();
            var articleList = new ListArticleForListVm()
            {
                Articles = articlesToShow,
                CurrentPage = pageNo,
                PageSize = pageSize,
                SearchString = searchString,
                Count = articles.Count
            };

            return articleList;
        }

        public int NewArticle(NewArticleVm article)
        {
            var art = _mapper.Map<Article>(article);
            art.isPublished = true;
            var id = _articleRepository.CreateArticle(art);
            return id;
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

        public NewArticleVm GetArticleForEdit(int articleId)
        {
            var article = _articleRepository.GetArticleById(articleId);
            var articleVm = _mapper.Map<NewArticleVm>(article);
            return articleVm;
        }

        public void UpdateArticle(NewArticleVm model)
        {
            var article = _mapper.Map<Article>(model);
            _articleRepository.UpdateArticle(article);
        }

        public void DeleteArticle(ArticleDetailsVm model)
        {
            var article = _mapper.Map<Article>(model);
            _articleRepository.DeleteArticle(article.Id);
        }

    }
}
