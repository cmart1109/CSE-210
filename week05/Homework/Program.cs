using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment math = new MathAssignment("Christian Martinez","Math","9","17-19");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkString());
        Console.WriteLine("");
        WritingAssignment writing = new WritingAssignment("Christian Martinez","History","The World War II");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}