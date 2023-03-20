using System;

public class Book {
    private string _Title;
    private string _Author; 
 
 public Book (string Title, string Author) 
 {
    _Title = Title; 
    _Author = Author;

 }
    public string GetTitle() {
        return _Title;
    } 

    public void SetTitle(string Title) {
        _Title = Title;
    } 

    public string GetAuthor() {
        return _Author;  
    } 

    public void SetAuthor(string Author){
        _Author = Author;
    }  

    public string GetBookInfo() {
        return $"{_Title} by {_Author}";
    }

}