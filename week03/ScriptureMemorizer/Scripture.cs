using System.IO.Compression;
using System.Runtime.InteropServices;


public class Scripture
{
    
    private List<Word> _words = new List<Word>();
    public Scripture(Reference reference, string text)
    {   
        var WordsArray = text.Split(" ");
        foreach (var word in WordsArray)
        {
            Word wordToAdd = new Word(word);
            _words.Add(new Word (word));
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
        return string.Join(" ", _words.Select(word => word.GetDisplayText()));
    }
}