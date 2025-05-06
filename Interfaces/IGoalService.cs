using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PlanTracker.Models.DomainModels;

namespace PlanTracker.Interfaces
{
    public interface IGoalService
    {
        List<Goal> GetGoals ();
        Goal GetGoalById(int id);
        void AddGoal(Goal goal);
        void UpdateGoal(Goal goal);
        void DeleteGoal(int id); 

    }
}