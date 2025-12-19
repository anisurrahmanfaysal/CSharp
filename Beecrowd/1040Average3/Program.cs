string[] input = Console.ReadLine().Split(' ');
double exam = double.Parse(Console.ReadLine());

double N1 = double.Parse(input[0]);
double N2 = double.Parse(input[1]);
double N3 = double.Parse(input[2]);
double N4 = double.Parse(input[3]);

double media = (N1 * 2 + N2 * 3 + N3 * 4 + N4 * 1) / 10;
Console.WriteLine($"Media: {media}");

if(media >= 7)
    Console.WriteLine("Aluno aprovado.");
if(media < 5)
    Console.WriteLine("Aluno reprovado.");
if(media >= 5 && media <= 6.9)
    Console.WriteLine("Aluno em exame.");

Console.WriteLine($"Nota do exame: {exam}");

double finalAvg = (exam + media)/2;

if (finalAvg >= 5)
    Console.WriteLine("Aluno aprovado.");
else if (finalAvg <= 4.9)
    Console.WriteLine("Aluno reprovado.");

Console.WriteLine($"Media final: {finalAvg}");