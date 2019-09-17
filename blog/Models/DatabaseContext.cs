using Microsoft.EntityFrameworkCore;
using blog.Models;

namespace blog.Models{
    public class DatabaseContext : DbContext{
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options){

        }
        public DbSet<myBlog> myBlogs {get; set;}
        public DbSet<Comments> comments { get; set; }

        public DbSet<BlogCategory> blogCategories { get; set; }
    }
    
}