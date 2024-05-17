using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OA.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace OA.REPO
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserProfile>().HasKey(u => u.Id);
            modelBuilder.Entity<UserProfile>().Property(u => u.FirstName).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<UserProfile>().Property(u => u.LastName).IsRequired().HasMaxLength(100);


            modelBuilder.Entity<User>().HasKey(u => u.Id);
            modelBuilder.Entity<User>().Property(u => u.Email).IsRequired() ;
            modelBuilder.Entity<User>().Property(u => u.Password).IsRequired();


           modelBuilder.Entity<User>().HasOne(u => u.UserProfile)
           .WithOne(u => u.User)
           .HasForeignKey<UserProfile>(u =>u.Id);

        }

    }
    
}
