string[] input = Console.ReadLine().Split(' ');

var x = int.Parse(input[0]);
var y = int.Parse(input[1]);
var z = int.Parse(input[2]);

int[] original = { x, y, z };
int[] sorted = (int[])original.Clone();

Array.Sort(sorted);

foreach (var item in sorted)
{
    Console.WriteLine(item);
}

Console.WriteLine();

foreach (var item in original)
{
    Console.WriteLine(item);
}