// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("String Builder");

StringBuilder stringBuilder = new StringBuilder("I'm from Narshingdi");
stringBuilder = stringBuilder.Append(" and I love programming.");
stringBuilder = stringBuilder.AppendLine("My name is Faysal");

stringBuilder = stringBuilder.Replace('a','x');
stringBuilder = stringBuilder.Insert(10,"www");
stringBuilder = stringBuilder.Remove(10, 3);
stringBuilder = stringBuilder.Replace('x', 'a');


Console.WriteLine(stringBuilder.ToString());
