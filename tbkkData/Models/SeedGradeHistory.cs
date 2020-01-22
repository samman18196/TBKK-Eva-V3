using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class SeedGradeHistory
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new tbkkDataContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<tbkkDataContext>>()))
            {
               

                if (context.GradeHistory.Any())
                {
                    return;   
                }


                context.GradeHistory.AddRange(
                    new GradeHistory
                    {
                        GrahAllPoint = 0,
                        Count = 1,
                        GrahRound1 = 0,
                        GrahRound2 = 0,
                        GrahRound3 = 0,
                        GrahYear = "2562",
                        GrahBonusUp = 10000,
                        GrahSalaryUp = 25000,

                    }
                    );
                    context.GradeHistory.AddRange(
                   new GradeHistory
                   {
                       GrahAllPoint = 3,
                       Count = 2,
                       GrahRound1 = 3,
                       GrahRound2 = 3,
                       GrahRound3 = 3,
                       GrahYear = "2562",
                       GrahBonusUp = 5000,
                       GrahSalaryUp = 2000,

                   }
                   );
                    context.GradeHistory.AddRange(
                   new GradeHistory
                   {
                       GrahAllPoint = 5,
                       Count = 2,
                       GrahRound1 = 4,
                       GrahRound2 = 4,
                       GrahRound3 = 4,
                       GrahYear = "2562",
                       GrahBonusUp = 10000,
                       GrahSalaryUp = 25000,

                   }
                   );
                    context.GradeHistory.AddRange(
                   new GradeHistory
                   {
                       GrahAllPoint = 4,
                       Count = 1,
                       GrahRound1 = 4,
                       GrahRound2 = 4,
                       GrahRound3 = 4,
                       GrahYear = "2562",
                       GrahBonusUp = 10000,
                       GrahSalaryUp = 25000,

                   }
                   );
                    context.GradeHistory.AddRange(
                   new GradeHistory
                   {
                       GrahAllPoint = 3,
                       Count = 1,
                       GrahRound1 = 3,
                       GrahRound2 = 3,
                       GrahRound3 = 3,
                       GrahYear = "2562",
                       GrahBonusUp = 10000,
                       GrahSalaryUp = 25000,

                   }
                   );






                context.SaveChanges();
            }

            
        }
    }
}
