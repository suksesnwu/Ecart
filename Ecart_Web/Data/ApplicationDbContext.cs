using Microsoft.EntityFrameworkCore;
using Ecart_Web.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Ecart_Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Category { get; set; }
        public DbSet<ApplicationType> ApplicationType { get; set; }
        public DbSet<Product> Product { get; set; }
    }
}
