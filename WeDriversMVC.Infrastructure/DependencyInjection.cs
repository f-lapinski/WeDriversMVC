using Microsoft.Extensions.DependencyInjection;
using WeDriversMVC.Domain.Interface;
using WeDriversMVC.Infrastructure.Repositories;

namespace WeDriversMVC.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddTransient<IArticleRepository, ArticleRepository>();
        services.AddTransient<IArticleCategoryRepository, ArticleCategoryRepository>();
        services.AddTransient<IArticleCommentRepository, ArticleCommentRepository>();
        services.AddTransient<IArticleTagRepository, ArticleTagRepository>();
        return services;
    }
}