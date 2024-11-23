using AdoNetExample;

AdonetUtility adonetUtility = new AdonetUtility();
//var sql = "insert into Employee (name, dateofbirth, ismarried) values('Khan', '2/3/2000', 1)";
var dataSql = "select * from employee";

//adonetUtility.RunSql(sql);
adonetUtility.GetData(dataSql);