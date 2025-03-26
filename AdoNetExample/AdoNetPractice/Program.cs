// See https://aka.ms/new-console-template for more information
using AdoNetPractice;

Console.WriteLine("AdoNetPractice!");

AdonetUtility adonotUtility  = new AdonetUtility();
//var sql = "INSERT INTO EMPLOYEE (NAME, ISEMPLOYEE) values('Faysal', 0)";
var dataSql = "SELECT * FROM EMPLOYEE";
//adonotUtility.SqlRun(sql);
var result = adonotUtility.GetData(dataSql);

foreach (var row in result)
{
    foreach (var key in row.Keys)
    {
        Console.Write(row[key]);
        Console.Write(" ");
    }
    Console.WriteLine();
}