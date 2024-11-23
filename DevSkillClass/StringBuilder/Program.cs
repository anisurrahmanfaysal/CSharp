using System.Text;

StringBuilder stringBuilder1 = new StringBuilder("I'm from Dhaka ");

stringBuilder1 = stringBuilder1.Append("And I love programming");

stringBuilder1 = stringBuilder1.AppendLine(". My name is Faysal");

stringBuilder1 = stringBuilder1.Replace('f', 's');
stringBuilder1 = stringBuilder1.Replace('s', 'f');

stringBuilder1 = stringBuilder1.Insert(10, "WWWW");
stringBuilder1 = stringBuilder1.Remove(10, 4);

for (int i = 0; i < stringBuilder1.Length; i++)
{
    stringBuilder1[i] = 'J';
}

Console.WriteLine(stringBuilder1.ToString());