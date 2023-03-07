using System; 

public class Resume {
    public string _name = "";

    public List<Jobs> _job = new List<Jobs>(); 
     
    public void Display() {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs: "); 

        foreach(Jobs job in _job) {
            
            job.DisplayJobInformation();
        }
     }

    

}
