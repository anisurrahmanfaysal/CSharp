float inpute = float.Parse(Console.ReadLine());

if (inpute >= 0 && inpute <= 25)
    Console.WriteLine("Intervalo [0,25]");
else if (inpute > 25 && inpute <= 50)
    Console.WriteLine("Intervalo (25,50]");
else if (inpute > 50 && inpute <= 75)
    Console.WriteLine("Intervalo (50,75]");
else if (inpute > 75 && inpute <= 100)
    Console.WriteLine("Intervalo (75,100]");
else
    Console.WriteLine("Fora de intervalo");
