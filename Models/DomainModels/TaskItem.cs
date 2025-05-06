// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using PlanTracker.Types;

// namespace PlanTracker.Models.DomainModels
// {
//     public class TaskItem
//     {
//     public int Id { get; set; }
//     public required string Title { get; set; }
//     public required string Description { get; set; }
//     public  DateTime DueDate { get; set; } 
//     public bool IsCompleted { get; set; }
//     public PriorityLevel Priority { get; set; }
//     public Recurrence Recurrence { get; set; }


//      // Relationship: A Task belongs to a Goal  
//     public int GoalId { get; set; }
//     public Goal? Goal { get; set; }
//     }
// }