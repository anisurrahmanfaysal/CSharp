string[] input = Console.ReadLine().Split(' ');

var A = int.Parse(input[0]);
var B = int.Parse(input[1]);

if (A % B == 0 || B % A == 0)
    Console.WriteLine("Sao Multiplos");

else
    Console.WriteLine("Nao sao Multiplos");
