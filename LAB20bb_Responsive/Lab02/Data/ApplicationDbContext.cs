using System;
using System.Collections.Generic;
using System.Text;
using Lab02.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Lab02.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<JoinApplication> JoinApplications { get; set; }

        public DbSet<Illustration> Illustrations { get; set; }


        public DbSet<ApplicationUser> MApplicationUsers { get; set; }

        public DbSet<Review> Reviews { get; set; }

    }
}
