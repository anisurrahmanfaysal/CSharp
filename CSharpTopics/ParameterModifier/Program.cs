// See https://aka.ms/new-console-template for more information
using ParameterModifier;

Console.WriteLine("Parameter Modifier");

Geometry geometry = new Geometry();

double[] items = [3.5, 4.4];
geometry.CalculateAverage(items);
geometry.CalculateAverage(3.3,4.4,5.5,.5);

int m = 5;
geometry.Calculate(ref m);
Console.WriteLine(m);

int x;
int y;
int z;
geometry.Calculate3(out x, out y, out z);
Console.WriteLine($"X: {x}, Y:{y}, Z:{z}");