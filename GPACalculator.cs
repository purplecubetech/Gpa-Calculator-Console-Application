using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGpaCalculator
{
    public static class GPACalculator
    {
         public static int TotalPoint(List<Courses> courses)
        {
            var totalPoint = 0;

            foreach (var item in courses)
            {
                totalPoint += (int)(item.CourseUnit * item.GradeUnit);
            }

            return totalPoint;
        }

        public static int TotalGradeUnit(List<Courses> courses)
        {
            int totalGradeUnit = 0;

            foreach (var item in courses)
            {
                totalGradeUnit += (int)item.GradeUnit;
            }

            //totalGradeUnit /= courses.Count;

            return totalGradeUnit;
        }

        public static double GPA(int point, int gradeUnit)
        {
            return (double)point / gradeUnit;
        }

        public static void DisplayGPA(double gpa)
        {
            double cgpa = Math.Round(gpa, 2);
            Console.WriteLine("Your Gpa is: " + cgpa);
        }

    }
}
