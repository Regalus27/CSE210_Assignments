using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Address address = new("5435 Street Way", "Old Town", "Alaska", "United States of America");
        Lecture lecture = new("LectureName", "Description of the lecture given in Alaska on some cool topic.", "June 10 2025", "5:45 PM", address, "Speakin' Man", 45);
        Console.WriteLine("Short Message:\n" + lecture.GetShortMessage());
        Console.WriteLine("Standard Message:\n" + lecture.GetStandardMessage());
        Console.WriteLine("Detailed Message:\n" + lecture.GetDetailedMessage() + "\n");

        Reception reception = new("Reception in Alaska", "Description of the reception.", "June 11 2025",  "6:01 PM", address, "donotemailme@email.com");
        Console.WriteLine("Short Message:\n" + reception.GetShortMessage());
        Console.WriteLine("Standard Message:\n" + reception.GetStandardMessage());
        Console.WriteLine("Detailed Message:\n" + reception.GetDetailedMessage() + "\n");

        Gathering gathering = new("Bonfire Dance", "wow gathering description.", "June 11 2025",  "11:59 PM", address, "a roaring blizzard signaling the end of times");
        Console.WriteLine("Short Message:\n" + gathering.GetShortMessage());
        Console.WriteLine("Standard Message:\n" + gathering.GetStandardMessage());
        Console.WriteLine("Detailed Message:\n" + gathering.GetDetailedMessage() + "\n");
    }
}