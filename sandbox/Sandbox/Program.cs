using System;

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person(); 
        person._givenName = "Godsway";
        person._familyName = "Awuah";
        person.ShowWesternName();
        person.ShowEasternName(); 

        Person person1 = new Person(); 
        person1._givenName = "Emma";
        person1._familyName = "Smith"; 
        person1.ShowWesternName();
    }
}