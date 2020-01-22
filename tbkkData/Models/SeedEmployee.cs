using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class SeedEmployee
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new tbkkDataContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<tbkkDataContext>>()))
            {
                // Look for any movies.

                if (context.Employee.Any())
                {
                    return;   // DB has been seeded
                }





                context.Employee.AddRange(
                    new Employee
                    {
                        FirstName = "Charlotte",
                        LastName = "Daisy",
                        Address = "London",
                        Telephone = "0632158475",
                        Salary = 16000,
                        Email = "Charlotte@gmail.com",
                        StatusEva = 0,
                        Birthday = DateTime.Parse("2539-3-2"),
                        Status = "Working",
                        Date_of_employment = DateTime.Parse("2562-3-2"),
                        Gender = "male",
                        Employee_CompanyID = 1,
                        Employee_DepartmentID = 1,
                        Employee_EmployeeTypeID = 1,
                        Employee_PositionID = 1


                    }
                    );

                context.Employee.AddRange(
                     new Employee
                     {
                         FirstName = "Chloe",
                         LastName = "Ella",
                         Address = "Gloucester",
                         Telephone = "0621453339",
                         Salary = 15000,
                         Email = "Chloe@hotmail.com",
                         StatusEva = 0,
                         Birthday = DateTime.Parse("2531-3-21"),
                         Status = "Working",
                         Date_of_employment = DateTime.Parse("2561-3-2"),
                         Gender = "female",
                         Employee_CompanyID = 1,
                         Employee_DepartmentID = 2,
                         Employee_EmployeeTypeID = 2,
                         Employee_PositionID = 2
                        
                     }
                     );




                context.SaveChanges();
            }

            
        }
    }
}
