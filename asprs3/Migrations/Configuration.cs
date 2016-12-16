namespace asprs3.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using asprs3.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<asprs3.Models.Model1>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(asprs3.Models.Model1 context)
        {

            context.Students.AddOrUpdate(x => x.StudentID,
                new Student() { StudentID = 1, StudentFName = "Sam", StudentLName = "Samson", StudentDOB = new DateTime(2004, 1, 1), StudentGrade = 6 }
                );
            context.Students.AddOrUpdate(x => x.StudentID,
                new Student() { StudentID = 2, StudentFName = "Jon", StudentLName = "Johnson", StudentDOB = new DateTime(2005, 1, 1), StudentGrade = 5 }
                );
            context.Students.AddOrUpdate(x => x.StudentID,
                new Student() { StudentID = 3, StudentFName = "Pete", StudentLName = "Peters", StudentDOB = new DateTime(2011, 1, 1), StudentGrade = 0 }
                );
            context.Students.AddOrUpdate(x => x.StudentID,
                new Student() { StudentID = 4, StudentFName = "Nick", StudentLName = "Nichols", StudentDOB = new DateTime(2008, 1, 1), StudentGrade = 3 }
                );


            context.Activities.AddOrUpdate(x => x.ActivityID,
                new Activity()
                {
                    ActivityID = 1,
                    ActivityName = "Yearbook Club",
                    ActivityFacilitator = "Frau Belleville, Frau Maddy",
                    ActivityLocation = "TBA",
                    ActivityStartTime = new TimeSpan(3, 15, 0),
                    ActivityEndTime = new TimeSpan(4, 15, 0),
                    Cost = 40,
                    Capacity = 2,
                    CurrentEnrollment = 0,
                    EligibleGrades = "7,8",
                    OfferedDays = "Mon",
                    Quarter = 3
                }
                );
            context.Activities.AddOrUpdate(x => x.ActivityID,
                new Activity()
                {
                    ActivityID = 2,
                    ActivityName = "Reading Club 3-4",
                    ActivityFacilitator = "Frau Cooper",
                    ActivityLocation = "RM 207",
                    ActivityStartTime = new TimeSpan(3, 15, 0),
                    ActivityEndTime = new TimeSpan(4, 15, 0),
                    Cost = 40,
                    Capacity = 20,
                    CurrentEnrollment = 0,
                    EligibleGrades = "3,4",
                    OfferedDays = "Mon",
                    Quarter = 3
                }
                );
            context.Activities.AddOrUpdate(x => x.ActivityID,
                new Activity()
                {
                    ActivityID = 3,
                    ActivityName = "Reading Club 5-6",
                    ActivityFacilitator = "Frau Cooper",
                    ActivityLocation = "RM 207",
                    ActivityStartTime = new TimeSpan(3, 15, 0),
                    ActivityEndTime = new TimeSpan(4, 15, 0),
                    Cost = 40,
                    Capacity = 20,
                    CurrentEnrollment = 0,
                    EligibleGrades = "5,6",
                    OfferedDays = "Wed",
                    Quarter = 3
                }
                );
            context.Activities.AddOrUpdate(x => x.ActivityID,
                new Activity()
                {
                    ActivityID = 4,
                    ActivityName = "Arabic Language Club",
                    ActivityFacilitator = "Frau Edais, Herr Bearss",
                    ActivityLocation = "RM 220",
                    ActivityStartTime = new TimeSpan(3, 15, 0),
                    ActivityEndTime = new TimeSpan(4, 15, 0),
                    Cost = 80,
                    Capacity = 25,
                    CurrentEnrollment = 0,
                    EligibleGrades = "2,3,4,5,6,7,8",
                    OfferedDays = "Mon,Wed",
                    Quarter = 3
                }
                );
            context.Activities.AddOrUpdate(x => x.ActivityID,
                new Activity()
                {
                    ActivityID = 5,
                    ActivityName = "Middle School Math Support",
                    ActivityFacilitator = "Frau Oakley",
                    ActivityLocation = "RM 218",
                    ActivityStartTime = new TimeSpan(3, 15, 0),
                    ActivityEndTime = new TimeSpan(4, 15, 0),
                    Cost = 80,
                    Capacity = 20,
                    CurrentEnrollment = 0,
                    EligibleGrades = "6,7,8",
                    OfferedDays = "Mon,Wed",
                    Quarter = 3
                }
                );
            context.Activities.AddOrUpdate(x => x.ActivityID,
                new Activity()
                {
                    ActivityID = 6,
                    ActivityName = "Travel Club",
                    ActivityFacilitator = "Frau Cooper",
                    ActivityLocation = "RM 207",
                    ActivityStartTime = new TimeSpan(3, 15, 0),
                    ActivityEndTime = new TimeSpan(4, 15, 0),
                    Cost = 40,
                    Capacity = 15,
                    CurrentEnrollment = 0,
                    EligibleGrades = "6,7,8",
                    OfferedDays = "Tue",
                    Quarter = 3
                }
                );
            context.Activities.AddOrUpdate(x => x.ActivityID,
                new Activity()
                {
                    ActivityID = 7,
                    ActivityName = "Arts & Crafts",
                    ActivityFacilitator = "Frau Maddy",
                    ActivityLocation = "RM 132",
                    ActivityStartTime = new TimeSpan(3, 15, 0),
                    ActivityEndTime = new TimeSpan(4, 15, 0),
                    Cost = 40,
                    Capacity = 15,
                    CurrentEnrollment = 0,
                    EligibleGrades = "K,1,2",
                    OfferedDays = "Tue",
                    Quarter = 3
                }
                );
            context.Activities.AddOrUpdate(x => x.ActivityID,
                new Activity()
                {
                    ActivityID = 8,
                    ActivityName = "Drama Club",
                    ActivityFacilitator = "Frau Johnson, Frau Sanders",
                    ActivityLocation = "RM 220",
                    ActivityStartTime = new TimeSpan(3, 15, 0),
                    ActivityEndTime = new TimeSpan(4, 15, 0),
                    Cost = 80,
                    Capacity = 20,
                    CurrentEnrollment = 0,
                    EligibleGrades = "1,2,3,4,5,6,7,8",
                    OfferedDays = "Tue,Thu",
                    Quarter = 3
                }
                );
            context.Activities.AddOrUpdate(x => x.ActivityID,
                new Activity()
                {
                    ActivityID = 9,
                    ActivityName = "Boys Basketball",
                    ActivityFacilitator = "Frau Robinson, Herr Strauch",
                    ActivityLocation = "Gym",
                    ActivityStartTime = new TimeSpan(3, 15, 0),
                    ActivityEndTime = new TimeSpan(5, 0, 0),
                    Cost = 80,
                    Capacity = 15,
                    CurrentEnrollment = 0,
                    EligibleGrades = "5,6,7,8",
                    OfferedDays = "Tue Thu",
                    Quarter = 3
                }
                );


        }
    }
}
