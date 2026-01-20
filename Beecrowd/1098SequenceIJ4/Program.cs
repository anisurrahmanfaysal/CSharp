for (int i = 0; i <= 20; i+=2)
{
    double I = i / 10.0;

    for (int j = 1; j <= 3; j++)
    {
        double J = I + j;
        if(i % 10  == 0)
            Console.WriteLine($"I={(int)I} J={(int)J}");
        else
            Console.WriteLine($"I={I:F1} J={J:F1}");
    }
}
