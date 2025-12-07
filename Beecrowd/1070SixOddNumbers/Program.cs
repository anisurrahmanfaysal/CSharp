var input = int.Parse(Console.ReadLine());

for (int i = input; i < input + 12; i++)
{
    if(i %  2 == 1)
        Console.WriteLine(i);
}