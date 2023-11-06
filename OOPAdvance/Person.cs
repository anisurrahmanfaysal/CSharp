namespace Namespace;
public class Person
{
    public string FirstName {get; set;}
    public string LastName{get; set;}

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
}
