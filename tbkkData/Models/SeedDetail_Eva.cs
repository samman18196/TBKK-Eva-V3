using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class SeedDetail_Eva
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new tbkkDataContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<tbkkDataContext>>()))
            {
                // Look for any movies.

                if (context.Detail_Eva.Any())
                {
                    return;   // DB has been seeded
                }

               




                context.Detail_Eva.AddRange(
             new Detail_Eva
             {
                 Evaluator_ID = 1,
                 Comment = "Good",
                 DeEva_EmployeeID = 1,
                 DeEva_EvaluationID = 1,
                 DeEva_GradeHistoryID = 1
             }
             );




                context.SaveChanges();
            }

            
        }
    }
}
