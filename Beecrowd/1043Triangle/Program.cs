string[] input = Console.ReadLine().Split(' ');

var A = float.Parse(input[0]);
var B = float.Parse(input[1]);
var C = float.Parse(input[2]);

if (A < B + C &&  B < C + A &&  C < B + A)
{
    Console.WriteLine("Perimetro = "+ (A+B+C).ToString("F1"));
}
else
{
    var y = ((A+B)*C) / 2;
    Console.WriteLine($"Area = {y:F1}");
}