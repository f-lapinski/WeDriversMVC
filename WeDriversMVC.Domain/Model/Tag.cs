﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeDriversMVC.Domain.Model
{
    public class Tag
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<ArticleTag> ArticleTags { get; set; }
    }
}