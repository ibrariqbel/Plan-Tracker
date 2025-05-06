using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlanTracker.Models.DomainModels
{
    public class  User
    {
    [Key]
    public  Guid UserId {get;set;} = Guid.NewGuid();
    public required string  Username {get ;set;}
    public required string  Email {get ;set;}
    public required string  Password {get ;set;}
   // public string?  ProfilePicUrl {get ;set;}
    public string? Phone {get; set ; }

    public ICollection<Goal>? Goals { get; set; } = new List<Goal> ();  
   
    }
}