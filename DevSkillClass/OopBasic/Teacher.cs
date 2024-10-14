using System;

namespace OopBasic;

public class Teacher : User
{
    internal double Salary { get; set; }
    public Teacher(string username, string password) : base(username, password){
        id = "TE-"+ username.Substring(0,3);
    }

    internal void CalculateSalary()
    {
        Salary = 20000;
    }
}
