using System;

class Program
{
    static void Main(string[] args)
    {
        Comment superman1 = new Comment("Ovinson", "That trailer was awesome!");
        Comment superman2 = new Comment("Abel", "The best superhero trailer I've seen in years!");
        Comment superman3 = new Comment("Cain", "It could have been better\n");

        Comment sonic1 = new Comment("Ovi", "I think it was worth the time");
        Comment sonic2 = new Comment("Princess", "I fell asleep while watching it");
        Comment sonic3 = new Comment("MiBeb", "I think it's more for kids so I want to watch it\n");

        Comment theAgency1 = new Comment("Bebis", "I just wanted to change it and watch BabyShark"); 
        Comment theAgency2 = new Comment("Carolyn", "I haven't watched it but it looks good"); 
        Comment theAgency3 = new Comment("Leovi", "I'll try and watch it when I get home today, it looks sick!\n"); 

        Video video1 = new Video("Superman Trailer", "DC Comics", 150);
        video1._comments.Add(superman1);
        video1._comments.Add(superman2);
        video1._comments.Add(superman3);

        Video video2 = new Video("Sonic Trailer", "Trailer Entertainment", 200);
        video2._comments.Add(sonic1);
        video2._comments.Add(sonic2);
        video2._comments.Add(sonic3);
        
        Video video3 = new Video("The Agency Trailer", "Show Time", 250);
        video3._comments.Add(theAgency1);
        video3._comments.Add(theAgency2);
        video3._comments.Add(theAgency3);

        static void displayVideoInfo(Video video)
        {
            Console.WriteLine($"{video._title}\nThis video was posted by {video._author} and it is {video._length} seconds long.\nComments:");
            Console.WriteLine($"There is a total of {video.NumberOfComments()} comments\n");
            foreach (Comment comment in video._comments)
            {
                Console.WriteLine(comment.CommentInfo());
            }
        }

        displayVideoInfo(video1);
        displayVideoInfo(video2);
        displayVideoInfo(video3);
    }
}