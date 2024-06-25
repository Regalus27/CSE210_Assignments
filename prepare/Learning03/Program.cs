using System;

class Program
{
    static void Main(string[] args)
    {
        List<Fraction> fractions = [];
        try
        {
            fractions.Add(new Fraction());      // 1/1 (Default initialization)
            fractions.Add(new Fraction(5, 1));  // 5/1
            fractions.Add(new Fraction(3, 4));  // 3/4
            fractions.Add(new Fraction(1, 3));  // 1/3
            fractions.Add(new Fraction(-1, 1)); // -1/1
            fractions.Add(new Fraction(1, -1)); // -1/1
            fractions.Add(new Fraction(-1, -1));// 1/1
            fractions.Add(new Fraction(1, 0));  // 1/0 (Exception)
                                                // All following lines of code in this try block will
                                                //   be skipped due to the exception being thrown.
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine($"{e.GetType().Name}: {e.Message}");
        }
        foreach (Fraction fraction in fractions)
            {
                Console.WriteLine(fraction.GetFractionString());
                Console.WriteLine(fraction.getDecimalValue());
            }
    }
}