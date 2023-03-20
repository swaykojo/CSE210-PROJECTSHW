using System; 

public class PictureBook: Book
{
    private string _Illustrator; 

    public PictureBook (string Title, string Author, string Illustrator) : base(Title, Author)
    { 
        _Illustrator = Illustrator;

    }
    public string GetIllustrator() 
    { 
       return _Illustrator;
    } 

    public void SetIllustrator(string Illustrator) 
    {
       _Illustrator = Illustrator;
    } 

    public string GetPictureBookInfo() 
    {
       return $"{GetTitle()} by {GetAuthor()} illustrated by {_Illustrator}";
    }

} 
