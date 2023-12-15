using WeDriversMVC.Domain.Model;

namespace WeDriversMVC.Infrastructure.Repositories
{
    public interface IArticleCommentRepository
    {
        int CreateArticleComment(ArticleComment articleComment);

        int DeleteArticleComment(int articleCommentId);

        IEnumerable<ArticleComment> GetAllArticleComments();
    }
}