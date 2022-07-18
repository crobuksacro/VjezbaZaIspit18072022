﻿using Microsoft.AspNetCore.Identity;
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
            //string roleId = Guid.NewGuid().ToString();
            //string userId = Guid.NewGuid().ToString();

            string roleId = "d6b5b0da-e61e-46ba-b766-e1acc7401352";
            string userId = "badd4ddd-df0e-4621-af37-c2b36aaa6742";


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
                //SecurityStamp = Guid.NewGuid().ToString("D"),
                SecurityStamp = "c8c5cc23-1703-4984-8ac7-4b178d2d9982",
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