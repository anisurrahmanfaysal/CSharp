int number = int.Parse(Console.ReadLine());
int hour = int.Parse(Console.ReadLine());
float amount = float.Parse(Console.ReadLine());

var salary = hour * amount;

Console.WriteLine("NUMBER = " + number);
Console.WriteLine("SALARY = U$ " + salary.ToString("F2"));