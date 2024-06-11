using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your grade: ");
        string grade = Console.ReadLine();
        if (Double.TryParse(grade, out double new_grade))
        {
            if (new_grade >= 90)
            {
                Console.WriteLine("A");
            }
            else if (new_grade >= 80)
            {
                Console.WriteLine("B");
            }
            else if (new_grade >= 70)
            {
                Console.WriteLine("C");
            }
            else if (new_grade >= 60)
            {
                Console.WriteLine("D");
            }
            else {
                Console.WriteLine("F");
            }

            if (new_grade >= 70)
            {
                Console.WriteLine("You Passed!");
            }
            else {
                Console.WriteLine("You failed.");
            }
        }
        else
        {
            Console.WriteLine("Invalid Format (Grade must be a number)");
        }
    }
}