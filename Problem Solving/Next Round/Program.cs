int participants = Convert.ToInt16(Console.ReadLine());
int passingScore = Convert.ToInt16(Console.ReadLine());

int count = 0;

for (int i = 0; i < participants; i++)
{
    int score = Convert.ToInt16(Console.ReadLine());
    if(passingScore < score)
    {
        count++;
    }
}

Console.WriteLine(count);