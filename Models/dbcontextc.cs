using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Insurance.Models
{


    public class User
    {

  
         public int Id { get; set; }
         public int username { get; set; }

         public string password{get;set;}


         
         public string Roll{get;set;}="user";

         public ICollection<HistoryInsurance> HistoryInsurance { get; set; }
    }



    public class  HistoryInsurance
    { 
        public int Id { get; set; }
       public string Name{get;set;}

        public double Percent{get;set;}


        public double Insurancecalculation{get;set;}

        
        public int UserId{get; set;}
        public User User {get; set;}

    }






    public class InsuranceContext : DbContext
{

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer("Server=.\\SQLSERVER2022;Database=INSURANCE;Trusted_Connection=true;TrustServerCertificate=true;Integrated Security=true;");
    }
    public DbSet<User> Users { get; set; }
    public DbSet<HistoryInsurance> HistoryInsurances { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // configures one-to-many relationship
        modelBuilder.Entity<HistoryInsurance>()
            .HasOne<User>(s => s.User)
            .WithMany(U => U.HistoryInsurance)
            .HasForeignKey(u => u.UserId)
            .OnDelete(DeleteBehavior.Cascade);         
    }
}

}



