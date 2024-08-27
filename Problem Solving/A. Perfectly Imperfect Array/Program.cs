// Last tried A. Perfectly Imperfect Array

int input = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < input; i++)
{
    int arrayLength = Convert.ToInt16(Console.ReadLine());
    int ans = 0;

    for (int i = 0; i < arrayLength; i++)
    {
        int arrayElement = Convert.ToInt32(Console.ReadLine());
        double a = Math.Sqrt(arrayElement);

        if(a*a != arrayElement)
            ans = 1;

        if (ans == 1)
        {
            Console.WriteLine("YES");
        }
        else{
            Console.WriteLine("NO");
        }
    }
}
