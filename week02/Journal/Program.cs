using System;
using System.Collections.Generic;
using System.IO;


// This is the main class of the program. It provides a menu-driven application to write, display, save, and load entries using a simple text-based interface.
class Program

{
    public static List<Entry> _entries = new List<Entry>();
    //This is the entry point of the program. It handles the user interaction through a menu, allowing actions like writing, displaying, saving, and loading entries.
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
        else if (electionNumber == 3)
        {
           string filename = "myfile.txt";
           string[] lines = System.IO.File.ReadAllLines(filename);
           foreach (string line in lines)
           {
            Console.WriteLine(line);
           }
        }
        else if (electionNumber == 4)
        {
            string fileName = "myfile.txt";
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
            foreach (var ent in _entries)
            {
                outputFile.WriteLine(ent.ToString());
                Console.WriteLine("Succesfully Saved!");
            }
            }

        }
        } while (electionNumber != 5);

    }
}

// at the Beggining i was having issues trying to create the txt file, but now it worked, in an easy way.