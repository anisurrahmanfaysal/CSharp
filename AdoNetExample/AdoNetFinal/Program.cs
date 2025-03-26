// See https://aka.ms/new-console-template for more information
using AdoNetFinal;

Console.WriteLine("AdoNetFinal!");

AdonetUtility adonetUtility = new AdonetUtility();

var sql = "INSERT INTO EMPLOYEE(Name, Age, IsMarried) VALUES('Faysal', 1998-9-2, 1)";
adonetUtility.SqlRun(sql);

string dataSql = "SELECT * FROM EMPLOYEE";
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


