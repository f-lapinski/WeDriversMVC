using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeDriversMVC.Domain.Model
{
    public class Article
    {
        public int Id { get; set; }

        public bool isPublished { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public ICollection<ArticleCategory> Categories { get; set; }

        public ICollection<ArticleComment> Comments { get; set; }

        public ICollection<ArticleTag> Tags { get; set; }
    }
}
