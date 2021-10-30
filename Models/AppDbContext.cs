using Microsoft.EntityFrameworkCore;

namespace testProject2.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }
        
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
            // modelBuilder.Entity<Employee>().HasData(
            //     new Employee
            //     {
            //         Id = 3,
            //         Name = "Elon Musk",
            //         Department = Dept.Application_Developer,
            //         Email = "elon.musk@gmail.com"
            //     },
            //     new Employee
            //     {
            //         Id = 4,
            //         Name = "Jeff Bezos",
            //         Department = Dept.Application_Developer,
            //         Email = "bezos.jeff@gmail.com"
            //     }
            // );
        }
    }
}