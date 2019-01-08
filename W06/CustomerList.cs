using System;
using System.Collections.Generic;
using System.Text;

namespace W06
{
    public delegate void Processor(Customer customer);
    public class CustomerList : List<Customer>
    {
        public void ProcessCustomer(Processor processor)
        {
            foreach (Customer customer in this)
            {
                processor(customer);
            }
        }
    }
}
