namespace Namespace;
public class Student : Person
{
    private const string _idPrefix = "S-";
    private readonly int _id = 0;
    public Student(int id) : base(100)
    {
        _id = id;
    }

    public string GetStudentId(){
        return _idPrefix + _id;
    }

    public double CalculateCgpa(){
        var cgpa = 0;
        
        foreach (var item in grades)
        {
            cgpa += item;
        }

        return cgpa / grades.Length;
    }
}
