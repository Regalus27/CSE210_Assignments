class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int userSquaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, userSquaredNumber);
    }

    static void DisplayResult(string userName, int userSquaredNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {userSquaredNumber}");
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static int SquareNumber(int userNumber)
    {
        return userNumber * userNumber;
    }

    static String PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        if (int.TryParse(Console.ReadLine(), out int userNumber))
        {
            return userNumber;
        }
        else
        {
            Console.WriteLine("Please enter an integer.");
            return PromptUserNumber();
        }
    }
}