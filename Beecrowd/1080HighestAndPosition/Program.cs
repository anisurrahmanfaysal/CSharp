var height = 0;
var position = 0;
for (int i = 1; i < 101; i++)
{
    var input = int.Parse(Console.ReadLine());
    if (input > height)
    {
        height = input;
        position = i;
    }
}

Console.WriteLine(height);
Console.WriteLine(position);
