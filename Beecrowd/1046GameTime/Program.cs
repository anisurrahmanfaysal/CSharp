string[] times = Console.ReadLine().Split(' ');

var gameTime = 0;
var startTime = int.Parse(times[0]);
var endTime = int.Parse(times[1]);

if(startTime < endTime)
    gameTime = endTime - startTime;
else if(endTime <= startTime)
    gameTime = (24 - startTime) + endTime;
    
Console.WriteLine($"O JOGO DUROU {gameTime} HORA(S)");
