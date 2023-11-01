using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Anisur", "Faysal");
            // person.firstName = "Anisur";
            // person.lastName = "Faysal";
            
            string name = person.GetName(" ");

            Console.WriteLine(name);

            Person person2 = new Person();
            person2.firstName = "Nishat";
            person2.lastName = "Shoshi";

            string wifeName = person2.GetName(" ");
            Console.WriteLine(wifeName);

        }
    }
}
