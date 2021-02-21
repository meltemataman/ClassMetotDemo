using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Name = "Ahmet";
            customer1.Surname = "Şen";
            customer1.Age = 20;
            customer1.CustomerId = 1;

            Customer customer2 = new Customer();
            customer2.Name = "Hüseyin";
            customer2.Surname = "Şen";
            customer2.Age = 23;
            customer2.CustomerId = 2;

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            Console.WriteLine("-----------");
            customerManager.Remove(customer2);
            Console.WriteLine("-----------");

            Customer[] customers = new Customer[] { customer1, customer2 };
            Console.WriteLine("Müşteri Listesi");
            customerManager.List(customers);
            Console.WriteLine("-------------");
            Console.WriteLine("Meltem Ataman");
        }
    }
}
