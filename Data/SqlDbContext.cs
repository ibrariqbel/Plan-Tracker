using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PlanTracker.Models.DomainModels;

namespace PlanTracker.Data
{
    public class SqlDbContext : DbContext
    {
         public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options) { }

         public DbSet<User> Users {get; set;}
         public DbSet<Goal> Goals {get; set;}
        // public DbSet<TaskItem> TaskItems {get;set;}
        public IEnumerable<object> Tasks { get; internal set; }


//         protected override void OnModelCreating(ModelBuilder modelBuilder)
// {
//     // User to Goal (One-to-Many)
//     modelBuilder.Entity<User>()
//         .HasMany(u => u.Goals)
//         .WithOne(g => g.User)
//         .HasForeignKey(g => g.UserId)
//         .OnDelete(DeleteBehavior.Cascade);

//     // Goal to TaskItem (One-to-Many)
//     modelBuilder.Entity<Goal>()
//         .HasMany(g => g.Tasks)
//         .WithOne(t => t.Goal)
//         .HasForeignKey(t => t.GoalId)
//         .OnDelete(DeleteBehavior.Cascade);
// }

    }


    
}