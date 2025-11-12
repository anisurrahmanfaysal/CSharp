var R = float.Parse(Console.ReadLine());
const double pi = 3.14159;

var volume = (4 / 3.0) * pi * R * R * R;

Console.WriteLine($"VOLUME = {volume:F3}");