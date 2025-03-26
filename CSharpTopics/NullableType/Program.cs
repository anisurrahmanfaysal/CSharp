// See https://aka.ms/new-console-template for more information
Console.WriteLine("Nullable Type");

int? x = 5;
string? s = null;
Console.WriteLine(s);

if (x.HasValue)
    Console.WriteLine(x.Value);

