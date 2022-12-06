using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleGpaCalculator
{
    public class DisplayConsole
    {
        public static List<Courses> EntryProgram()
        {
            int score = 0;
            int courseCode = 0;
            int unit = 0;
            int courseNum = 0;
            int option = 0;
            string courseName = string.Empty;
            var Courses = new List<Courses>();
            Console.WriteLine("==========================WELCOME==============================================");

            while (true)
            {
                bool status = true;
                while (status)
                {
                    Console.WriteLine("Put in \"options\" to see the menu");//Display info
                    var userInput = Console.ReadLine();//collect user data
                    if (userInput != null)//check if the data collected is empty
                    {
                        if (userInput.Equals("options"))
                        {
                            status = false;
                        }
                        else
                        {
                            break;
                        }
                    }//if passed false
                }
                    break;
            }

                do
                {
                    Console.WriteLine("Select the Option you want: ");
                    Options();
                    //var optionSelect = Convert.ToInt32(Console.ReadLine());
                    var userInput = Console.ReadLine();
                    var userInputConverted = int.TryParse(userInput, out option);
                } while (!ValidateOption(option));

                if (option == 1)
                {
                    Console.WriteLine("You selected to calculate GPA.");
                }

                do
                {
                    Console.WriteLine("How many courses do you offer: ");
                    var inputNum = Console.ReadLine();
                    var inputNumConversion = int.TryParse(inputNum, out courseNum);

                } while (!ValidateCourseNum(courseNum));

                var number = 1;

                while (courseNum > 0)
                {

                    Console.WriteLine("Enter the Course name: ");
                    courseName = Console.ReadLine().Trim().ToUpper();
                /*do
                    {
                        
                    } while (!ValidateCourseName(courseName));
*/
                        Console.WriteLine("Enter the Course code: ");
                        var inputcode = Console.ReadLine();
                        var inputcodeConverted = int.TryParse(inputcode, out courseCode);

                do
                {
                    Console.WriteLine("Enter the Course unit: ");
                    var inputUnit = Console.ReadLine();
                    var inputUnitConversion = int.TryParse(inputUnit, out unit);
                } while (!ValidateUnit(unit));

                    
                do
                    {
                        Console.WriteLine("Enter the Course score: ");
                        var inputScore = Console.ReadLine();
                        var inputScoreConversion = int.TryParse(inputScore, out score);
                    } while (!ValidateScore(score));

                    Courses.Add(new Courses()
                    {
                        Score = score,
                        Code = courseCode,
                        CourseUnit = unit,
                        CourseNum = courseNum,
                        CourseName = courseName
                    });

                    courseNum--;
                    number++;

                }

            return Courses;
        }


            private static bool ValidateScore(int score)
            {
                if (score < 0 || score > 100)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            private static void Options()
            {
                var options = @"Available choices:
            1 To Calculate GPA";

                Console.WriteLine("\n" + options);

            }

            private static bool ValidateCourseName(string courseName)
            {
                var regex = @"\%$#[]_@!*^~+";
                Regex newRegex = new Regex(regex);

                if (newRegex.IsMatch(courseName))
                    return false;
                return true;
            }

            private static bool ValidateCode(int code)
            {
                if (code < 0 || code > 100)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            private static bool ValidateUnit(int unit)
            {
                if (unit < 0 && unit > 5)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            private static bool ValidateCourseNum(int courseNum)
            {
                if (courseNum < 1 && courseNum > 5)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            private static bool ValidateOption(int option)
            {
                if (option < 1 && option > 3)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

    }
}

