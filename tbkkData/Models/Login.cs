using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class Login
    {
        [Key]
        public int LoginID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }


        [ForeignKey("Employee")]
        public int Login_EmployeeID { get; set; }
        public Employee Employee { get; set; }
    }
}
