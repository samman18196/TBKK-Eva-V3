using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class SeedEvaluation
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new tbkkDataContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<tbkkDataContext>>()))
            {
                // Look for any movies.

                if (context.Evaluation.Any())
                {
                    return;   // DB has been seeded
                }

               




                context.Evaluation.AddRange(
           new Evaluation
           {
               EvaName = "Competency",
          

           }
           );

                context.Evaluation.AddRange(
             new Evaluation
             {
                 EvaName = "KPI",
               

             }
             );
            

               



                context.SaveChanges();
            }

            
        }
    }
}
