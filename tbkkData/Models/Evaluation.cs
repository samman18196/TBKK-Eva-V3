using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkkData.Models
{
    public class Evaluation
    {
        [Key]
        public int EvaluationID { get; set; }
        public string EvaDetail { get; set; }
        public int EvaSumPoint { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        public DateTime EvaDate { get; set; }
        public int EvaStatus { get; set; }
        public string Evatype { get; set; }
        public int EvaluatorID { get; set; }



        [ForeignKey("GradeHistory")]
        public int Eva_GradeHistoryID { get; set; }
        public GradeHistory GradeHistoryID { get; set; }

    }
}
