using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter which task you want to run:\n Task 1(Press 1) \n Task 2(Press 2) \n Task 3(Press 3) \n Task 4 (Press 4)");
        int x = int.Parse(Console.ReadLine());
        switch (x)
        {
            case 1:
                Task1();
                break;
            case 2:
                Task2();
                break;
            case 3:
                Task3();
                break;
            case 4:
                Task4();
                break;
        }
            
         void Task1() 
        {
            //task1
            Address MyAddress = new Address();
            MyAddress.Index = "04071";
            MyAddress.Country = "Ukraine";
            MyAddress.City = "Kyiv";
            MyAddress.Street = "Lobachevskogo";
            MyAddress.House = "23";
            MyAddress.Apartment = "904";

            MyAddress.Print();
        }
        
        void Task2()
        {
            //task2
            Console.WriteLine("Enter the value of 1 usd in uah: ");
            double usd1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of 1 eur in uah: ");
            double eur1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of 1 rub in uah: ");
            double rub1 = double.Parse(Console.ReadLine());
            double uah;
            double usd;
            double eur;
            double rub;
            double usd2;
            double eur2;
            double rub2;

            Converter values = new Converter(usd1, eur1, rub1);
            Console.WriteLine("Choose the procedure you want to execute:\nFrom UAH to USD (Press a)\nFrom UAH to EUR (press s)\nFrom UAH to RUB (press d)\n" +
                "From USD to UAH (press f)\nFrom EUR to UAH (press g)\nFrom RUB to UAH (press h)");
            char option = char.Parse(Console.ReadLine());
            switch (option)
            {
                case 'a':
                    Console.WriteLine("Enter the amount of UAH you want to convert: ");
                    uah = double.Parse(Console.ReadLine());
                    usd1 = uah / values.usd;
                    Console.WriteLine($"Result: {usd1}");
                    break;
                case 's':
                    Console.WriteLine("Enter the amount of UAH you want to convert: ");
                    uah = double.Parse(Console.ReadLine());
                    eur1 = uah / values.eur;
                    Console.WriteLine($"Result: {eur1}");
                    break;
                case 'd':
                    Console.WriteLine("Enter the amount of UAH you want to convert: ");
                    uah = double.Parse(Console.ReadLine());
                    rub1 = uah / values.rub;
                    Console.WriteLine($"Result: {rub1}");
                    break;
                case 'f':
                    Console.WriteLine("Enter the amount of USD you want to convert: ");
                    usd2 = double.Parse(Console.ReadLine());
                    uah = usd2 * values.usd;
                    Console.WriteLine($"Result: {uah}");
                    break;
                case 'g':
                    Console.WriteLine("Enter the amount of EUR you want to convert: ");
                    eur2 = double.Parse(Console.ReadLine());
                    uah = eur2 * values.eur;
                    Console.WriteLine($"Result: {uah}");
                    break;
                case 'h':
                    Console.WriteLine("Enter the amount of RUB you want to convert: ");
                    rub2 = double.Parse(Console.ReadLine());
                    uah = rub2 * values.rub;
                    Console.WriteLine($"Result: {uah}");
                    break;
            }
        }

        void Task3()
        {
            //task3
            Console.WriteLine("Enter the employee's first name: ");
            string first_name1 = Console.ReadLine();
            Console.WriteLine("Enter the employee's last name: ");
            string last_name1 = Console.ReadLine();
            Employee TheWorker = new Employee(first_name1, last_name1);
            Console.WriteLine("Enter the employees's position (senior officer or junior employee): ");
            TheWorker.position = Console.ReadLine();
            Console.WriteLine("Enter the employees's experience (in years): ");
            TheWorker.experience = int.Parse(Console.ReadLine());
            Console.WriteLine($"The Worker's salary is: {TheWorker.Salary(TheWorker.position, TheWorker.experience)}");
        }
        void Task4() 
        { 
        //task4
        Console.WriteLine("Please, enter the date of filling out the questionnaire: ");
        string theDate = Console.ReadLine();
        User user1 = new User(theDate);
        Console.WriteLine("Enter user's login");
        user1.login = Console.ReadLine();
        Console.WriteLine("Enter user's first name");
        user1.firstName = Console.ReadLine();
        Console.WriteLine("Enter user's last name");
        user1.lastName = Console.ReadLine();
        Console.WriteLine("Enter user's age");
        user1.age = Console.ReadLine();
        Console.WriteLine();
        user1.Info();

        }
}
    }

