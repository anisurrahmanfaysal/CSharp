// See https://aka.ms/new-console-template for more information
Console.WriteLine("Tuple example");

(int age, string name) x = (27, "Faysal");
Console.WriteLine(x.Item1);
Console.WriteLine(x.Item2);

Console.WriteLine(x.age);
Console.WriteLine(x.name);

(int, double) Calculate(int[] items)
{
    var sum = 0;
    foreach (var item in items)
    {
        sum += item;
    }
    var average = (sum / items.Length);

    return (sum, average);
}

(int, string)[] personalInfo = [(23, "Hasan"), (33, "Tareq")];