using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WeDriversMVC.Domain.Model
{
    public class ArticleComment
    {
        public int Id { get; set; }

        public string Author { get; set; }

        public string Content { get; set; }

        public int? ArticleId { get; set; }

        public Article Article { get; set; }
    }
}
