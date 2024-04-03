using System.ComponentModel.Design;
using System.Numerics;
using System.Threading.Channels;
using TaskForEvent;
using static Program;
public class Program
{
    public delegate void BuyPhone(string phone);
    public static void Main()  
    {
        MyProduct myProduct = new MyProduct();
        Person person1 = new Person("Lale","iphone 13 pro max",5300);
        Person person2 = new Person("Nermin", "samsung s21", 2000);
        Person person3 = new Person("Aydan", "iphone 15 pro max", 3500);
        Person person4 = new Person("Aysun", "samsung s24 ultra ", 2500);
        
        while (true)
        {
            
            Console.Write("Enter product's name(phone's name):"); string phone = Console.ReadLine().ToLower();
            myProduct.Add(phone);
            if (Equals(phone, person1.PersonWantingPhone)) { 
                if (person1.MoneyAmount >= 4150)
                {
                    myProduct.buyPhone += person1.Notification;

                }
                else
                {
                    Console.WriteLine("Budceniz yeterli deyil");
                }
            }
            else if (Equals(phone, person2.PersonWantingPhone))
            {

              if (person2.MoneyAmount >= 2000)
                {

                }
                else
                {
                    Console.WriteLine("Budceniz yeterli deyil");
                }
            }
            else if (Equals(phone, person3.PersonWantingPhone))
            {
                if (person3.MoneyAmount >= 5000)
                {

                }
                else
                {
                    Console.WriteLine("Budceniz yeterli deyil");
                }
            }
            else if (Equals(phone, person4.PersonWantingPhone))
            {
                if (person4.MoneyAmount >= 2500)
                {

                }
                else
                {
                    Console.WriteLine("Budceniz yeterli deyil");
                }
            }
            else
            {
                {
                    Console.WriteLine("Magazada mehsul movcud deyil");
                }
            }

            Console.ReadKey();
           
        }
    }
}

public class MyProduct
{
    public event BuyPhone buyPhone;
    public List<string> phones=new List<string>();
    public void Add(string phone)
    {
        phones.Add(phone);
        buyPhone?.Invoke(phone);
    }
}


      