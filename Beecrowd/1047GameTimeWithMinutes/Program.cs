string[] times = Console.ReadLine().Split(' ');

var startHour = int.Parse(times[0]);
var startMinute = int.Parse(times[1]);
var endHour = int.Parse(times[2]);
var endMinute = int.Parse(times[3]);
var gameTime = 0;

var totalStartMinute = startHour * 60 + startMinute;
var totalEndMinute = endHour * 60 + endMinute;

if( totalStartMinute < totalEndMinute)
    gameTime = totalEndMinute - totalStartMinute;
else
    gameTime = (1440 - totalStartMinute) + totalEndMinute;


Console.WriteLine($"O JOGO DUROU {gameTime / 60} HORA(S) E {gameTime%60} MINUTO(S)");
