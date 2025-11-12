string[] input = Console.ReadLine().Split(' ');
var A = double.Parse(input[0]);
var B = double.Parse(input[1]);
var C = double.Parse(input[2]);
const double pi = 3.14159;

var a = .5 * A * C;
var b = pi * C * C;
var c = ((A + B) * C) / 2;
var d = B * B;
var e = A * B;

Console.WriteLine($"TRIANGULO: {a:F3}");
Console.WriteLine($"CIRCULO: {b:F3}");
Console.WriteLine($"TRAPEZIO: {c:F3}");
Console.WriteLine($"QUADRADO: {d:F3}");
Console.WriteLine($"RETANGULO: {e:F3}");
