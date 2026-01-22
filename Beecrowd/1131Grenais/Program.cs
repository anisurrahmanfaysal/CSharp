var option = 0;
var count = 0;
var countInterWins = 0;
var countGremioWins = 0;
var countDrow = 0;
while (true)
{
    count++;
    string[] goals = Console.ReadLine().Split(' ');
    var interGoals = int.Parse(goals[0]);
    var gremioGoals = int.Parse(goals[1]);

    if (interGoals < gremioGoals)
        countGremioWins++;
    else if(interGoals > gremioGoals)
        countInterWins++;
    else
        countDrow++;

        Console.WriteLine("Novo grenal (1-sim 2-nao)");
    option = int.Parse(Console.ReadLine());
    if(option == 2)
        break;
    
}
Console.WriteLine($"{count} grenais");
Console.WriteLine($"Inter:{countInterWins}");
Console.WriteLine($"Gremio:{countGremioWins}");
Console.WriteLine($"Empates:{countDrow}");

if(countInterWins > countGremioWins)
    Console.WriteLine("Inter houve vencedor");
else if(countGremioWins > countInterWins)
    Console.WriteLine("Gremio houve vencedor");
else
    Console.WriteLine("Não houve vencedor");