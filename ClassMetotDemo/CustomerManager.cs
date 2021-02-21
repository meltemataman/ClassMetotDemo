using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.Surname + " kişisi eklendi");
        }

        public void Remove(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.Surname + " kişisi silindi");
        }

        public void List(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Ad & Soyad: " + customer.Name + customer.Surname);
                Console.WriteLine("Yaş: " + customer.Age);
                Console.WriteLine("------------");
            }
        }
    }
}
