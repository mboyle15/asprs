using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace asprs3.Models
{
    public class Activity
    {
        [Key]
        public int ActivityId { get; set; }

        [Required]
        //[StringLength(100, ErrorMessage = "Must enter a Trip Name", MinimumLength = 1)]
        [DataType(DataType.Text)]
        [Display(Name = "Activity Name")]
        public string ActivityName { get; set; }

        [Required]
        //[StringLength(100, ErrorMessage = "Must enter a Trip Name", MinimumLength = 1)]
        [DataType(DataType.Text)]
        [Display(Name = "Activity Location")]
        public string ActivityLocation { get; set; }

        [Required]
        [DataType(DataType.Time)]
        [Display(Name = "Activity Start Time")]
        public DateTime? ActivityStartTime { get; set; }

        [Required]
        [DataType(DataType.Time)]
        [Display(Name = "Activity End Time")]
        public DateTime? ActivityEndTime { get; set; }

        //[Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Daily Cost")]
        public int DailyCost { get; set; }

        //[Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Cost")]
        public int Cost { get; set; }

        [Required]
        [Display(Name = "Capacity")]
        public int Capacity { get; set; }

        [Required]
        [Display(Name = "Enrollment")]
        public int Enrollment { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Eligible Grades")]
        public string EligibleGrades { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Offered Days")]
        public string OfferedDays { get; set; }

        [Required]
        [Display(Name = "Quarter")]
        public int Quarter { get; set; }

    }
}