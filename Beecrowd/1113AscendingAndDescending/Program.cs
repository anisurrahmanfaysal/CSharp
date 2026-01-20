for (int i = 0;; i++)
{
    string[] input = Console.ReadLine().Split(' ');
    var X = int.Parse(input[0]);
    var Y = int.Parse(input[1]);

    if (X == Y)
        return;
    else if (X > Y)
        Console.WriteLine("Decrescente");
    else if (Y > X)
        Console.WriteLine("Crescente");
}