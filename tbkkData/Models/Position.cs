using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace tbkkData.Models
{
    public class Position
    {
        [Key]
        public int PositionID { get; set; }
        public string PositionName { get; set; }
    }
}
