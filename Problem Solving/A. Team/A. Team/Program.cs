int numberOfProblem = Convert.ToInt32(Console.ReadLine());
int count = 0;
for(int i = 0; i < numberOfProblem; i++)
{
    int isPossiblePetya = Convert.ToInt32(Console.ReadLine());
    int isPossibleVasya = Convert.ToInt32(Console.ReadLine());
    int isPossibleTonya = Convert.ToInt32(Console.ReadLine());

    if (isPossiblePetya + isPossibleVasya + isPossibleTonya >= 2)
        int count = count++;
}
Console.WriteLine(count);