string[] inputs = Console.ReadLine().Split(' ');

var A = double.Parse(inputs[0]);
var B = double.Parse(inputs[1]);
var C = double.Parse(inputs[2]);

double[] sides = {A , B, C};
Array.Sort(sides);
Array.Reverse(sides);

A = sides[0];
B = sides[1];
C = sides[2];

if( A >= B +  C)
{
    Console.WriteLine("NAO FORMA TRIANGULO");
    return;
}
    
var A2 = A * A;
var B2C2 = B * B + C * C;

if( A2 == B2C2)
    Console.WriteLine("TRIANGULO RETANGULO");
else if (A2 > B2C2)
    Console.WriteLine("TRIANGULO OBTUSANGULO");
else 
    Console.WriteLine("TRIANGULO ACUTANGULO");

if( A == B && B == C)
    Console.WriteLine("TRIANGULO EQUILATERO");
else if(A == B || B == C || C == A)
    Console.WriteLine("TRIANGULO ISOSCELES");