using System;
using System.ComponentModel.DataAnnotations;

namespace RecordManager.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        public  string MiddleName { get; set; }
         [Required]
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Gender{get;set;}
        public int Salary { get; set; }



    }
}