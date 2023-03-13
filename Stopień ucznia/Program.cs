using Stopień_ucznia;
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Welcome on the student gradebook !");
Console.WriteLine();

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Gray;

Console.WriteLine("Instructions for using the gradebook.");
Console.WriteLine("The first step is to enter the student's grades from 1 to 6.");
Console.WriteLine("To finish grading, enter the letter 'q'.");
Console.WriteLine("When grading is complete, the student's statistics will be displayed showing the average grade, the lowest and highest grade, and the final grade.");
Console.WriteLine("I wish you a pleasant use of the gradebook.");
Console.WriteLine();

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.DarkBlue;

var employee = new StudentInFile("Adam", "Kuliczkowski");
while (true)
{
    Console.WriteLine("Enter a student grade from 1 to 6 and press enter to accept the grade. To finish grading, select 'q' and press enter.");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }

    try
    {
        employee.AddGrade(input);
    }
    catch (Exception exception)
    {
        Console.WriteLine($"Exception catched: {exception.Message}");
    }
}
var StatisticsStudents = employee.GetStatistics();

Console.WriteLine();
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine($"Student {employee.Name} {employee.Surname}");
Console.WriteLine();
Console.WriteLine($"Average: {StatisticsStudents.Average:N2}");
Console.WriteLine($"Lowest grade: {StatisticsStudents.Min}");
Console.WriteLine($"Highest grade: {StatisticsStudents.Max}");
Console.WriteLine($"Final grade: {StatisticsStudents.AverageLetter}");
Console.WriteLine();
Console.WriteLine("Thanks for using my app. I hope everything was clear and trouble-free. Have a nice day :)");