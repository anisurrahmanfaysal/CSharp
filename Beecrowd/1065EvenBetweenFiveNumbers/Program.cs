var isPositive = 0;

for (int i = 0; i < 5; i++)
{
    var input = int.Parse(Console.ReadLine());

    if (input % 2 == 0)
        isPositive++;
}

Console.WriteLine($"{isPositive} valores pares");
