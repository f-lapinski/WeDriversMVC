using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeDriversMVC.Domain.Model;

namespace WeDriversMVC.Domain.Interface
{
    public interface IArticleTagRepository
    {
        int CreateArticleTag(ArticleTag tag);

        int DeleteArticleTag(int tagId);

        IEnumerable<ArticleTag> GetAllArticleTags();

    }
}
