using System;

namespace OopBasic;

public class Student : User
{
    public Student(string username,string password) : base(username, password){
        id = "ST-"+ username.Substring(0,3);
    }
}
