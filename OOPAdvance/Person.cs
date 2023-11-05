namespace Namespace;
public class Person
{
    private int[] grades;

    public Person(int size){
        grades = new int[size];
    }
    ~Person(){ // Finalizer...
        grades = new int[0 ]; 
    }
}
