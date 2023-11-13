using Microsoft.EntityFrameworkCore;

namespace AppDITI5MAF.Models
{
    public class ArticleDB : DbContext
    {
        public ArticleDB(DbContextOptions<ArticleDB> options) : base(options)
        {

        }

        public DbSet<Articles> Articles { get; set; }

    }
}
