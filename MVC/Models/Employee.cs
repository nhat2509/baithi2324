using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MVC.Models
{
    [Table("Employee ")]
    public class Employee : Person
    {

        public string? EmployeeName { get; set; }
        public string? Address { get; set; }


    }
}