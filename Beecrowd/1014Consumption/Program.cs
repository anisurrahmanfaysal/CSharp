int distance = int.Parse(Console.ReadLine());
double fuel = double.Parse(Console.ReadLine());

var fuelPerKM = distance / fuel;

Console.WriteLine($"{fuelPerKM:F3} km/l");
