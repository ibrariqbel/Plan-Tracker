using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PlanTracker.Interfaces;
using PlanTracker.Models.DomainModels;

namespace PlanTracker.Controllers
{
   
    public class GoalController : Controller
    {
      
        private readonly IGoalService _goalService;
        public GoalController(IGoalService goalService)
        {
            _goalService = goalService;
        }

         [HttpGet("Goal/Index")]
        public IActionResult Index()
        {
           List<Goal> goals = _goalService.GetGoals();
           return View(goals);
        }

        public IActionResult Details(int id)
        {
            var goal = _goalService.GetGoalById(id);
            return View(goal);
        }

          // GET: EmployeeController1/Create
         [HttpGet("Goal/Create")]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Goal goal)
        {
            try
            {
                _goalService.AddGoal(goal);
                return RedirectToAction(nameof(Index));
            }
            catch 
            {
                
                return View();
            }
        }
        // GET: EmployeeController1/Edit/5
        public ActionResult Edit(int id)
        {
            var goal = _goalService.GetGoalById(id);
            return View(goal);
        }
         [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id,Goal goal)
        {
            try
            {
                _goalService.UpdateGoal(goal);
                return RedirectToAction(nameof(Index));

            }
            catch 
            {
                
               return View();
            }
        }

            [HttpGet("Goal/Delete")]
          public ActionResult Delete(int id)
          {
             var goal = _goalService.GetGoalById(id);
            return View(goal);
          }
           [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Goal goal)
        {
            try
            {
                _goalService.DeleteGoal(id);
                return RedirectToAction(nameof(Index));
            }
            catch (System.Exception)
            {
                
                return View();
            }
        }
       
    }
}