string[] startDayLine = Console.ReadLine().Split(' ');
int startDay = int.Parse(startDayLine[1]);

string[] startTime = Console.ReadLine().Split(':');
var startHour = int.Parse(startTime[0]);
var startMinute = int.Parse(startTime[1]);
var startSecond = int.Parse(startTime[2]);

string[] endDayLine = Console.ReadLine().Split(' ');
int endDay = int.Parse(endDayLine[1]);

string[] endTime = Console.ReadLine().Split(':');
var endHour = int.Parse(endTime[0]);
var endMinute = int.Parse(endTime[1]);
var endSecond = int.Parse(endTime[2]);

var totalStartTime = startDay * 86400 + startHour * 3600 + startMinute * 60 + startSecond;
var totalEndTime = endDay * 86400 + endHour * 3600 + endMinute * 60 + endSecond;

var duration = totalEndTime - totalStartTime;

var days = duration / 86400;
duration %= 86400;

var hour = duration / 3600;
duration %= 3600;

var minute = duration / 60;
var second = duration % 60;

Console.WriteLine($"{days} dia(s)");
Console.WriteLine($"{hour} hora(s)");
Console.WriteLine($"{minute} minuto(s)");
Console.WriteLine($"{second} segundo(s)");