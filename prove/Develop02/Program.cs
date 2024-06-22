using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        int attempts = 0;
        bool escape = false;
        Journal journal = new();
        while(attempts < 10000 && !escape)
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("[1]: Write");
            Console.WriteLine("[2]: Display");
            Console.WriteLine("[3]: Load");
            Console.WriteLine("[4]: Save");
            Console.WriteLine("[5]: Quit");
            Console.Write("Choose: ");
            string choice = Console.ReadLine();
            int number;
            if (!Int32.TryParse(choice, out number))
            {
                Console.WriteLine("Not a valid input.");
                continue;
            }

            switch(number)
            {
                case 1:
                    journal.NewEntry();
                    break;
                case 2:
                    journal.DisplayEntries();
                    break;
                case 3:
                    journal.LoadJournal();
                    Console.WriteLine("Journal Loaded.");
                    break;
                case 4:
                    journal.SaveJournal();
                    Console.WriteLine("Journal Saved.");
                    break;
                case 5:
                    escape = true;
                    break;
                default:
                    Console.WriteLine("Please enter a number between 1 and 5");
                    break;
            }
            // Infinite loop prevention
            attempts++;
        }
    }
}