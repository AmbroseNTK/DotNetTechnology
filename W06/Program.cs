using System;

namespace W06
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            CustomerList list = new CustomerList();
            for (int i = 0; i < 10; i++)
            {
                list.Add(new Customer()
                {
                    Name = "Name" + rand.Next(0, 100),
                    Age = rand.Next(0, 120),
                    Address = "Address" + rand.Next(0, 100)
                });
            }
            list.ProcessCustomer(CustomerUtils.PrintCustomer);
            list.ProcessCustomer(CustomerUtils.GetYoungest);

            Console.WriteLine("\nThe youngest: " +
                        CustomerUtils.Youngest.Name + " - " +
                        CustomerUtils.Youngest.Age + " - " +
                        CustomerUtils.Youngest.Address
                    );
            list.ProcessCustomer(CustomerUtils.CalAverageAge);
            Console.WriteLine("Average age: " + CustomerUtils.AverageAge());
            Console.Read();
        }
    }
}
