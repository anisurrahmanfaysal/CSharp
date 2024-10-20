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
        
        Username = username;
        Password = password;
    }
    public void ChangePassword(string oldPassword, string newPassword){
        if (Password == oldPassword)
        {
            Password = newPassword;
        }
    }

    public virtual void CreateId()
    {
        id = new IdGenerator().Generate();
    }
}
