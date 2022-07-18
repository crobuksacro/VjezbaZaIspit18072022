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
            string roleId = "7d7ec828-22ee-4fb3-a381-20dc59fcff5e";
            string userId = "b15772df-590d-412f-baf3-e0a4805c13e0";



            for (int i = 1; i <= 5; i++)
            {
                builder.Entity<Author>().HasData(new Author
                {
                    Id = i,
                    FirstName = "Autor " + i,
                    LastName = "Autor " + i,
                    Created = DateTime.Now

                });


                if (i <= 3)
                {


                    builder.Entity<Publisher>().HasData(new Publisher
                    {
                        Id = i,
                        Name = "Publisher " + i,
                        Created = DateTime.Now

                    });
                }

            }




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
                SecurityStamp = "d9635ef5-e580-4a00-8fe1-9d35d0cef6d3",
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