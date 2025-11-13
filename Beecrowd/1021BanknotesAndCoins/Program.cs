var value = double.Parse(Console.ReadLine());
int notes = (int)(value*100+.5);

int count = 0;
int[] banknotes = { 10000,5000,2000,1000,500,200};
int[] coins = { 100, 50, 25, 10, 5, 1};

Console.WriteLine("NOTAS:");
for (int i = 0; i < banknotes.Length; i++)
{
    count = (int)notes / banknotes[i];
    Console.WriteLine($"{count:F0} nota(s) de R$ {banknotes[i]/100.0}.00");
    notes %= banknotes[i];
}

Console.WriteLine($"MOEDAS:");
for (int i = 0; i < coins.Length; i++)
{
    count = (int)(notes / coins[i]);
    Console.WriteLine($"{count:F0} moeda(s) de R$ {coins[i]/100.0:F2}");
    notes %= coins[i];
}
















//double a = (int)notes / 100;
//Console.WriteLine($"{a:F0} nota(s) de R$ 100.00");
//notes = notes % 100;

//a = (int)notes / 50;
//Console.WriteLine($"{a:F0} nota(s) de R$ 50.00");
//notes = notes % 50;

//a = (int)notes / 20;
//Console.WriteLine($"{a:F0} nota(s) de R$ 20.00");
//notes = notes % 20;

//a = (int)notes / 10;
//Console.WriteLine($"{a:F0} nota(s) de R$ 10.00");
//notes = notes % 10;

//a = (int)notes / 5;
//Console.WriteLine($"{a:F0} nota(s) de R$ 5.00");
//notes = notes % 5;

//a = (int)notes / 2;
//Console.WriteLine($"{a:F0} nota(s) de R$ 2.00");
//notes = notes % 2;

//a = (int)notes / 1;
//Console.WriteLine($"{a:F0} moeda(s) de R$ 1.00");
//notes = notes % 1;

//a = (int)(notes / .50);
//Console.WriteLine($"{a:F0} moeda(s) de R$ 0.50");
//notes = notes % .50;

//a = (int)(notes / .25);
//Console.WriteLine($"{a:F0} moeda(s) de R$ 0.25");
//notes = notes % .25;

//a = (int)(notes / .10);
//Console.WriteLine($"{a:F0} moeda(s) de R$ 0.10");
//notes = notes % .10;

//a = (int)(notes / .05);
//Console.WriteLine($"{a:F0} moeda(s) de R$ 0.10");
//notes = notes % .05;

//a = (int)(notes / .01);
//Console.WriteLine($"{a:F0} moeda(s) de R$ 0.10");
