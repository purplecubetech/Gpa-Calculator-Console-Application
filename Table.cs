using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGpaCalculator
{
    public class Table
    {
        public static int tablewidth = 120;

        public static void TableView(List<Courses> courses)
        {
            Console.WriteLine("=============================================================================================");
            Console.WriteLine("| COURSE CODE\t| COURSE UNIT\t| SCORE\t| GRADE\t| GRADE UNIT\t| TOTAL POINT\t| REMARK|");
            Console.WriteLine("=============================================================================================");

            foreach (var course in courses)
            {
                var totalpoint = course.GradeUnit * course.Point;
                Console.WriteLine($"{course.CourseName}{course.Code}\t\t| {course.CourseUnit}\t\t| {course.Grade}\t\t| {course.GradeUnit}\t\t| {course.Point}\t\t| {course.Remarks}\t|");
            }
            Console.WriteLine("---------------------------------------------------------------------------------------------");
        }

       
    }
}
