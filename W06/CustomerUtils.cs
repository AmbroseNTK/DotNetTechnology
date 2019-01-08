using System;
using System.Collections.Generic;
using System.Text;

namespace W06
{
    public class CustomerUtils
    {

        public static Customer Youngest = new Customer()
        {
            Age = 999
        };

        private static int totalAge = 0;
        private static int totalCustomer = 0;

        public static void GetYoungest(Customer customer)
        {
            if (customer.Age <= Youngest.Age)
            {
                Youngest = customer;
            }
        }

        public static void PrintCustomer(Customer customer)
        {
            Console.WriteLine(
                customer.Name + "-" +
                customer.Age + "-" +
                customer.Address);
        }

        public static void CalAverageAge(Customer customer)
        {
            totalAge += customer.Age;
            totalCustomer++;
        }

        public static double AverageAge() => (double)totalAge / totalCustomer;

    }
}
