using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args){

            // For loop
            Console.WriteLine("For loop");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            // Do While loop
            Console.WriteLine("Do While loop");


            int age = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine(age);
                age--;
            } while (age > 18);


            // Foreach loop
            Console.WriteLine("Foreeach loop");

            int[] number = new int[] {2,4,6,8,10};

            foreach (var item in number)
            {
                Console.WriteLine(item);
            }
        }
        
    }
}
