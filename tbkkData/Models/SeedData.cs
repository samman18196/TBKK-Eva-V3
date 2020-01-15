using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new tbkkDataContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<tbkkDataContext>>()))
            {
                // Look for any movies.

                if (context.EmployeeType.Any())
                {
                    return;   // DB has been seeded
                }

               



                context.Position.AddRange(
                new Position
                {
                    PositionName = "admin"
                }
                );

                context.Position.AddRange(
                new Position
                {
                    PositionName = "Manager"
                }
                );
                context.Position.AddRange(
                new Position
                {
                    PositionName = "Employee"
                }
                );
                context.Position.AddRange(
               new Position
               {
                   PositionName = "CEO"
               }
               );



                /* ---------------------------------*/



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

                /*---------------------------------*/

               

                /*---------------------------------*/

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

                context.Company.AddRange(
                    new Company
                    {
                        CompanyName = "Tbkk",
                        Image = "null",
                        Status = "open"
                    }
                    );

                context.SaveChanges();
                /*---------------------------------*/


            }



            using (var context = new tbkkDataContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<tbkkDataContext>>()))
            {
                // Look for any movies.

                if (context.Login.Any())
                {
                    return;   // DB has been seeded
                }


                /*---------------------------------*/

                context.Employee.AddRange(
                    new Employee
                    {
                        FirstName = "Charlotte",
                        LastName = "Daisy",
                        Address = "London",
                        Telephone = "0632158475",
                        Salary = 16000,
                        Email = "Charlotte@gmail.com",
                        Age = 23,
                        Birthday = DateTime.Parse("2539-3-2"),
                        Status = "Working",
                        Date_of_employment = DateTime.Parse("2562-3-2"),
                        Gender ="male",
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
                         Age = 31,
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



                /*---------------------------------*/


                context.Login.AddRange(
                new Login
                {
                    Username = "admin",

                    Password = "admin",

                    Login_EmployeeID = 1
                }
                );

                /*+++++++++++++++++++++++++++++++++++++++++++*/
                context.Login.AddRange(
                new Login
                {
                    Username = "user1",

                    Password = "user1",

                    Login_EmployeeID = 2
                }
                );
               

                /*+++++++++++++++++++++++++++++++++++++++++++*/









              

                context.SaveChanges();
            }

            using (var context = new tbkkDataContext(
               serviceProvider.GetRequiredService<
                   DbContextOptions<tbkkDataContext>>()))
            {
                // Look for any movies.

                if (context.GradeHistory.Any())
                {
                    return;   // DB has been seeded
                }

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
                context.Evaluation.AddRange(
               new Evaluation
               {
                   EvaDetail = "NULL",
                   EvaSumPoint = 4,
                   EvaDate = DateTime.Parse("2562-2-12"),
                   EvaStatus = 2,
                   Evatype = "1",
                   Eva_GradeHistoryID = 1
               }
               );
                context.Evaluation.AddRange(
               new Evaluation
               {
                   EvaDetail = "NULL",
                   EvaSumPoint = 4,
                   EvaDate = DateTime.Parse("2562-2-12"),
                   EvaStatus = 2,
                   Evatype = "1",
                   Eva_GradeHistoryID = 2,
                   EvaluatorID = 1
               }
               );
                context.Evaluation.AddRange(
               new Evaluation
               {
                   EvaDetail = "NULL",
                   EvaSumPoint = 4,
                   EvaDate = DateTime.Parse("2562-2-12"),
                   EvaStatus = 2,
                   Evatype = "1",
                   Eva_GradeHistoryID = 3,
                   EvaluatorID = 1
               }
               );
                context.Evaluation.AddRange(
               new Evaluation
               {
                   EvaDetail = "NULL",
                   EvaSumPoint = 4,
                   EvaDate = DateTime.Parse("2562-2-12"),
                   EvaStatus = 2,
                   Evatype = "1",
                   Eva_GradeHistoryID = 4,
                   EvaluatorID = 1
               }
               );
                context.Evaluation.AddRange(
               new Evaluation
               {
                   EvaDetail = "NULL",
                   EvaSumPoint = 4,
                   EvaDate = DateTime.Parse("2562-2-12"),
                   EvaStatus = 2,
                   Evatype = "1",
                   Eva_GradeHistoryID = 5,
                   EvaluatorID = 1
               }
               );

                context.SaveChanges();
            }
        }
    }
}
