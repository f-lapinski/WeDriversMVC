using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public ArticleDetailsVm GetArticleDetails(int articleId)
        {
            var article = _articleRepository.GetArticleById(articleId);
            var articleVm = _mapper.Map<ArticleDetailsVm>(article);

            articleVm.Comments = new List<ListArticleCommentForListVm>();

            return articleVm;
        }
    }
}
