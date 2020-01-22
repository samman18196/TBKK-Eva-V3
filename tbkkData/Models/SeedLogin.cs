using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class SeedLogin
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new tbkkDataContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<tbkkDataContext>>()))
            {
                // Look for any movies.

                if (context.Login.Any())
                {
                    return;   // DB has been seeded
                }

               




                context.Login.AddRange(
                new Login
                {
                    Username = "admin",

                    Password = "admin",

                    Login_EmployeeID = 1
                }
                );

               
                context.Login.AddRange(
                new Login
                {
                    Username = "user1",

                    Password = "user1",

                    Login_EmployeeID = 2
                }
                );








                context.SaveChanges();
            }

            
        }
    }
}
