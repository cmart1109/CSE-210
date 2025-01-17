using System;

class Program
{
        List<Entry> _entries = new List<Entry>();
    static void Main(string[] args)
    {
        string election;
        int electionNumber;
        do 
        {
        Console.WriteLine("Please select one of the following choices");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        election = Console.ReadLine();
        electionNumber = int.Parse(election);
        if (electionNumber == 1)
        {
            
        }
        } while (electionNumber != 5);

    }
}