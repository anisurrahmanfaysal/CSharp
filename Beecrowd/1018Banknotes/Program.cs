var notes = int.Parse(Console.ReadLine());
Console.WriteLine(notes);

var a = notes / 100;
Console.WriteLine($"{a} nota(s) de R$ 100,00");
notes = notes %  100;

a = notes / 50;
Console.WriteLine($"{a} nota(s) de R$ 50,00");
notes = notes % 50;

a = notes / 20;
Console.WriteLine($"{a} nota(s) de R$ 20,00");
notes = notes % 20;

a = notes / 10;
Console.WriteLine($"{a} nota(s) de R$ 10,00");
notes = notes % 10;

a = notes / 5;
Console.WriteLine($"{a} nota(s) de R$ 5,00");
notes = notes % 5;

a = notes / 2;
Console.WriteLine($"{a} nota(s) de R$ 2,00");
notes = notes % 2;

Console.WriteLine($"{notes} nota(s) de R$ 1,00");