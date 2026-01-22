while (true)
{
    var sum = 0.0;
    var count = 0;

    for (int i = 0; ; i++)
    {
        var input = float.Parse(Console.ReadLine());

        if (input <= 10 && input >= 0)
        {
            sum += input;
            count++;
        }
        else
            Console.WriteLine("nota invalida");

        if (count == 2)
        {
            var avg = sum / 2;
            Console.WriteLine($"media = {avg:F2}");
            break;
        }
    }

    int option;
    while (true)
    {
        Console.WriteLine("novo calculo (1-sim 2-nao)");
        option = int.Parse(Console.ReadLine());

        if (option == 1 || option == 2)
            break;
    }

    if (option == 2)
        break;
}
