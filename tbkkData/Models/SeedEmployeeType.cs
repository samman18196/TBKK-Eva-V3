using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class SeedEmployeeType
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new tbkkDataContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<tbkkDataContext>>()))
            {
                

                if (context.EmployeeType.Any())
                {
                    return;   
                }



                context.EmployeeType.AddRange(
                    new EmployeeType
                    {
                        EmployeeTypeName = "Full Time"
                    }
                    );
                context.EmployeeType.AddRange(
                   new EmployeeType
                   {
                       EmployeeTypeName = "Part Time"
                   }
                   );








                context.SaveChanges();
            }


        }
    }
}


