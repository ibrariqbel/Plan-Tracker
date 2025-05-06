using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PlanTracker.Data;
using PlanTracker.Interfaces;
using PlanTracker.Models.DomainModels;

namespace PlanTracker.Services
{
    public class SqlGoalServices : IGoalService
    {
        private readonly SqlDbContext _sqlDbContext;

        public SqlGoalServices(SqlDbContext sqlDbContext)
        {
            _sqlDbContext = sqlDbContext;
        }

        public void AddGoal(Goal goal)
        {
             _sqlDbContext.Add(goal);
             _sqlDbContext.SaveChanges();
        }

        public void DeleteGoal(int id)
        {
            var goal = _sqlDbContext.Goals.First(go => go.Id == id);
            _sqlDbContext.Remove(goal);
            _sqlDbContext.SaveChanges();
        }

        public Goal GetGoalById(int id)
        {
            var goal = _sqlDbContext.Goals.First(go => go.Id == id);
           return goal;
        }

        public List<Goal> GetGoals()
        {
           return _sqlDbContext.Goals.ToList();
        }

        public void UpdateGoal(Goal goal)
        {
             var goals = _sqlDbContext.Goals.First(go => go.Id == goal.Id);
            goals.Title = goal.Title;
            goals.Description = goal.Description;
            goals.StartDate = goal.StartDate;
            goals.EndDate = goal.EndDate;

            _sqlDbContext.Goals.Update(goal);
            _sqlDbContext.SaveChanges();
        }
    }
}