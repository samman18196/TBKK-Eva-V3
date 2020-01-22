using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class SeedCompany
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new tbkkDataContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<tbkkDataContext>>()))
            {
                // Look for any movies.

                if (context.Company.Any())
                {
                    return;   // DB has been seeded
                }

               



                context.Company.AddRange(
                    new Company
                    {
                        CompanyName = "Tbkk",
                        Image = "null",
                        Status = "open"
                    }
                    );

          



           
                context.SaveChanges();
            }

            
        }
    }
}
