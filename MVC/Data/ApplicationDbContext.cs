using Microsoft.EntityFrameworkCore;
using MVC.Models;

namespace MVC.Data{
    public class ApplicationDbContext : DbContext{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}
        public DbSet<Person> Person { get; set; } 
        public DbSet<Student> Student { get; set; }
        public DbSet<Employee> Employee { get; set; }
        

        
    }
}