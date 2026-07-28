using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("The Power of Habit", "Charles Duhigg", 600);
        Video video2 = new Video("Being Stronger", "John Doe", 450);
        Video video3 = new Video("Jesus Christ", "Jane Smith", 300);

        Comment comment1 = new Comment("Alice", "Great video! Very informative.");
        Comment comment2 = new Comment("Bob", "I learned a lot from this video.");
        Comment comment3 = new Comment("Charlie", "Thanks for sharing this!");
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        Comment comment5 = new Comment("Eve", "This video is amazing!");
        Comment comment6 = new Comment("Frank", "I really enjoyed watching this.");
        Comment comment7 = new Comment("Grace", "Very helpful content.");
        video2.AddComment(comment5);
        video2.AddComment(comment6);
        video2.AddComment(comment7);

        Comment comment9 = new Comment("Hannah", "This video is very inspiring.");
        Comment comment10 = new Comment("Ian", "I appreciate the insights shared in this video.");
        Comment comment11 = new Comment("Jack", "This video is a must-watch!");    
        video3.AddComment(comment9);
        video3.AddComment(comment10);
        video3.AddComment(comment11);    

        List<Video> videos = new List<Video> { video1, video2, video3 };
        foreach (Video video in videos)
        {
            video.DisplayVideoInfo();
            Console.WriteLine();
        }

    }
}