using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class Detail_Eva
    {
        [Key]
        public int Detail_EvaID { get; set; }
        public int Evaluator_ID { get; set; }

        [ForeignKey("Employee")]
        public int DetailEva_EmployeeID { get; set; }
        public Employee Employee { get; set; }

        [ForeignKey("Evaluation")]
        public int DetailEva_EvaluationID { get; set; }
        public Evaluation Evaluation { get; set; }

        [ForeignKey("GradeHistory")]
        public int DetailEva_GradeHistoryID { get; set; }
        public GradeHistory GradeHistory { get; set; }
    }
}
