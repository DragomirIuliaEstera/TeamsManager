using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

// Modelul entity pentru utilizator
namespace TeamsManager.Models
{
    public class UserModel
    {
        [Key]
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Parola { get; set; }
        [Required]
        public string Email { get; set; }
    }

    public class UserDbContext : DbContext
    {
        public DbSet<UserModel> Users { get; set; }
    }
}