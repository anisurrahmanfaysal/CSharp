string[] line1 = Console.ReadLine().Split(' ');
var x1 = double.Parse(line1[0]);
var y1 = double.Parse(line1[1]);

string[] line2 = Console.ReadLine().Split(' ');
var x2 = double.Parse(line2[0]);
var y2 = double.Parse(line2[1]);

var distance = Math.Sqrt(Math.Pow((x2 - x1), 2)+Math.Pow((y2 - y1),2));

Console.WriteLine(distance.ToString("F4"));