using AdoNetExample;

AdonetUtility adonetUtility = new AdonetUtility();
var sql = "insert into Employee (name, dateofbirth, ismarried) values('Khan', '2/3/2000', 1)";

adonetUtility.RunSql(sql);