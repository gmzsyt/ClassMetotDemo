using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void MusteriEkleme(Customer customer)
        {
            Console.WriteLine(customer.Ad + " " +"isimli yeni bir müşteri eklendi.");
        }

        public void MusteriSilme(Customer customer)
        {
            Console.WriteLine(customer.Ad  + " \t isimli müşteri silindi.");
        }



    }
}
