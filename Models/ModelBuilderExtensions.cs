using Microsoft.EntityFrameworkCore;

namespace testProject2.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 3,
                    Name = "Elon Musk",
                    Department = Dept.Application_Developer,
                    Email = "elon.musk@gmail.com"
                },
                new Employee
                {
                    Id = 4,
                    Name = "Jeff Bezos",
                    Department = Dept.Application_Developer,
                    Email = "bezos.jeff@gmail.com"
                }
            );
        }
    }
}