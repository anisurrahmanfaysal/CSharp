using AdoNetPractice;

AdonetUtility adonetUtility = new AdonetUtility();

var sql = "insert into employee (name, dateofbirth, ismarried) values('Faysal','2/2/1997',1)";
adonetUtility.RunSql(sql);