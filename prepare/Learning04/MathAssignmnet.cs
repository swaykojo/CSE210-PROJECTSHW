using System; 

public class MathAssignment : Assignment
{  
    public MathAssignment(string studentName, string topic, string textbooksection, string problems) : base(studentName, topic)
    {
        _textbooksection = textbooksection;
        _problems = problems;

    }
    private string _textbooksection; 
    private string _problems; 

    public string GetTextBookSection()
    {
       return _textbooksection;
    } 

    public void SetTextBookSection(string textbooksection) 
    {
       _textbooksection = textbooksection;
    } 

    public string GetProblems() 
    {
       return _problems;
    } 

    public void SetProblems(string problems) 
    {
       _problems = problems;
    } 

    public string GetHomeworkList()
    {
       return $"{GetStudentName()} - {GetTopic()} \nSection {_textbooksection} Problems {_problems}";
    }

}