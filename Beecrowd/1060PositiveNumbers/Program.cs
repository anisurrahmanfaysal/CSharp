var positiveNumbers = 0;

for (int i = 0; i < 6; i++)
{
    var input = double.Parse(Console.ReadLine());
    if(input >=0)
        positiveNumbers++;
}

Console.WriteLine($"{positiveNumbers} valores positivos");