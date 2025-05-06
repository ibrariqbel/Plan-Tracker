using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PlanTracker.Models.DomainModels;

namespace PlanTracker.Models.DomainModels
{
    public class Goal
    {
     public int Id { get; set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
   // public ICollection<TaskItem>? Tasks { get; set; }

     // Relationship: A Goal belongs to a User
    public Guid UserId { get; set; }
    public User User { get; set; }

    // Relationship: Goal has multiple Tasks
   // public ICollection<TaskItem>? Task { get; set; }
    }
}