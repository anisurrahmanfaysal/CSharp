var numberOfText = int.Parse(Console.ReadLine());

var totalAnimal = 0;
var totalC = 0;
var totalR = 0;
var totalS = 0;

for (int i = 0; i < numberOfText; i++)
{
    string[] animals = Console.ReadLine().Split(' ');
    var animalNumber = int.Parse(animals[0]);
    var animalName = animals[1];

    totalAnimal += animalNumber;

    if( animalName == "C")
        totalC += animalNumber;
    if (animalName == "R")
        totalR += animalNumber;
    if (animalName == "S")
        totalS += animalNumber;
}

var pC = (totalC * 100.00) / totalAnimal;
var pR = (totalR * 100.00) / totalAnimal;
var pS = (totalS  * 100.00) / totalAnimal;

Console.WriteLine($"Total: {totalAnimal} cobaias");
Console.WriteLine($"Total de coelhos: {totalC}");
Console.WriteLine($"Total de ratos: {totalR}");
Console.WriteLine($"Total de sapos: {totalS}");
Console.WriteLine($"Percentual de coelhos: {pC:F2} %");
Console.WriteLine($"Percentual de ratos: {pR:F2} %");
Console.WriteLine($"Percentual de sapos: {pS:F2} %");