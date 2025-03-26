// See https://aka.ms/new-console-template for more information
using AdoNetExample;

Console.WriteLine("AdoNetExample!");

AdonetUtility adonetUtility = new AdonetUtility();

//var sql = "INSERT INTO EMPLOYEE (NAME, DATEOFBIRTH, ISMARRIED) values('Faysal', '2/9/1998', 1)";
var dataSql = "SELECT * FROM EMPLOYEE";

//adonetUtility.RunSql(sql);
var result = adonetUtility.GetData(dataSql);

foreach (var row in result)
{
    foreach (var key in row.Keys)
    {
        Console.Write(row[key]);
        Console.Write(" ");
    }
    Console.WriteLine();
}