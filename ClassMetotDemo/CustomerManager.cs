using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customers customerName) 
        {
            Console.WriteLine("Tebrikler! " + customerName.customerName +"  başarıyla eklendi. ");
            Console.WriteLine("------------------------------");

        }
        public void Delete(Customers customerName)
        {
            Console.WriteLine(customerName.customerName + "  isimli kullanıcı başarıyla silindi " );
            Console.WriteLine("------------------------------");

        }

        public void GetAll(Customers customer1, Customers customer2, Customers customer3)
        {
            Customers[] customerList = new Customers[] {customer1, customer2, customer3 };

            foreach (Customers list in customerList)
            {
                Console.WriteLine("Müşteri ID : " + list.Id);
                Console.WriteLine("Müşteri Adı : " + list.customerName);
                Console.WriteLine("Müşteri Soyadı : " + list.customerSurname);
                Console.WriteLine("Müşteri Yaşı : " + list.customerAge);
                Console.WriteLine("Müşteri TC No : " + list.customerTC);
                Console.WriteLine("------------------------------");
            }

        }
    }
}
