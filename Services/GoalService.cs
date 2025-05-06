using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PlanTracker.Data;
using PlanTracker.Interfaces;
using PlanTracker.Models.DomainModels;

namespace PlanTracker.Services
{
    public class GoalService : IGoalService
    {
        static List<Goal> _goal = new List<Goal>();
        static GoalService()
        {
            _goal.Add(new Goal(){ Id=1, Title="Shoping",Description="Go to bazar"});
        }
        public void AddGoal(Goal goal)
        {
           _goal.Add(goal);
        }

        public void DeleteGoal(int id)
        {
            var goal = _goal.First(go => go.Id == id);
            _goal.Remove(goal);
        }

        public Goal GetGoalById(int id)
        {
           var goal = _goal.First(go => go.Id == id);
           return goal;
        }

        public List<Goal> GetGoals()
        {
            return _goal;
        }

        public void UpdateGoal(Goal goal)
        {
            var goals = _goal.First(go => go.Id == goal.Id);
            goals.Title = goal.Title;
            goals.Description = goal.Description;
            goals.StartDate = goal.StartDate;
            goals.EndDate = goal.EndDate;
        }
    }
}