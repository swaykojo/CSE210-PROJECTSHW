using System;

public class Video
{ 
    public string _title; 

    public string _author;

    public string _length;


    public List<Comment> listOfComments = new List<Comment>();


    public void DisplayVedio()
    {   
        Console.WriteLine();
        Console.WriteLine($"The title of the video is {_title}, the author is {_author} and the video is {_length} long");
        Console.WriteLine($"Number of comments: {listOfComments.Count}");
        Console.WriteLine("Comments:");
        foreach(Comment comment in listOfComments)
        {
            comment.Display();
        }
    }


    






}