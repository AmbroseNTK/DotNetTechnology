using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace W09
{
    class Customer
    {
        [Key, MaxLength(5)]
        public string CustomerID { get; set; }
        [MaxLength(40)]
        public string CompanyName { get; set; }
        [MaxLength(60)]
        public string Address { get; set; }
        [MaxLength(15)]
        public string Country { get; set; }
    }
}
