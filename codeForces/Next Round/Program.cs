int participants = Convert.ToInt16(Console.ReadLine());
int passingScore = Convert.ToInt16(Console.ReadLine());
int count = 0;
int[] a = new int[participants];

// foreach (int item in a)
// {
//     Convert.ToInt16(Console.ReadLine());
// }

// foreach (int item in a)
// {
//     Console.WriteLine(item);
// }

for (int i = 0; i < participants; i++)
{
    a[i] = Convert.ToInt16(Console.Read());
    if(a[i] > passingScore && a[i] > 0)
    {
        count++;
    }
}

Console.WriteLine(count);
