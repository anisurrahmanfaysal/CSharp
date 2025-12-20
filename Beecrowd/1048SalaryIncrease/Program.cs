var salary = double.Parse(Console.ReadLine());

var totalSalary = 0.0;
var increase = 0.0;
var percent = 0;

if(salary >= 0 &&  salary <= 400.00)
{
    increase = (salary * 15) / 100;
    totalSalary = salary + increase;
    percent = 15;
}
else if (salary >= 400.01 && salary <= 800.00)
{
    increase = (salary * 12) / 100;
    totalSalary = salary + increase;
    percent = 12;
}
else if (salary >= 800.01 && salary <= 1200.00)
{
    increase = (salary * 10) / 100;
    totalSalary = salary + increase;
    percent = 10;
}
else if (salary >= 1200.01 && salary <= 2000.00)
{
    increase = (salary * 7) / 100;
    totalSalary = salary + increase;
    percent = 7;
}
else if (salary >= 1200.01)
{
    totalSalary = (salary * 4) / 100;
    totalSalary = salary + increase;
    percent = 4;
}

Console.WriteLine($"Novo salario: {totalSalary}");
Console.WriteLine($"Reajuste ganho: {increase}");
Console.WriteLine($"Em percentual: {percent} %");
