using Microsoft.EntityFrameworkCore;

namespace AppDITI5MAF.Models
{
    public class ArticleDB : DbContext
    {
        public ArticleDB(DbContextOptions<ArticleDB> options) : base(options)
        {

        }

        public DbSet<Articles> Articles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=MAF-K75;Initial Catalog=DITI5DB;Integrated Security=True;Pooling=False");
        }
    }
}
