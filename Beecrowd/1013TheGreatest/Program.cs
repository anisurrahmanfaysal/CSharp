string[] input = Console.ReadLine().Split(' ');

int a = int.Parse(input[0]);
int b = int.Parse(input[1]);
int c = int.Parse(input[2]);

int MaiorAB = (a + b + Math.Abs(a - b)) / 2;
int MaiorABC = (MaiorAB + c + Math.Abs(MaiorAB -c )) / 2;
Console.WriteLine($"{MaiorABC} eh o maior");