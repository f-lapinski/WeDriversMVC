using System.Collections.Immutable;
using System.Reflection;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using WeDriversMVC.Application.Interfaces;
using WeDriversMVC.Application.Services;
using WeDriversMVC.Application.ViewModels.Articles;

namespace WeDriversMVC.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddTransient<IArticleService, ArticleService>();
        services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        return services;
    }

    public static IServiceCollection AddValidation(this IServiceCollection services)
    {
        services.AddTransient<IValidator<NewArticleVm>, NewArticleValidation>();
        return services;
    }
}