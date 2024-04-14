int number1 = Convert.ToInt16(Console.ReadLine());
int number2 = Convert.ToInt16(Console.ReadLine());
int number3 = Convert.ToInt16(Console.ReadLine());

int sum = number1 + number2 + number3;

double avg = (double)sum/3;

System.Console.WriteLine("Number1 = "+number1);
System.Console.WriteLine("Number2 = "+number2);
System.Console.WriteLine("Number3 = "+number3);

Console.WriteLine("Avg = "+avg.ToString("F2"));