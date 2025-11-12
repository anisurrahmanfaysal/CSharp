var name = Console.ReadLine();
var salary = double.Parse(Console.ReadLine());
var sale = double.Parse(Console.ReadLine());

//void TotalSalary(double salary, double sale)
//{
//    var totalSale = salary + ((sale * 15) / 100);
//    Console.WriteLine(totalSale.ToString("F2"));
//}
var totalSale = salary + ((sale * 15) / 100);
Console.WriteLine("TOTAL = R$ " + totalSale.ToString("F2"));

//TotalSalary(salary, sale);
