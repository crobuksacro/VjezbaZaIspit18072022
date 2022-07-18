using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VjezbaZaIspit.Models.Dbo;

namespace VjezbaZaIspit.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            string role = "admin";
            string userName = "admin@admin.com";
            string roleId = Guid.NewGuid().ToString();
            string userId = Guid.NewGuid().ToString();


            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = role,
                NormalizedName = "ADMIN",
                Id = roleId
            });
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = userId,
                UserName = userName,
                Email = userName,
                NormalizedUserName = userName.ToUpper(),
                NormalizedEmail = userName.ToUpper(),
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Password12345"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                FirstName = "Ivan",
                LastName = "Radoš"

            });


            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = roleId,
                UserId = userId
            });

        }


        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<Publisher> Publisher { get; set; }

    }
}