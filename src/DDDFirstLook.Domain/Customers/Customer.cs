using DDDFirstLook.Domain.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDFirstLook.Domain.Customers
{
    public class Customer
    {
        public FirstName FirstName { get; set; }

        public LastName LastName { get; set; }

        public Customer(FirstName firstName, LastName lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
