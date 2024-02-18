int totalProblem = Convert.ToInt32(Console.ReadLine());
int count = 0;

for (int i = 0; i < totalProblem; i++)
{
    int member1 = Convert.ToInt32(Console.ReadLine());
    int member2 = Convert.ToInt32(Console.ReadLine());
    int member3 = Convert.ToInt32(Console.ReadLine());

    if((member1 == 1 && member2 == 1 && member3 ==1) || (member1 == 0 && member2 == 1 && member3 == 1) || (member1 == 1 && member2 == 0 && member3 == 1) || (member1 == 1 && member2 == 1 && member3 == 0))
        count++;
}

Console.WriteLine(count);