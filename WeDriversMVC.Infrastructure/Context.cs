using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using WeDriversMVC.Domain.Model;

namespace WeDriversMVC.Infrastructure
{
    public class Context : IdentityDbContext
    {
        public DbSet<Article> Articles { get; set; }

        public DbSet<ArticleCategory> ArticleCategories { get; set; }

        public DbSet<ArticleComment> ArticleComments { get; set; }

        public DbSet<ArticleTag> ArticleTag { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public Context(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Article>()
                .HasOne(e => e.Category)
                .WithOne(e => e.Article)
                .HasForeignKey<ArticleCategory>(e => e.ArticleId);

            builder.Entity<Article>()
                .HasMany(e => e.Comments)
                .WithOne(e => e.Article)
                .HasForeignKey(e => e.ArticleId);

            builder.Entity<ArticleTag>()
                .HasKey(it => new { it.ArticleId, it.TagId });

            builder.Entity<ArticleTag>()
                .HasOne<Article>(it => it.Article)
                .WithMany(i => i.ArticleTags)
                .HasForeignKey(it => it.ArticleId);

            builder.Entity<ArticleTag>()
                .HasOne<Article>(it => it.Article)
                .WithMany(i => i.ArticleTags)
                .HasForeignKey(it => it.TagId);

        }
    }
}
