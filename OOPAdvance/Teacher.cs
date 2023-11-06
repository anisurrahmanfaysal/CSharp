namespace Namespace;
public class Teacher : Person
{
    public int Salary {get; set;}
    public Teacher(int size) : base(0)
    {
        
    }

    public int CalculateBonus( int percent){
        return Salary * percent / 100;
    }
}
