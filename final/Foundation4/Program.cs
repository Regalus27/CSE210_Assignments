using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        List<Activity> activities = [];
        activities.Add(new Run("03 Nov 2022", 30, 3.0));
        activities.Add(new Bike("04 Nov 2022", 220, 7.5));
        activities.Add(new Swim("05 Nov 2022", 75, 18));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}