using AdoNetPractice;

string connectionString = "Server = DESKTOP-5IJV2CO\\SQLEXPRESS; Database = CSharpB18; User Id = csharpb18; Password = 123456;Trust Server Certificate=True";

AdonetUtility adonetUtility = new AdonetUtility(connectionString);

var sql = "insert into employee (name, dateofbirth, ismarried) values('Faysal','2/2/1997',1)";
adonetUtility.RunSql(sql);