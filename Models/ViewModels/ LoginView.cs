using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanTracker.Models.ViewModels
{
    public class LoginView
    {
        public required string Email { get; set; }
        public required string Password { get; set; }
    }
}