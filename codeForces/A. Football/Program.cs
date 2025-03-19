string playerNumber = Console.ReadLine();
int one = 0;
int zero = 0;

int isDangerous = 0;

for (int i = 0; i < playerNumber.Length; i++)
{
    if (playerNumber[i] == 1)
    {
        one++;
        zero = 0;
    }
    else{
        zero++;
        one = 0;
    }
    if (one == 7 || zero == 7)
    {
        isDangerous = 1;
        break;
    }
}
if (isDangerous == 1)
{
    Console.WriteLine("YES");
}
else{
    Console.WriteLine("NO");
}
