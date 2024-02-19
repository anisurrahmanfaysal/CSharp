int participants = Convert.ToInt16(Console.ReadLine());
int passingScore = Convert.ToInt16(Console.ReadLine());
int count = 0;
int[] a = new int[participants];

foreach (int item in a)
{
    Convert.ToInt16(Console.ReadLine());
}

for (int i = 0; i < participants; i++)
{
    //a = Convert.ToInt16(Console.ReadLine());
    if(passingScore < a[i] && a[i] > 0)
    {
        count++;
    }
}

Console.WriteLine(count);
