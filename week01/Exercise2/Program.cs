using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please type your grade percentage: ");
        string grade = Console.ReadLine();
        int gradeNumber = int.Parse(grade);
        string letter;
        if (gradeNumber >= 90)
        {
            if (gradeNumber < 93)
            {
                letter = "A-";
            }
            else
            {
                letter = "A";
            }
        }
        else if (gradeNumber >= 80)
        {
            if (gradeNumber >= 87)
            {
                letter = "B+";
            }
            else if (gradeNumber < 83)
            {
                letter = "B-";
            }
            else 
            {
                letter = "B";
            }
        }
        else if (gradeNumber >= 70)
        {
            if (gradeNumber >= 77)
            {
                letter = "C+";
            }
            else if (gradeNumber <= 73)
            {
                letter = "C-";
            }
            else 
            {
                letter = "C";
            }
        }
        else if (gradeNumber >= 60)
        {
            if (gradeNumber >= 67)
            {
               letter = "D+"; 
            }
            else if (gradeNumber <= 63)
            {
                letter = "D-";
            }
            else 
            {
                letter = "D";
            }
        }
        else 
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");

        if (gradeNumber >= 70)
        {
            Console.WriteLine("You Approbed the Class!");
        }
        else 
        {
            Console.WriteLine("You Repprobed the Class");
        }
    }
}