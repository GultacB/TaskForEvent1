using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskForEvent;

public class Person
{ 
    public Person(string name,string personWantingPhone,double moneyAmount)
    {
        Name = name;
        PersonWantingPhone=personWantingPhone;
        MoneyAmount = moneyAmount;
    }

    public string Name { get; set; }
    public string PersonWantingPhone { get; set; }
    public double MoneyAmount { get; set; }

    public void Notification()
    {
        Console.WriteLine($"{Name} {PersonWantingPhone} movcuddur ve ala bilersiniz");
    }
}
