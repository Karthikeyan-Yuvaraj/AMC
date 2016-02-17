using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMC.BL
{
    public class OrderDisplay
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTimeOffset? OrderDate { get; set; }

        public List<OrderDisplayItems> OrderDisplayitemsList { get; set; }

        public int OrderId { get; set; }

        public Address Shipping { get; set; }
    }
}
