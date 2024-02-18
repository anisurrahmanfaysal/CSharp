using System;

namespace condition;
class TestClass
{
    static void Main(string[] args)
    {
        int age = Convert.ToInt32(Console.ReadLine());


        // if conditional statement.
        if (age > 25){
            Console.WriteLine("Age lessthan 25");
        }
        else if(age == 25){
            Console.WriteLine("Age is 25");
        }
        else{
            Console.WriteLine("Age is gather than 25");
        }

        //switch case conditional statement.

        switch (age)
        {
            case 5:
                Console.WriteLine("Age is 5");
                break;
            case 30:
                Console.WriteLine("Age is 30");
                break;
            default:
                Console.WriteLine("Cute baby!");
                break;
        }

        // Ternary Condition? True value : False value;
    
        string isAge = age>5? "Grater than 5" : "Less than 5";
        Console.WriteLine(isAge);
        
    }
}
