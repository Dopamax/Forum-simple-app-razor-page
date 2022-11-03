using Forum_dotnet.Models;
using Microsoft.EntityFrameworkCore;
namespace Forum_dotnet.Data
{
    public class DbForum : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Comment> Comments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Database = db_forum; Integrated Security = True");
        } 
    }
}
