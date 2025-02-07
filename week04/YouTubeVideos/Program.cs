using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static List<Video> _videos = new List<Video>();
    static void Main(string[] args)
    {
        
        Video vid1 = new Video("How to make a cake?","MasterChef", "302");
        vid1.StoreComments(new Comment("Ollymurs2000","That was insane! and so Fast!"));
        vid1.StoreComments(new Comment("NoobieChef","I want you guys to do a soup!"));
        vid1.StoreComments(new Comment("Lazydude","Please do more like this!"));
        _videos.Add(vid1);

        Video vid2 = new Video("Minecraft Gameplay, cap.15","Pewdiepie", "600");
        vid2.StoreComments(new Comment("John","That was a nice gameplay"));
        vid2.StoreComments(new Comment("Kamikaze Gamer","I hope you can go to nether next time"));
        vid2.StoreComments(new Comment("Fernafloo","I like That!"));
        _videos.Add(vid2);
        
        Video vid3 = new Video("Family Feud, Ep 20","Family Feud","1200");
        vid3.StoreComments(new Comment("Christian Martinez","That's Hillarious"));
        vid3.StoreComments(new Comment("Eduardo Macias","I would like to be there"));
        vid3.StoreComments(new Comment("Asdrubal Ordonz","Steve Harvey has a big moustache"));
        _videos.Add(vid3);

        foreach (var video in _videos)
        {
           video.ShowAllContent();
           Console.WriteLine(); 
        }}
    }
