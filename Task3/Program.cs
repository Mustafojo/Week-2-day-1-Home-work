var stusen1 = new Student();
stusen1.Name = "Mustafo";
stusen1.GradeLevel = 1;
stusen1.TestScores = 90;
System.Console.WriteLine(stusen1.GetAverage());
var stusen2 = new Student();
stusen2.Name = "Barotov";
stusen2.GradeLevel = 2;
stusen2.TestScores = 84;
System.Console.WriteLine(stusen2.GetAverage());

var stusen3 = new Student();
stusen3.Name = "Talaba";
stusen3.GradeLevel = 3;
stusen3.TestScores = 56;
System.Console.WriteLine(stusen3.GetAverage());


var stusen4 = new Student();
stusen4.Name = "Donishju";
stusen4.GradeLevel = 4;
stusen4.TestScores = 100;
System.Console.WriteLine(stusen4.GetAverage());


var stusen5 = new Student();
stusen5.Name = "Student";
stusen5.GradeLevel = 5;
stusen5.TestScores = 70;
System.Console.WriteLine(stusen5.GetAverage());





public class Student
{
    public string Name { get; set; }
    public int GradeLevel { get; set; }
    public int TestScores { get; set; }
    public string GetAverage()
    {
        if(TestScores >= 85)
        {
            return "Ofarin";
        }
        else if(TestScores < 85 && TestScores > 70)
        {
            return "Bisyortar kushish kun";
        }
        else
        {
            return "In hele bad ast";
        }
    }
}