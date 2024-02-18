using System;

class Program
{
    static void Main(string[] args)
    {
        var videos = new List<Video>();

        Video video1 = new Video("The Golden Hour", "Ayra Starr", 120);
        video1.AddComment("Tolu", "The video is awesome");
        video1.AddComment("Andrew", "Lovely act");
        videos.Add(video1);

        Video video2 = new Video("Joy to the World", "The Mormon Tabernacle Choir", 180);
        video2.AddComment("Jude", "Wow! what a nice song from a beautiful choir");
        videos.Add(video2);

        Video video3 = new Video("PSG Vs Barcelona", "UEFA", 150);
        video3.AddComment("Eric", "What an excellent performance from Rodrygo");
        video3.AddComment("Carter", "The referee was bias, should have been 2 goals to nil");
        video3.AddComment("Timothy", "Nice Match!");
        videos.Add(video3);

        foreach (var video in videos) {
            video.DisplayInfo();
        }
    }
}