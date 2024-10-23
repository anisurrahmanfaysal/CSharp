using OopBasic;
using System;

namespace AbstractClass;

public class Student : User
{
    public Student(string username,string password) : base(username, password){
       
    }

    public override void CreateId()
    {
        id = "ST-" + id;
    }
}