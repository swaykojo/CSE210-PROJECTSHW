using System;

class Program
{
    static void Main(string[] args)
    {
      

       
        Video video1 = new Video();
        Video video2 = new Video();
        Video video3 = new Video();

        for (int i = 0; i < 4; i++)
        {
            Comment comment1 = new Comment($"name{i}", "Why is this instructor underrated? I'm telling you he is awesome.");
            video1.listOfComments.Add(comment1);
            Comment comment2 = new Comment($"name{i}", "This was one of the most beautiful and satisfying  learning experince I have had.");
            video2.listOfComments.Add(comment2);
            Comment comment3 = new Comment($"name{i}", "I love and sustain Elder Bednar, such a wonderdul talk!");
            video3.listOfComments.Add(comment3);
            
        }


        video1._title = "Instruction C#";
        video1._author = "Mike Dane";
        video1._length = "20 mintues";
        
        video2._title = "Learn HTML & CSS";
        video2._author = "Per Harald Borgen";
        video2._length = "5 hours";

     
        video3._title="But We Heeded Them Not";
        video3._author = "David A. Bednar";
        video3._length ="12:58 minutes";


        List<Video> info = new List<Video>();
        info.Add(video1);
        info.Add(video2);
        info.Add(video3);


        foreach (Video textinfo in info)
        {
            textinfo.DisplayVedio();
        }


    }
}