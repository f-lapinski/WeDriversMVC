using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeDriversMVC.Domain.Interface;
using WeDriversMVC.Domain.Model;

namespace WeDriversMVC.Infrastructure.Repositories
{
    public class ArticleTagRepository : IArticleTagRepository
    {
        private readonly Context _context;

        public ArticleTagRepository(Context context)
        {
            context = _context;
        }

        public int CreateArticleTag(ArticleTag tag)
        {
            _context.ArticleTags.Add(tag);
            _context.SaveChanges();
            return tag.Id;
        }

        public int DeleteArticleTag(int tagId)
        {
            var tag = _context.ArticleTags.FirstOrDefault(t => t.Id == tagId);
            if (tag != null)
            {
                _context.ArticleTags.Remove(tag);
                _context.SaveChanges();
            }
            return tagId;
        }

        public IEnumerable<ArticleTag> GetAllArticleTags()
        {
            var tags = _context.ArticleTags;
            return tags;
        }
    }
}
