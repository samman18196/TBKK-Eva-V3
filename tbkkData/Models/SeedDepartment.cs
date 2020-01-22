using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class SeedDepartment
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new tbkkDataContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<tbkkDataContext>>()))
            {
                // Look for any movies.

                if (context.Department.Any())
                {
                    return;   // DB has been seeded
                }

               




                context.Department.AddRange(
                new Department
                {
                    DepartmentName = "Information Technology",
                    Image = "null",
                    Status = "open"
                }
                );
                context.Department.AddRange(
                new Department
                {
                    DepartmentName = "Production Department",
                    Image = "null",
                    Status = "open"
                }
                );
                context.Department.AddRange(
                    new Department
                    {
                        DepartmentName = "Sales Department",
                        Image = "null",
                        Status = "open"
                    }
                    );
                context.Department.AddRange(
                    new Department
                    {
                        DepartmentName = "Accounting Department",
                        Image = "null",
                        Status = "open"
                    }
                    );
                context.Department.AddRange(
                    new Department
                    {
                        DepartmentName = "Human Resource",
                        Image = "null",
                        Status = "open"
                    }
                    );

                /*---------------------------------*/

              

                context.SaveChanges();
            }

            
        }
    }
}
