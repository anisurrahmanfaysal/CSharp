namespace MyApp;
public class Person
{
    public string firstName;
    public string lastName;

// Empty Constructor
    public Person(){
        firstName = string.Empty;
        lastName = string.Empty;
    }

// Paremeterized constructor
    public Person(string firstName, string lastName){    // Constructor overloding
        this.firstName = firstName;
        this.lastName = lastName;
    }

    public string GetName(string seperator){
        return firstName + seperator + lastName;
    }

    public string GetName(string[] seperator){  // Method Overloding
        return firstName + seperator[0] + lastName;
    }
}
