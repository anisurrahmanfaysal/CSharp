var notes = double.Parse(Console.ReadLine());

Console.WriteLine("NOTAS:");

double a = notes / 100;
Console.WriteLine($"{a:F0} nota(s) de R$ 100.00");
notes = notes % 100;

a = notes / 50;
Console.WriteLine($"{a:F0} nota(s) de R$ 50.00");
notes = notes % 50;

a = notes / 20;
Console.WriteLine($"{a:F0} nota(s) de R$ 20.00");
notes = notes % 20;

a = notes / 10;
Console.WriteLine($"{a:F0} nota(s) de R$ 10.00");
notes = notes % 10;

a = notes / 5;
Console.WriteLine($"{a:F0} nota(s) de R$ 5.00");
notes = notes % 5;

a = notes / 2;
Console.WriteLine($"{a:F0} nota(s) de R$ 2.00");
notes = notes % 2;

Console.WriteLine($"MOEDAS:");

a = notes / 1;
Console.WriteLine($"{a:F0} moeda(s) de R$ 1.00");
notes = notes % 1;

a = notes / .50;
Console.WriteLine($"{a:F0} moeda(s) de R$ 0.50");
notes = notes % .50;

a = notes / .25;
Console.WriteLine($"{a:F0} moeda(s) de R$ 0.25");
notes = notes % .25;

a = notes / .10;
Console.WriteLine($"{a:F0} moeda(s) de R$ 0.10");
notes = notes % .10;

a = notes / .05;
Console.WriteLine($"{a:F0} moeda(s) de R$ 0.10");
notes = notes % .05;

a = notes / .01;
Console.WriteLine($"{a:F0} moeda(s) de R$ 0.10");
notes = notes % .01;
