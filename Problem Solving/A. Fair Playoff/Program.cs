//Practicing

int games = Convert.ToInt16(Console.ReadLine());

for (int i = 0; i < games; i++)
{
    int a = Convert.ToInt16(Console.ReadLine());
    int b = Convert.ToInt16(Console.ReadLine());
    int c = Convert.ToInt16(Console.ReadLine());
    int d = Convert.ToInt16(Console.ReadLine());

    int max1 = Math.Max(a, b);
    int min1 = Math.Min(a, b);
    int max2 = Math.Max(c, d);
    int min2 = Math.Min(c, d);

    if (max1 < min2 || max2 < min1)
    {
        Console.WriteLine("NO");
    }
    else
    {
        Console.WriteLine("YES");
    }
}