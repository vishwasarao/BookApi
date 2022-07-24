using BulkyBookApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBookApi.Db
{
    public class ApplicationDbContext : DbContext
    {

        //Correct spelling later :(
        public DbSet<Category> Catogories { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }


    }
}
