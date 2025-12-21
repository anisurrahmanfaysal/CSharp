var salary  = double.Parse(Console.ReadLine());

var tex = 0.00;

if(salary <= 2000)
{
    Console.WriteLine("Isento");
    return;
}

if( salary > 2000)
{
    double taxable = Math.Min(salary, 3000)-2000;
    tex += taxable * 0.08;
}

if (salary > 3000)
{
    double taxable = Math.Min(salary, 4500) - 3000;
    tex += taxable * 0.18;
}

if (salary > 4500)
{
    double taxable = salary - 4500;
    tex += taxable * 0.28;
}

Console.WriteLine("R$ "+ tex.ToString("F2"));
