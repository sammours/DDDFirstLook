using DDDFirstLook.Domain.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDFirstLook.Domain.Customers
{
    public class CustomerAddress
    {
        public string Street { get; set; }

        public PostalCode PostalCode { get; set; }

        public string City { get; set; }

        public string Country { get; set; }
    }
}
