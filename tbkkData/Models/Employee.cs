using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string Status { get; set; }
        public string Image { get; set; }
        public double Salary { get; set; }
        public string Gender { get; set; }


        [DataType(DataType.Date)]

        public DateTime Birthday { get; set; }

        [DataType(DataType.Date)]

        public DateTime Date_of_employment { get; set; }


        [ForeignKey("Company")]
        public int Employee_CompanyID { get; set; }
        public Company CompanyID { get; set; }


        [ForeignKey("Department")]
        public int Employee_DepartmentID { get; set; }
        public virtual Department DepartmentID { get; set; }




        [ForeignKey("EmployeeType")]
        public int Employee_EmployeeTypeID { get; set; }
        public EmployeeType EmployeeTypeID { get; set; }


        [ForeignKey("Position")]
        public int Employee_PositionID { get; set; }
        public Position PositionID { get; set; }

   



    }
}
