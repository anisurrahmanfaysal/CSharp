var N = int.Parse(Console.ReadLine());

for (int i = 0; i < N; i++)
{
    string[] input = Console.ReadLine().Split(' ');
    var n1 = float.Parse(input[0]);
    var n2 = float.Parse(input[1]);
    var n3 = float.Parse(input[2]);

    var weight = (n1 * 2 + n2 * 3 + n3 * 5) / 10;
    Console.WriteLine(weight.ToString("F1"));
}

