using ConsoleGpaCalculator;

var studentGrade = "";
var gradeUnit = 0;
var remark = "";
var userPoint = 0;
var userUnit = 0;
double gradePoint = 0;

while(true)
{
    List<Courses> courses = DisplayConsole.EntryProgram();
    foreach (var course in courses)
    {
        studentGrade = GradingSystem.Grade(course.Score);
        gradeUnit = GradingSystem.Point(studentGrade);
        remark = GradingSystem.Remark(gradeUnit);

        course.Grade = studentGrade;
        course.GradeUnit = gradeUnit;
        course.Remarks = remark;

    }

    Table.TableView(courses);
    userPoint = GPACalculator.TotalPoint(courses);
    userUnit = GPACalculator.TotalGradeUnit(courses);
    gradePoint = GPACalculator.GPA(userPoint, userUnit);

    GPACalculator.DisplayGPA(gradePoint);
    Console.WriteLine("Type \"exit\" to quit the application");
    var exit = Console.ReadLine();
    if(exit == "exit")
    {
        break;
    }

}
