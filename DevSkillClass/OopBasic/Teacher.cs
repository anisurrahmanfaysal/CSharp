using System;

namespace OopBasic;

public class Teacher : User
{
    public Teacher(string username, string password) : base(username, password){
        id = "TE-"+ username.Substring(0,3);
    }
}
