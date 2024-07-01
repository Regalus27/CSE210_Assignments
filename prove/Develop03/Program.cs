// STRETCH CHALLENGE COMPLETED
// Program will only hide words that are not already hidden.
// See Scripture.cs Lines 33-49

using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new("Mosiah", 2, 17);
        String words = "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God.";
        Scripture scripture = new(words, reference);

        ShowScripture(scripture);
        while(!scripture.IsCompletelyHidden())
        {
            if (Console.ReadLine().Equals("quit", StringComparison.CurrentCultureIgnoreCase)) // modern code editors are cool
            {
                break;
            }
            else
            {
                scripture.HideRandomWords(5);
            }
            ShowScripture(scripture);
        }
    }

    static void ShowScripture(Scripture scripture)
    {
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.Write("\nPress enter to continue or type 'quit' to finish: ");
    }
}