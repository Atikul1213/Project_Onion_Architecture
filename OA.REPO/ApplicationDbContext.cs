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


        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserProfile>().HasKey(u => u.Id);
            modelBuilder.Entity<UserProfile>().Property(u => u.FirstName).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<UserProfile>().Property(u => u.LastName).IsRequired().HasMaxLength(100);


            modelBuilder.Entity<User>().HasKey(u => u.Id);
            modelBuilder.Entity<User>().Property(u => u.Email).IsRequired() ;
            modelBuilder.Entity<User>().Property(u => u.Password).IsRequired();




            modelBuilder.Entity<UserProfile>().HasData(

               new UserProfile { Id = 1, FirstName = "Atikul ", LastName = "Islam", IPAddress = "192.168.3.3", Address = "Dinajpur", AddedDate=DateTime.Now, ModifiedDate=DateTime.Now },
               new UserProfile { Id = 2, FirstName = "Ismail ", LastName = "Haque", IPAddress = "192.168.3.4", Address = "Khanasam", AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
               new UserProfile { Id = 3, FirstName = "Mominul ", LastName = "Islam", IPAddress = "192.168.3.5", Address = "Gazipur" , AddedDate = DateTime.Now, ModifiedDate = DateTime.Now },
               new UserProfile { Id = 4, FirstName = "Alamin", LastName = " Haque", IPAddress = "192.168.3.7", Address = " Dhaka", AddedDate = DateTime.Now, ModifiedDate = DateTime.Now }
               );



            modelBuilder.Entity<User>().HasMany(u=>u.UserProfile)
           .WithOne(x=>x.User)
           .HasForeignKey(u =>u.UserId);

        }

    }
    
}
