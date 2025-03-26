// See https://aka.ms/new-console-template for more information
using GenericsExample;

Console.WriteLine("GenericsExample");

Coordinate<int, double> c  = new Coordinate<int, double>();

c.X = 1;
c.Y = 2;

Coordinate<string, float> c2  = new Coordinate<string, float>();

c2.X = "4";
c2.Y = 24.5f;