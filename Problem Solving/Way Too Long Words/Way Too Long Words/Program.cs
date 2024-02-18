int numberOfWords = Convert.ToInt16(Console.ReadLine()); 

for (int i = 0; i<numberOfWords; i++)
{
    string word = Console.ReadLine();
    int lengthOfWord = word.Length;

    if (lengthOfWord <= 10)
    {
        Console.WriteLine(word);
    }
    else
    {
        Console.Write(word[0]);
        Console.Write(lengthOfWord-2);
        Console.WriteLine(word[lengthOfWord-1]);
    }
}

