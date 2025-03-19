string name = Console.ReadLine();
int flag = 0;

for (int i = 0; i < name.Length-1; i++)
{
    for (int j = 0; j < name.Length-1; j++)
    {
        if (name[i] == name[j] && i != j)
        {
            flag++;
        }
    }
    
}


Console.WriteLine(flag);


Console.WriteLine(name.Length);

