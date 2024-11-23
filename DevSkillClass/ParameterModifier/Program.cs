using ParameterModifier;

Console.WriteLine("Hello, World!");

Geometry geometry = new Geometry();

double[] items = [3.5,2.2,3.3];

geometry.CalculateAverage(items);
geometry.CalculateAverage(2.2,3.3,4.4);

int m = 5;
geometry.Calculate(ref m);
Console.WriteLine(m);

int x;
int y;
int z;
geometry.Calculate3(out x,out y,out z);

Console.WriteLine($"X :{x}, Y:{y}, Z:{z}");