var even = 0;
var odd = 0;
var positive = 0;
var negative = 0;

for (int i = 0; i < 5; i++)
{
    var input = int.Parse(Console.ReadLine());

    if (input % 2 == 0)
        even++;
    if(input % 2 != 0 )
        odd++;
    if (input > 0)
        positive++;
    if(input < 0)
        negative++;
}

Console.WriteLine($"{even} valor(es) par(es)");
Console.WriteLine($"{odd} valor(es) impar(es)");
Console.WriteLine($"{positive} valor(es) positivo(s)");
Console.WriteLine($"{negative} valor(es) negativo(s)");
