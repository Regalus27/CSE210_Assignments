using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new("John", "Homework W01");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new("John", "Math Homework", "6.1", "7-11");
        Console.WriteLine(mathAssignment.GetSummary());

        WritingAssignment writingAssignment = new("John", "Lit HW", "Writing Stuff");
        Console.WriteLine(writingAssignment.GetSummary());
    }
}