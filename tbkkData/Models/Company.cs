using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class Company
    {
        [Key]
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string Image { get; set; }
        public string Status { get; set; }
    }
}
