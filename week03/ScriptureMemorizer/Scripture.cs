using System.IO.Compression;
using System.Runtime.InteropServices;

public class Scripture
{
    
    public List<Word> _words = new List<Word>();
    public Scripture(Reference reference, string text)
    {   
        var WordsArray = text.Split(" ");
        foreach (var word in WordsArray)
        {
            Word word1 = new Word(word);
            _words.Add(word1);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
     Random random = new Random();
     int hiddenCount = 0;
     while (hiddenCount < numberToHide)
     {
        int index = random.Next(_words.Count);
        if (!_words[index].IsHidden())
        {
            _words[index].Hide();
            hiddenCount++;
        }

        if (hiddenCount == _words.Count){
            break;
        }
     }   
    }
    public string GetDisplayText()
    {
        Console.WriteLine("Dinner");
        return string.Join("",_words.Select(word => word.GetType()));
    }
}