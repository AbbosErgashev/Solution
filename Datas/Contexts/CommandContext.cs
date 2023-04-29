using Microsoft.EntityFrameworkCore;
using Solution.Models;

namespace Solution.Datas.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public DbSet<Command> Commands { get; set; }

        public DbSet<User> Users { get; set; }
    }
}

