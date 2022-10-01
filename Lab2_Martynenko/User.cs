using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class User
{
    public User(string theDate)
    {
        this.theDate = theDate;
    }
    public string login;
    public string firstName;
    public string lastName;
    public string age;
    private string theDate;

    public void Info()
    {
        Console.WriteLine($"Login: {login}");
        Console.WriteLine($"First name: {firstName}");
        Console.WriteLine($"Last name: {lastName}");
        Console.WriteLine($"Age: {age}");
    }
}

