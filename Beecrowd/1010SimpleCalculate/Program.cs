string[] line1 = Console.ReadLine().Split(' ');
var code1 = int.Parse(line1[0]);
var unit1 = int.Parse(line1[1]);
var price1 = double.Parse(line1[2]);

string[] line2 = Console.ReadLine().Split(' ');
var code2 = int.Parse(line2[0]);
var unit2 = int.Parse(line2[1]);
var price2 = double.Parse(line2[2]);

var total = (unit1 * price1) + (unit2 * price2);

Console.WriteLine($"VALOR A PAGAR: R$ {total:F2}");




