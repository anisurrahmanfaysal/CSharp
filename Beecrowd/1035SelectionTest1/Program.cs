string[] input = Console.ReadLine().Split(' ');
var A = int.Parse(input[0]);
var B = int.Parse(input[1]);
var C = int.Parse(input[2]);
var D = int.Parse(input[3]);

if (B > C && D > A && (C + D) > (A + B) && C > 0 && D > 0 && A % 2 == 0)
    Console.WriteLine("Valores aceitos");
else
    Console.WriteLine("Valores nao aceitos");

//bool TrueOrFalse(int a, int b, int c, int d)
//{
//    if (b > c && d > a && (c + d) > (a + b) && c > 0 && d > 0 && a % 2 == 0)
//        return true;
//    else
//        return false;
//}