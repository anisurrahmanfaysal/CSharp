using AdoNetExample;

Console.WriteLine("AdoNetExample!");

AdonetUtility adonetUtility = new AdonetUtility();

var sql = "INSERT INTO EMPLOYEE (NAME, DATEOFBIRTH, ISMARRIED) values(@name, @dateofbirth, @ismarried)";
Dictionary<string, object> keyValuePairs = new Dictionary<string, object>();
keyValuePairs.Add("name", "Shoshi");
keyValuePairs.Add("dateofbirth",new DateTime (1999 , 1,29));
keyValuePairs.Add("ismarried", 1);

var dataSql = "SELECT * FROM EMPLOYEE WHERE ID < @ID";

Dictionary<string, object> parameters = new Dictionary<string, object>();
parameters.Add("ID", 6);

adonetUtility.RunSql(sql, keyValuePairs);

var result = adonetUtility.GetData(dataSql, parameters);

foreach (var row in result)
{
    foreach (var key in row.Keys)
    {
        Console.Write(row[key]);
        Console.Write(" ");
    }
    Console.WriteLine();
}