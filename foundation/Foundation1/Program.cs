using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("LTT Store Walkthrough", "LTT", 765);
        video1.AddComment(new Comment("Dan", "Love it! Buying now!"));
        video1.AddComment(new Comment("Ethan", "Where's the banana for scale?!"));
        video1.AddComment(new Comment("Linus", "Now, enjoy this segue... To our sponsor!"));

        Video video2 = new Video("Google Pixel Demo", "Google", 540);
        video2.AddComment(new Comment("Annie", "OOh, the AI camera features are cool."));
        video2.AddComment(new Comment("Evin", "Can it run Minecraft?"));
        video2.AddComment(new Comment("Steve J", "Boo, should have bought an iPhone :("));

        Video video3 = new Video("Slow Motion Everything", "Slo Mo Guys", 880);
        video3.AddComment(new Comment("Edith", "Woah, slow motion is cooler than i thought."));
        video3.AddComment(new Comment("James", "Can you show fireworks in slo mo next?"));
        video3.AddComment(new Comment("Malcolm", "Dang, wish my camera was this fast."));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
            Console.WriteLine();
        }
    }
}