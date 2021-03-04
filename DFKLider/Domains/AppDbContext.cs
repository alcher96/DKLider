using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DFKLider.Domains.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DFKLider.Domains
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Coach> Coaches { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<UsersRole> UsersRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);

            modelbuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            modelbuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "my@mail.COM",
                NormalizedEmail = "MY@EMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "12"),
                SecurityStamp = string.Empty

            });

            modelbuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                UserId = "3b62472e-4f66-49fa-a20f-e7685b9565d8"
            });

            modelbuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "52f6e600-f7c9-452f-abe3-e72edb8ad59b",
                Name = "coach",
                NormalizedName = "COACH"
            });

            modelbuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "bd3e8d4c-6fbf-4239-837c-f4df8b103956",
                UserName = "coach",
                NormalizedUserName = "COACH",
                Email = "my@mail.COM",
                NormalizedEmail = "MY@EMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "123"),
                SecurityStamp = string.Empty

            });

            modelbuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "52f6e600-f7c9-452f-abe3-e72edb8ad59b",
                UserId = "bd3e8d4c-6fbf-4239-837c-f4df8b103956"
            });

            modelbuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "cdfe0cef-3152-41df-85ed-723ced351244",
                Name = "parent",
                NormalizedName = "PARENT"
            });

            modelbuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "5b500000-1cbe-4d97-a51a-d2babbd70ccd",
                UserName = "parent",
                NormalizedUserName = "PARENT",
                Email = "my@mail.COM",
                NormalizedEmail = "MY@EMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "1234"),
                SecurityStamp = string.Empty

            });

            modelbuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "cdfe0cef-3152-41df-85ed-723ced351244",
                UserId = "5b500000-1cbe-4d97-a51a-d2babbd70ccd"
            });

            modelbuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "88acef40-8047-4752-afd8-af58959b5753",
                Name = "student",
                NormalizedName = "STUDENT"
            });

            modelbuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "716d9ef8-70ab-4be3-ae97-6f08e9b6aadd",
                UserName = "student",
                NormalizedUserName = "STUDENT",
                Email = "my@mail.COM",
                NormalizedEmail = "MY@EMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "1234"),
                SecurityStamp = string.Empty

            });

            modelbuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "88acef40-8047-4752-afd8-af58959b5753",
                UserId = "716d9ef8-70ab-4be3-ae97-6f08e9b6aadd"
            });

            modelbuilder.Entity<Group>().HasData(new Group
            {
                Id = new Guid("1301ea05-f1ab-4cbc-9403-2ba7cbb4cb16"),
                GroupNumber = "2004-1"
            });

            modelbuilder.Entity<Group>().HasData(new Group
            {
                Id = new Guid("ed71cba8-fa3e-471d-a8cb-2e9975d3c9fd"),
                GroupNumber = "2004-2"
            });

            modelbuilder.Entity<Group>().HasData(new Group
            {
                Id = new Guid("1a795c2e-85ce-46ed-b06b-4d456c6ad83e"),
                GroupNumber = "2005-1"
            });

            modelbuilder.Entity<Group>().HasData(new Group
            {
                Id = new Guid("1de18082-46af-44db-b30e-605142e7378f"),
                GroupNumber = "2005-2"
            });
        }
    }
}
