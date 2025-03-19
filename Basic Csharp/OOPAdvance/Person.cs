using OOPAdvance;

namespace Namespace;
public abstract class Person : IPerson
{
    public string FirstName {get; set;}
    public string LastName{get; set;}

    public string Id{
        get{
            return GetId();
        }
    }

    public string Address { get; set; }

    protected int[] grades;

    public Person(int size){
        grades = new int[size];
    }
    ~Person(){ // Finalizer...
        grades = new int[0 ]; 
    }

    public void SetGrades(int[] grades){
        this.grades = grades;
    }

    public abstract string GetId();

    public abstract void Talk(string message);

    public abstract void SetAddress(string address);
}
