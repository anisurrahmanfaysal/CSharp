string[] input = Console.ReadLine().Split(' ');

var n1 = float.Parse(input[0]);
var n2 = float.Parse(input[1]);
var n3 = float.Parse(input[2]);
var n4 = float.Parse(input[3]);

double media = (n1 * 2 + n2 * 3 + n3 * 4 + n4) / 10;

Console.WriteLine($"Media: {media:F1}");

if (media >= 7.0)
{
    Console.WriteLine("Aluno aprovado.");
}
else if (media < 5.0)
{
    Console.WriteLine("Aluno reprovado.");
}
else
{
    Console.WriteLine("Aluno em exame.");

    double exame = double.Parse(Console.ReadLine());
    Console.WriteLine($"Nota do exame: {exame:F1}");

    double mediaFinal = (media + exame) / 2.0;

    if (mediaFinal >= 5.0)
        Console.WriteLine("Aluno aprovado.");
    else
        Console.WriteLine("Aluno reprovado.");

    Console.WriteLine($"Media final: {mediaFinal:F1}");
}