using System;
using MyApp;

// namespace MyApp

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Anisur", "Faysal");
            // person.firstName = "Anisur";
            // person.lastName = "Faysal";
            
            string name = person.GetName(" ");

            Console.WriteLine(name);

            Person person2 = new Person("Nishat", "Shoshi");
            person2.FirstName = "Nishat";
            person2.LastName = "Shoshi";

            string name2 = person2.GetName(new string[] {" "});
            Console.WriteLine(name2);

            Console.WriteLine(person2.FullName);
        }
    }

