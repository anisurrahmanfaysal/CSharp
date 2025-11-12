var  time = int.Parse(Console.ReadLine());
var speed  = int.Parse(Console.ReadLine());

var distance = time * speed;
var m = distance / 12.0;
Console.WriteLine(m.ToString("F3"));