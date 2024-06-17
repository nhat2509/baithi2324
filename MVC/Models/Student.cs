using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MVC.Models
{
    [Table("Student")]
    public class Student : Person
    {

        public string? StudentName { get; set; }
        public string? Address { get; set; }


    }
}