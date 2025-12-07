var N = int.Parse(Console.ReadLine());


int inCount = 0;
int outCount = 0;

for (int i = 0; i < N; i++)
{
    int value = int.Parse((Console.ReadLine()));

    if (value >= 10 && value <= 20)
        inCount++;
    else
        outCount++;
}

Console.WriteLine($"{inCount} in");
Console.WriteLine($"{outCount} out");
