using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PlanTracker.Services;
using PlanTracker.Data;
using PlanTracker.Interfaces;


namespace PlanTracker.Controllers
{
  
    public class AdminController : Controller
    {
        private readonly SqlDbContext dbContext;    // encapsulated feilds
        private readonly ITokenService tokenService;
       

        public AdminController(ITokenService tokenService, SqlDbContext dbContext)
        {
            this.tokenService = tokenService;
            this.dbContext = dbContext;
           
        }
      

        [HttpGet]
        public IActionResult Dashboard()
        {
            var token = Request.Cookies["GradSchoolAuthorizationToken"];

            if (string.IsNullOrEmpty(token))
            {
                return RedirectToAction("login", "user");
            }


            //var userId = TokenService.VerifyTockenAndGetId(token);

            // if (userId == null)
            // {
            //     return RedirectToAction("login", "user");
            // }



            return View();
        }
        public IActionResult Index()
        {
            return View();
        }

        
    }
}