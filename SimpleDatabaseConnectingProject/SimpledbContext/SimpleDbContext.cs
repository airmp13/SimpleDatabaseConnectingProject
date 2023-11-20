using Microsoft.EntityFrameworkCore;
using SimpleDatabaseConnectingProject.Entities;

namespace SimpleDatabaseConnectingProject.SimpledbContext
{
	public class SimpleDbContext : DbContext
	{

        public SimpleDbContext(DbContextOptions<SimpleDbContext> options)
            :base(options)
        {
            
            
        }

        public DbSet<User> Users { get; set; }

    }
}
