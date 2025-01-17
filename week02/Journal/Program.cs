using System;
using System.IO;
class Program
{
        public static List<Entry> _entries = new List<Entry>();
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
        Console.WriteLine("You Choose to Write!");
        Entry entry1 = new Entry();
         entry1.GetEntry();
         entry1.Display();
         _entries.Add(entry1);
        Console.WriteLine("The Writings was succesfully saved!");
        }
        else if (electionNumber == 2)
        {
           foreach (var ent in _entries) 
           {
            Console.WriteLine(ent);
           }
        }
        else if (electionNumber == 4)
        {

            string fileName = "myFIle.txt";
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
            outputFile.WriteLine(_entries);

            }

        }
        } while (electionNumber != 5);

    }
}