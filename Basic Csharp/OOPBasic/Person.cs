namespace MyApp;
public class Person
{
    // Filds...
    string firstName;
    public string LastName { get; set;}   // Auto Properties

    // Property FirstName
    public string FirstName
    {
        get{
            if(string.IsNullOrWhiteSpace(FirstName))
                return string.Empty;

            return firstName;
        }
        set{
            if (!string.IsNullOrWhiteSpace(value))
                firstName = value;
            
        }
    }

    public string FullName
    {
        get{
            return firstName + " " + LastName;
        }
    }

// Empty Constructor
    public Person() : this(string.Empty, string.Empty)  // Constructor chining
    {
        
    }

// Paremeterized constructor
    public Person(string firstName, string lastName){    // Constructor overloding
        this.firstName = firstName;
        this.LastName = lastName;
    }

    public string GetName(string seperator){
        return firstName + seperator + LastName;
    }

    public string GetName(string[] seperator){  // Method Overloding
        return GetName(seperator[0]);
    }
}
