var sum = 0.0;
var count = 0;

for (int i = 0;; i++)
{
    var input = float.Parse(Console.ReadLine());

    if (input <= 10 && input >= 0)
    {
        sum += input;
        count++;
        
    }
    else
    {
        Console.WriteLine("nota invalida");
    }

    Console.WriteLine($"media = {sum/2}");
    if (count == 2)
        break;
}
