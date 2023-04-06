using System;

public class Comment 
{ 
    public string _commentName;
    public string _commentText;

    public Comment(string commentName, string commentText)
    {
        _commentName = commentName;
        _commentText = commentText;

    }

    public void Display()
    {
      Console.WriteLine($"{_commentName}: {_commentText}");
    }
    

     

}