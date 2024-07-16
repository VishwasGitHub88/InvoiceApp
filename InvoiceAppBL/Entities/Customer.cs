using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceAppBL
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; } 
        public string CustomerContact { get; set; }
        public string CustomerAddress { get; set; }

        public Customer()
        { }

        public Customer(int customerId, string customerName, string customerEmail, string customerContact, string customerAddress)
        {
            this.CustomerId = customerId;
            this.CustomerName = customerName;
            this.CustomerEmail = customerEmail;
            this.CustomerContact = customerContact;
            this.CustomerAddress = customerAddress;
        }
    }
}
