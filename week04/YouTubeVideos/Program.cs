
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video("Learning C#", "Code Academy", 600);
        v1.AddComment(new Comment("Alice", "Very helpful!"));
        v1.AddComment(new Comment("Bob", "Loved this explanation."));
        v1.AddComment(new Comment("Chris", "Clear and simple."));

        Video v2 = new Video("OOP Basics", "Dev School", 480);
        v2.AddComment(new Comment("Dana", "Great intro."));
        v2.AddComment(new Comment("Eli", "Nice examples."));
        v2.AddComment(new Comment("Faith", "Thanks for this."));

        Video v3 = new Video("Abstraction Explained", "Tech World", 720);
        v3.AddComment(new Comment("George", "Exactly what I needed."));
        v3.AddComment(new Comment("Hannah", "Well explained."));
        v3.AddComment(new Comment("Ian", "Good pacing."));

        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}
