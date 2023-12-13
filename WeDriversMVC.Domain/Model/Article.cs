﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeDriversMVC.Domain.Model
{
    public class Article
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public ArticleCategory Category { get; set; }

        public ICollection<ArticleComment> Comments { get; set; }

        public ICollection<ArticleTag> ArticleTags { get; set; }
    }
}