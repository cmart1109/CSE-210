using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
    List<int> numberLists = new List<int>(); 
    string numbers;
    int numberToList;
        Console.WriteLine("Enter a list of numbers, type 0 when Finished");
        do
        {
        Console.WriteLine("Enter number: ");
        numbers = Console.ReadLine();
        numberToList = int.Parse(numbers);
        if (numberToList != 0)
        {
        numberLists.Add(numberToList);
        }
        else {

        }

        } while (numberToList != 0);

        foreach (int numberList in numberLists)
        {
            Console.WriteLine(numberList);
        }
        Console.WriteLine($"The Amount of the numbers is: {numberLists.Count}");
        Console.WriteLine($"The Sum of the numbers is: {numberLists.Sum()}");
        Console.WriteLine($"The Average of the numbers is: {numberLists.Average()}");
        Console.WriteLine($"The Maximun number on the list is: {numberLists.Max()}");
        numberLists.Sort();
        Console.WriteLine("Here is the List Sorted:");
         foreach (int numberList in numberLists)
        {
            Console.WriteLine(numberList);
        }
    }
}