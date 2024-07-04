using System;

class Program
{
    static void Main(string[] args)
    {
        Activity activity = ChooseActivity();
        activity.Start();
    }

    static Activity ChooseActivity()
    {
        Console.Clear();
        Console.WriteLine("Choose an Activity:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.Write("Enter: ");
        if(Int32.TryParse(Console.ReadLine(), out int choice))
        {
            int duration;
            switch (choice)
            {
                case 1:
                    duration = ChooseDuration();
                    return new BreathingActivity(duration);
                case 2:
                    duration = ChooseDuration();
                    return new ReflectionActivity(duration);
                case 3:
                    duration = ChooseDuration();
                    return new ListingActivity(duration);
                default:
                    return ChooseActivity();
            }
        }
        else
        {
            return ChooseActivity();
        }
    }

    static int ChooseDuration()
    {
        Console.Clear();
        Console.WriteLine("How long would you like to do this activity?");
        Console.Write("Enter: ");
        if(Int32.TryParse(Console.ReadLine(), out int duration))
        {
            return duration;
        }
        else
        {
            return ChooseDuration();
        }
    }
}