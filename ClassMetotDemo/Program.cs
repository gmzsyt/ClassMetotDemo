using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           

            // List<Customer> customer = new List<Customer>();
            // customer.Add();

            Customer customer1 = new Customer();
            customer1.Ad = "Mustafa";
            customer1.Soyad = "seyit";
            customer1.Id =1;

            Customer customer2 = new Customer();
            customer2.Ad = "Gaye";
            customer2.Soyad = "Seyit";
            customer2.Id = 12;

            Customer customer3 = new Customer();
            customer3.Ad = "Ahmet";
            customer3.Soyad = "seyit";
            customer3.Id = 15;


            CustomerManager met = new CustomerManager();
            met.MusteriSilme(customer2);



        }
    }
}
