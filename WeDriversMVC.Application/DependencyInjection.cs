using System.Collections.Immutable;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using WeDriversMVC.Application.Interfaces;
using WeDriversMVC.Application.Services;

namespace WeDriversMVC.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddTransient<IArticleService, ArticleService>();
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        return services;
    }
}