﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeDriversMVC.Domain.Model;

namespace WeDriversMVC.Domain.Interface
{
    public interface IArticleRepository
    {
        int CreateArticle(Article article);

        int DeleteArticle(int articleId);

        Article GetArticleById(int articleId);

        IQueryable<Article> GetArticlesByCategoryId(int categoryId);

        IEnumerable<Article> GetAllArticles();

        IQueryable<ArticleComment> GetAllCommentsByArticleId(int articleId);

        IQueryable<Tag> AllTags();

        IQueryable<ArticleCategory> AllCategories();
    }
}

