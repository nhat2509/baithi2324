using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MVC.Models
{
    [Table("Person")]
    public class Person{
        [Key]
        public string? PersonId { get; set; }
        public int? SoLuong { get; set; }
        public double? SoDon { get; set; }


    }
}