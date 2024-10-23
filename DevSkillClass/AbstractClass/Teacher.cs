using System;

namespace AbstractClass;

public class Teacher : User
{
    internal double Salary { get; set; }
    public Teacher(string username, string password) : base(username, password){
        
    }

    internal void CalculateSalary()
    {
        Salary = 20000;
    }

    public override void CreateId()
    {
        id = "TE-" + Username.Substring(0, 3);
    }
}