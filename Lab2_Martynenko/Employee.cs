using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Employee
{
    public Employee(string first_name, string last_name)
    {
        this.first_name = first_name;
        this.last_name = last_name;
    }
    public string first_name;
    public string last_name;
    public string position;
    public int experience;

    public double Salary(string position, int experience)
    {
        if (position == "senior officer")
        {
            double salary = (4000 + experience * 1000) - (4000 + experience * 1000) * 0.2;
            return salary;
        }
        else if (position == "junior employee")
        {
            double salary = (2000 + experience * 1000) - (2000 + experience * 1000) * 0.2;
            return salary;
        }
        else return 0;

    }
}

