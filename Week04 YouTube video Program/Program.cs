using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("C# Object-Oriented Programming Tutorial", "CodeAcademy", 600);
        video1.AddComment(new Comment("Alice", "This cleared up classes for me completely!"));
        video1.AddComment(new Comment("Bob", "Great pacing and clear examples. Thanks!"));
        video1.AddComment(new Comment("Charlie", "Can you make a follow-up on inheritance?"));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("Top 10 Productivity Tips for Developers", "TechWise", 450);
        video2.AddComment(new Comment("Diana", "Tip #4 saved my entire workflow."));
        video2.AddComment(new Comment("Ethan", "Very practical advice, subscribing right now."));
        video2.AddComment(new Comment("Fiona", "I needed to hear this today."));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("Cinematic Color Grading in Premiere Pro", "VisualsByDesign", 920);
        video3.AddComment(new Comment("George", "The Lumetri color breakdown is gold."));
        video3.AddComment(new Comment("Hannah", "Your editing style is incredible!"));
        video3.AddComment(new Comment("Ian", "Subbed! Looking forward to more tutorials."));
        videos.Add(video3);

        // Video 4
        Video video4 = new Video("Lo-Fi Beats to Relax and Code To", "ChillBeats", 3600);
        video4.AddComment(new Comment("Julia", "Been listening to this on loop all day."));
        video4.AddComment(new Comment("Kevin", "Absolute vibe. Perfect for coding sessions."));
        video4.AddComment(new Comment("Laura", "Thank you for creating this playlist."));
        videos.Add(video4);

        // Iterate and display all video details and comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  - {comment.GetCommenterName()}: {comment.GetText()}");
            }

            Console.WriteLine(new string('-', 40));
        }
    }
}
