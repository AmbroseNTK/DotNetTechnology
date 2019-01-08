using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace W08
{
    class Supplier
    {
        public int SupplierID { get; set; }

        [Column(TypeName = "nvarchar")]
        public string CompanyName { get; set; }
    }
}
