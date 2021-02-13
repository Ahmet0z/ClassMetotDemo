using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customers customer1 = new Customers();
            customer1.Id = 1;
            customer1.customerName = "Aybars";
            customer1.customerSurname = "Öz";
            customer1.customerAge = 18;
            customer1.customerTC = 97425974682;

            Customers customer2 = new Customers();
            customer2.Id = 2;
            customer2.customerName = "Doğukan";
            customer2.customerSurname = "Alay";
            customer2.customerAge = 25;
            customer2.customerTC = 16575616578;

            Customers customer3 = new Customers();
            customer3.Id = 3;
            customer3.customerName = "Kemal";
            customer3.customerSurname = "Işık";
            customer3.customerAge = 35;
            customer3.customerTC = 48965874125;


            CustomerManager manager = new CustomerManager();
            Console.WriteLine("Add komutu");
            manager.Add(customer1);

            Console.WriteLine("Delete komutu");
            manager.Delete(customer2);

            Console.WriteLine("GetAll komutu");
            manager.GetAll(customer1, customer2, customer3);
        }
    }
}
