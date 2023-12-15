using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeDriversMVC.Domain.Model;

namespace WeDriversMVC.Infrastructure.Repositories
{
    public class ArticleCommentRepository : IArticleCommentRepository
    {
        private readonly Context _context;

        public ArticleCommentRepository(Context context)
        {
            context = _context;
        }

        public int CreateArticleComment(ArticleComment articleComment)
        {
            _context.ArticleComments.Add(articleComment);
            return articleComment.Id;
        }

        public int DeleteArticleComment(int articleCommentId)
        {
            var comment = _context.ArticleComments.FirstOrDefault(c => c.Id == articleCommentId);
            return comment.Id;
        }

        public IEnumerable<ArticleComment> GetAllArticleComments()
        {
            var comments = _context.ArticleComments;
            return comments;
        }
    }
}
