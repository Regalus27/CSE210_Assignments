class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int userNumber = -1;
        List<int> userNumbers = new List<int>();
        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber != 0)
            {
                userNumbers.Add(userNumber);
            }
        }

        int sum = userNumbers.Sum();
        double average = userNumbers.Average();
        int largest = userNumbers.Max();
        // This should really be split into 2 lines / functions
        int smallest = userNumbers.FindAll(
            delegate(int num)
            {
                return num > 0;
            }
        ).Min();
        userNumbers.Sort();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallest}");
        foreach (int num in userNumbers)
        {
            Console.WriteLine(num);
        }
    }
}