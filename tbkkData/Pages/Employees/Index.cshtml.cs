using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using tbkkData.Models;

namespace tbkkData.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly tbkkData.Models.tbkkDataContext _context;

        public IndexModel(tbkkData.Models.tbkkDataContext context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; }


        public IList<Department> Department { get; set; }

        public IList<Evaluation> Evaluation { get; set; }

        public GradeHistory GradeHistory { get; set; }

        public IList<string> DepartmentV2 { get; set; }
        public async Task OnGetAsync()
        {
            Employee = await _context.Employee 
                .ToListAsync();

            Department = await _context.Department
                .ToListAsync();

            Evaluation = await _context.Evaluation
               .ToListAsync();

            GradeHistory = await _context.GradeHistory
              .FirstOrDefaultAsync();


            DepartmentV2 = new List<string>();

         /*  for(int i = 0; i < Employee.Count(); i++)
            {
                for(int j = 0; j < Department.Count(); j++)
                {
                    if(Employee[i].Employee_DepartmentNameID == Department[j].DepartmentID)
                    {
                        DepartmentV2.Add(Employee[i].DepartmentID.DepartmentName);
                        break;
                    }
                }
            }*/


        }
       
    }
}
