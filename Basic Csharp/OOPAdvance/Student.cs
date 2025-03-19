using OOPAdvance;

namespace Namespace;
public class Student : Person , IPerson
{
    private const string _idPrefix = "S-";
    private readonly int _id = 0;
    private string address;
    public Student(int id) : base(100)
    {
        _id = id;
    }

    

    public double CalculateCgpa(){
        var cgpa = 0;
        
        foreach (var item in grades)
        {
            cgpa += item;
        }

        return cgpa / grades.Length;
    }

    public override string GetId()
    {
        return _idPrefix + _id;    
    }

    public void SetAddress(string address)
    {
        this.address = address;
    }

    public void Talk(string message)
    {
        Console.WriteLine(message);
    }
}
