var positiveCount = 0;
double sum = 0;

for (int i = 0; i < 6; i++)
{
    var value = double.Parse(Console.ReadLine());
    if(value > 0)
    {
        positiveCount++;
        sum += value;
    }
}

double avg = sum/ positiveCount;

Console.WriteLine($"{positiveCount} valores positivos");
Console.WriteLine(avg.ToString("F1"));

