(int age, string name) x = (5, "Hello");
Console.WriteLine(x.age);
Console.WriteLine(x.name);

(int, double) Calculate(int[] items)
{
    var sum = 0;

    foreach (var item in items)
    {
        sum += item;
    }

    var average = (sum/ items.Length);
    return (sum, average);
}

(int, string)[] perosnInfo = [(23, "Khan"), (33, "Chowdery")];


