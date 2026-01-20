for (int i = 0;; i++)
{
    string[] input = Console.ReadLine().Split(' ');
    var x = int.Parse(input[0]);
    var y = int.Parse(input[1]);
    if (x == 0 || y == 0)
        return;
    else if(x >  0 && y > 0)
        Console.WriteLine("primeiro");
    else if (x > 0 && y < 0)
        Console.WriteLine("quarto");
    else if (x < 0 && y < 0)
        Console.WriteLine("terceiro");
    else if (x < 0 && y > 0)
        Console.WriteLine("segundo");
}