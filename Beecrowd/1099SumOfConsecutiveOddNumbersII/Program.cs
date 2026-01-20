var testNo = int.Parse(Console.ReadLine());

for (int i = 0; i < testNo; i++)
{
    string[] input = Console.ReadLine().Split(' ');
    var X = int.Parse(input[0]);
    var Y = int.Parse(input[1]);

    if (X > Y)
    {
        var temp = X;
        X = Y; 
        Y = temp;
    }

    var totalOdd = 0;
    for (var j = X+1; j < Y; j++)
    {
        if (j % 2 != 0)
            totalOdd += j;
    }
    Console.WriteLine(totalOdd);
}

