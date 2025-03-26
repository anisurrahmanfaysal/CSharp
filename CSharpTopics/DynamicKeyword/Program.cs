// See https://aka.ms/new-console-template for more information
Console.WriteLine("Dynamic keyword");

object o = new { Name = "Faysal", age = 27 };

dynamic d = o;
Console.WriteLine(d.Name);