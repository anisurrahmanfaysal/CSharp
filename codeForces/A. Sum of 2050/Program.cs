//Accepted!
int t = Convert.ToInt16(Console.ReadLine());

while (t>0)
{
    long n = Convert.ToInt64(Console.ReadLine());
    int ans = 0;

    while (n>=2050)
    {
        ans++;
        long x = 2050;
        while (x<=n)
        {
            x*=10;
        }
        x/=10;
        n=n-x;
    }
    if (n!=0)
    {
        Console.WriteLine("-1");
    }
    else
    {
        Console.WriteLine(ans);
    }
    t--;
}
return 0;