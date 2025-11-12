var totalDays = int.Parse(Console.ReadLine());

var years = totalDays / 365;
totalDays = totalDays % 365;

var months = totalDays / 30;
totalDays = totalDays % 30;

Console.WriteLine($"{years} ano(s)");
Console.WriteLine($"{months} mes(es)");
Console.WriteLine($"{totalDays} dia(s)");
