var seconds = int.Parse(Console.ReadLine());

var hours = seconds/(60*60);
seconds = seconds % (60*60);

var minutes = seconds/60;
seconds = seconds % 60;

Console.WriteLine($"{hours}:{minutes}:{seconds}");