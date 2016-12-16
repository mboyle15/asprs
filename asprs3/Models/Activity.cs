using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace asprs3.Models
{
    public class Activity
    {
        [Key]
        public int ActivityID { get; set; }

        [Required]
        //[StringLength(100, ErrorMessage = "Must enter a Trip Name", MinimumLength = 1)]
        [DataType(DataType.Text)]
        [Display(Name = "Activity Name")]
        public string ActivityName { get; set; }

        [Required]
        //[StringLength(100, ErrorMessage = "Must enter a Trip Name", MinimumLength = 1)]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Activity Facilitator")]
        public string ActivityFacilitator { get; set; }

        [Required]
        //[StringLength(100, ErrorMessage = "Must enter a Trip Name", MinimumLength = 1)]
        [DataType(DataType.Text)]
        [Display(Name = "Activity Location")]
        public string ActivityLocation { get; set; }

        [Required]
        [DataType(DataType.Time)]
        [Display(Name = "Activity Start Time")]
        public TimeSpan ActivityStartTime { get; set; }

        [Required]
        [DataType(DataType.Time)]
        [Display(Name = "Activity End Time")]
        public TimeSpan ActivityEndTime { get; set; }

        //[Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Daily Cost")]
        public int DailyCost { get; set; }

        //[Required]
        [DataType(DataType.Currency)]
        [Display(Name = "One-Time Cost")]
        public int Cost { get; set; }

        [Required]
        [Display(Name = "Capacity")]
        public int Capacity { get; set; }

        [Required]
        [Display(Name = "Current Enrollment")]
        public int CurrentEnrollment { get; set; }

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