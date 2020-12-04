namespace MidTermSolution.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CourseAndCourseStatusData : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Courses(CourseName,CourseDescription,TutorName,CourseRating) values ('ASP.NET Core', 'ASP.NET Core for Beginners','Mosh Hamedini', 8)");
            Sql("Insert into Courses(CourseName,CourseDescription,TutorName,CourseRating) values ('SQL Server', 'SQL SErver Standard','John S', 9)");
            Sql("Insert into Courses(CourseName,CourseDescription,TutorName,CourseRating) values ('Python', 'Python for Advancced','Mary Smith', 10)");
            Sql("Insert into Courses(CourseName,CourseDescription,TutorName,CourseRating) values ('Azure', 'Azure for Beginners','MSFT', 10)");

            Sql("Insert into CourseStatus(Status) Values('In-Progress')");
            Sql("Insert into CourseStatus(Status) Values('Completed')");
        }
        
        public override void Down()
        {
        }
    }
}
