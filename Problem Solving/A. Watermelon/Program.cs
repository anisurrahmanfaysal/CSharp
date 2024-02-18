int w = Convert.ToInt32(Console.ReadLine());
if (w >= 1 && w <= 100)
{
    if (w == 2)
        Console.WriteLine("NO");
    else if (w % 2 == 0)
    {
        Console.WriteLine("YES");
    }
    else
    {
        Console.WriteLine("NO");
    }
}