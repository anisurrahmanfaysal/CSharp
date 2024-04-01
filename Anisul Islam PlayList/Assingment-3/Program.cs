using System.Runtime.InteropServices;

Console.WriteLine($"Assignment-3");

Console.Write($"Enter your name : ");
string? studentName = Console.ReadLine();

Console.Write($"Enter your age : ");
int? studentAge = Convert.ToInt32(Console.ReadLine());

Console.Write($"Enter your CGPA : ");
double? studentCgpa = Convert.ToDouble(Console.ReadLine());

Console.Write($"Registration Status : ");
bool? isRegisterd = Convert.ToBoolean(Console.ReadLine());

Console.WriteLine($"Name: " + studentName);
Console.WriteLine($"Student age: " + studentAge + "years old.");
Console.WriteLine($"CGPA: " + studentCgpa);
Console.WriteLine($"Registration Status : "+isRegisterd);


