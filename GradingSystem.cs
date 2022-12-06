using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGpaCalculator
{
    public static class GradingSystem
    {
        public static string Grade(int score)
        {
            var grade = string.Empty;

            if (score >= 70 )
            {
                grade = "A";
            }
            else if (score >= 60 )
            {
                grade = "B";
            }
            else if (score >= 50 )
            {
                grade = "C";
            }
            else if (score >= 45 )
            {
                grade = "D";
            }
            else if (score >= 40 )
            {
                grade = "E";
            }
            else if (score >= 0 )
            {
                grade = "F";
            }

            return grade;

        }

        public static int Point(string grade)
        {
            var point = 0;
           switch(grade)
           {
                case "A":
                    point = 5;
                    break;

                case "B":
                    point = 4;
                    break;

                case "C":
                    point = 3;
                    break;

                case "D":
                    point = 2;
                    break;
                
                case "E":
                    point = 1;
                    break;
                
                case "F":
                    point = 0;
                    break;
           }

            return point;
        }

        public static string Remark(int point)
        {
            var remark = string.Empty;

            switch (point)
            {
                case 5:
                    remark = "Excellent";
                    break;

                case 4:
                    remark = "Very Good";
                    break;

                case 3:
                    remark = "Good";
                    break;

                case 2:
                    remark = "Fair";
                    break;

                case 1:
                    remark = "Pass";
                    break;

                case 0:
                    remark = "Fail";
                    break;
            }

            return remark;
        }
    }
}
