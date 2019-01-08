using System;
using System.Collections.Generic;
using System.Text;

namespace W06
{
    public class Customer
    {

        private string name;
        private int age;
        private string address;

        public string Name
        {
            get => name;
            set => name = value;

        }

        public int Age
        {
            get => age;
            set => age = value;
        }

        public string Address
        {
            get => address;
            set => address = value;
        }

    }
}
