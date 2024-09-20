using System;

namespace OopBasic;

public class User
{
    public string Username { get; set; }
    public string Password { get; set; }
    protected string id;

    public string ID{
        get{ return id; 
        }
    }

    public User(string username, string password){
        id = "123";
        Username = username;
        Password = password;
    }
    public void ChangePassword(string oldPassword, string newPassword){
        if (Password == oldPassword)
        {
            Password = newPassword;
        }
    }
}
