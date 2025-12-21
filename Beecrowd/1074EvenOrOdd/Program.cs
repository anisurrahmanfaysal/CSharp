var numbers = int.Parse(Console.ReadLine());

for (int i = 0; i < numbers; i++)
{
    var input = int.Parse(Console.ReadLine());

    if(input > 0)
    {
        if(input % 2 == 0)
            Console.WriteLine("EVEN POSITIVE");
        if (input % 2 != 0)
            Console.WriteLine("ODD POSITIVE");
    }
    else if(input < 0)
    {
        if (input % 2 == 0)
            Console.WriteLine("EVEN NEGATIVE");
        if (input % 2 != 0)
            Console.WriteLine("ODD NEGATIVE");
    }
    else
        Console.WriteLine("NULL");
}