using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;


namespace Student.Models
{
    public class Student
    { 
        public int Id { get; set; }
        [Display(Name = "First Name")]
        public string Firstname { get; set; }
        [Display(Name = "Last Name")]
        public string Lastname { get; set; }
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }
        [Display(Name = "GPA")]
        public Decimal GPA { get; set; }
    }
    public class StudentContext : DbContext
    { 
        public StudentContext(string connString) : base(connString)
        {

        }

        public DbSet<Student> Students { get; set; }        
    }
    
}