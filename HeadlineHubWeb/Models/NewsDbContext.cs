using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HeadlineHubWeb.Models
{
    public class NewsDbContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }   
        public DbSet<Role> Roles { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Category> Categories { get; set; }

        public NewsDbContext(DbContextOptions<NewsDbContext> options)
            : base(options)
        {
            
        }

           }
}
