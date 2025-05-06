// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.EntityFrameworkCore;
// using PlanTracker.Data;
// using PlanTracker.Interfaces;
// using PlanTracker.Models.DomainModels;

// namespace PlanTracker.Services
// {
//     public class TaskItemServices : ITaskItemServices
//     {
//         private readonly SqlDbContext _context;

//         public TaskItemServices( SqlDbContext context)
//         {
//             _context = context;
//         }

//         public void AddTask(TaskItem taskItem)
//         {
//            _context.TaskItems.Add(taskItem);
//            _context.SaveChanges();
//         }

//         public void DeleteTask(int id)
//         {
//            var task = _context.TaskItems.Find(id);
//            _context.SaveChanges();
           
//         }

//         public TaskItem TaskGetById(int id)
//         {
//            return _context.TaskItems.Include(t => t.Goal).FirstOrDefault();
         
//         }

//         public List<TaskItem> taskItems()
//         {
//             return _context.TaskItems.Include(t => t.Goal).ToList();
//         }

//         public void UpdateTask(TaskItem taskItem)
//         {
//            _context.TaskItems.Update(taskItem);
//            _context.SaveChanges();
//         }
//     }
// }