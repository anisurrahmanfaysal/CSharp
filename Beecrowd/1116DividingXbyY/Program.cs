var input = int.Parse(Console.ReadLine());

for (int i = 0; i < input; i++)
{
    string[] inputs = Console.ReadLine().Split(' ');
    var X = int.Parse(inputs[0]);
    var Y = int.Parse(inputs[1]);

    if(Y == 0)
        Console.WriteLine("divisao impossivel");
    else
    {
        double result = (double)X / Y;
        Console.WriteLine(result.ToString("F1"));
    }
        
}