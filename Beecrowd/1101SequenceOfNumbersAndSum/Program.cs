for (int i = 0;; i++)
{
    string[] input = Console.ReadLine().Split(' ');
    var M = int.Parse(input[0]);
    var N = int.Parse(input[1]);

    if( M <= 0 || N <= 0)
        return;

    int start = Math.Min(M, N);
    int end = Math.Max(M, N);
    int sum = 0;

    for (int j = start; j <= end; j++)
    {
        Console.Write( j + " ");
        sum += j;
    }
    Console.WriteLine("Sum="+ sum);
}