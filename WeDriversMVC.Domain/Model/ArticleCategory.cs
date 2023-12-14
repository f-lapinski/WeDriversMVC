using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeDriversMVC.Domain.Model
{
    public class ArticleCategory
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int ArticleId { get; set; }

        public ICollection<Article> Articles { get; set; }
    }
}
