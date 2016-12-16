using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace asprs3.Models
{
    public class Enrollment
    {
        [Key]
        public int Enrollment_Id { get; set; }

        [Required]
        public int StudentID { get; set; }
        [ForeignKey("StudentID")]
        public virtual Student Student { get; set; }

        [Required]
        public int ActivityId { get; set; }
        [ForeignKey("ActivityId")]
        public virtual Activity Activity { get; set; }
    }
}