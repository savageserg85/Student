using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DomainModel;

namespace Services.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<DomainModel.Student> Students { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Nationality> Nationalities { get; set; }
        public DbSet<Specialty> Specialties { get; set; }
    }
}
