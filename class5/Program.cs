// See https://aka.ms/new-console-template for more information

string name = "Faysal";
string name2 = "Shoshi";
string location = "Monohardi";
string location2 = "Home";

System.Console.WriteLine("Hello, {0}. I'm from {1}.", name, location);

string text = $"Hello, {name2}. I'm learning from: {location2}.";

System.Console.WriteLine(text);

System.Console.WriteLine($"Hello, {name}. Your are from: {location}.");

string line = Console.ReadLine();

int ascii = Console.Read();

//ConsoleKeyInfo key = Console.ReadKey();

//Console.ReadLine((char)ascii);


int[] nums = new int[3];

string input = Console.ReadLine();

string[] partsOfLine = input.Split(',',' ');

nums[0] = int.Parse(partsOfLine[0]);
nums[1] = int.Parse(partsOfLine[1]);
nums[2] = int.Parse(partsOfLine[2]);

