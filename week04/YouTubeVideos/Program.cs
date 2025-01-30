using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static List<Video> _videos = new List<Video>();
    public string videoInfo;
    static void Main(string[] args)
    {
        // 1st Video
        Video video1 = new Video("Hacer Amigos","HolaSoyGerman","258");
        _videos.Add(video1);
        video1.StoreComments(new Comment("John","GreatVideo"));
        video1.StoreComments(new Comment("Mark","That´s Pretty Bad"));
        video1.StoreComments(new Comment("Marcus","Like if you are Here since 2018"));
         // 2nd Video
        Video video2 = new Video("El arte de procrastinar", "TheLazyArtist", "345");
        _videos.Add(video2);
        video2.StoreComments(new Comment("Anna", "Wow, this is so relatable!"));
        video2.StoreComments(new Comment("Lucy", "I procrastinated watching this video."));
        video2.StoreComments(new Comment("Tom", "This changed my life, thanks!"));
        // 3rd Video
        Video video3 = new Video("Learning C#", "CodeMaster", "420");
        _videos.Add(video3);
        video3.StoreComments(new Comment("Jake", "Clear and concise explanation."));
        video3.StoreComments(new Comment("Mia", "Can you make one for beginners?"));
        video3.StoreComments(new Comment("Alex", "Perfect for my project. Thanks!"));

        foreach (var video in _videos)
        {
            Console.WriteLine(video.GetDisplayInfo());
            Console.WriteLine("Comments");
            video.ShowAllComments();
            Console.WriteLine();
        }
    }
}