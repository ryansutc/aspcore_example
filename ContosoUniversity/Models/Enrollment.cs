using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }

        // foreign key (corresponding navigation prop is Student)
        // Interpreted automatically as a foreign key w. [NavigationPropName + PrimaryKey Prop name] Student + ID
        public int StudentID { get; set; }
        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade { get; set; }

        // A Navigation Property (https://learn.microsoft.com/en-us/ef/core/modeling/relationships)
        // Enrollments BELONG to 1 course. This is the related field.
        public Course Course { get; set; }

        // Another Navigation Property. Enrollments BELONG TO 1 student. A "relationship" in EF Core parlance.
        public Student Student { get; set; }
    }
}