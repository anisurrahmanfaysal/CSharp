var salary = double.Parse(Console.ReadLine());

var percentage = 0;

if (salary <= 400.00)
    percentage = 15;
else if (salary <= 800.00)
    percentage = 12;
else if (salary <= 1200.00)
    percentage = 10;
else if (salary <= 2000.00)
    percentage = 7;
else
    percentage = 4;

double increase = (salary * percentage)/100;
double newSalary = salary + increase;

Console.WriteLine($"Novo salario: {newSalary:F2}");
Console.WriteLine($"Reajuste ganho: {increase:F2}");
Console.WriteLine($"Em percentual: {percentage} %");
