using System;
using System.Linq;

namespace W09
{
    class Program
    {
        public static NorthwindDB db;
        static void Main(string[] args)
        {
            db = new NorthwindDB();

            View();
            DeleteByID('A');
            View();
            //Insert(GetInput());
            Console.Read();
        }
        public static void View()
        {
            try
            {
                var selection = from customer in db.Customers select customer;
                Console.WriteLine(@"{0,6}|{1,10}|{2,15}|{3,15}", "ID", "Name", "Address", "Country");
                Console.WriteLine("---------------------------------------------------------------");
                selection.ToList<Customer>()
                    .ForEach(customer =>
                    {
                        Console.WriteLine(@"{0,6}|{1,10}|{2,15}|{3,15}",
                        customer.CustomerID,
                        customer.CompanyName,
                        customer.Address,
                        customer.Country);
                        Console.WriteLine("---------------------------------------------------------------");
                    }
                    );
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public static void Insert(Customer customer)
        {
            try
            {
                db.Customers.Add(customer);
                db.SaveChanges();
                Console.WriteLine("Inserted");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static Customer GetInput()
        {

            Customer customer = new Customer();
            Console.WriteLine("Enter Company ID: ");
            customer.CustomerID = Console.ReadLine();
            Console.WriteLine("Enter Company name: ");
            customer.CompanyName = Console.ReadLine();
            Console.WriteLine("Enter Address: ");
            customer.Address = Console.ReadLine();
            Console.WriteLine("Enter Country name: ");
            customer.Country = Console.ReadLine();

            return customer;

        }
        public static void UpdateCountry(string oldCountry, string newCountry)
        {
            try
            {
                (
                    from customer in db.Customers
                    where customer.Country == oldCountry
                    select customer
                 )
                 .ToList<Customer>()
                 .ForEach(customer =>
                 {
                     customer.Country = newCountry;
                 });

                db.SaveChanges();
                Console.WriteLine("Updated");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void DeleteByID(char startWithChar)
        {
            try
            {
                var deletion = (from customer in db.Customers
                                where customer.CustomerID.StartsWith(startWithChar)
                                select customer).ToList<Customer>();
                foreach (Customer customer in deletion)
                {
                    try
                    {
                        db.Customers.Remove(customer);
                        db.SaveChanges();
                        Console.WriteLine("Deleted: " + customer.CustomerID);
                    }
                    catch
                    {
                        Console.WriteLine("Cannot delete " + customer.CustomerID + " because it is reference key");
                    }
                }
                Console.WriteLine("Deleted");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
