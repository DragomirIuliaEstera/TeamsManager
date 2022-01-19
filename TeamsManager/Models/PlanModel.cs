using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using Languages;
namespace TeamsManager.Models
{
    public class PlanModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int IdUser { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "Plan", ResourceType = typeof(Resource))]
        public string PlanName { get; set; }
        [Display(Name = "Description", ResourceType = typeof(Resource))]
        public string Description { get; set; }
        [Display(Name = "Deadline", ResourceType = typeof(Resource))]
        public DateTime Deadline { get; set; }
        [Display(Name = "Status", ResourceType = typeof(Resource))]
        public string Status { get; set; }// to do/ pending/ blocked/ done
    }

    public class PlanDbContext : UserDbContext
    {
        public DbSet<PlanModel> Plans { get; set; }
    }
}