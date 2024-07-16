using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceAppBL
{
    public class CustomerManagement
    {
        //Declared as private to avoid getting updated from outside the class
        private List<Customer> Customers = new List<Customer>();

        public string AddCustomer(Customer customer)
        {
            string result = string.Empty;
            Customers.Add(customer);
            return result = "Customer added sucessfully...";
        }
        public Customer GetCustomer(int customerId)
        {
            return Customers.Where(x => x.CustomerId == customerId).FirstOrDefault();
        }

        public int UpdateCustomer(Customer customer)
        {
            var index = Customers.FindIndex(X => X.CustomerId == customer.CustomerId);
            if (index > -1)
            {
                Customers[index].CustomerName = customer.CustomerName;
                Customers[index].CustomerEmail = customer.CustomerEmail;
                Customers[index].CustomerContact = customer.CustomerContact;
                Customers[index].CustomerAddress = customer.CustomerAddress;

            }
            return customer.CustomerId;

        }

        public int DeleteCustomer(int customerId)
        {
            int Id = 0;
            var Customer = Customers.Single(X => X.CustomerId == customerId);
            Customers.Remove(Customer);
            return Id = customerId;
        }

        public List<Customer> GetCustomers()
        {
            return Customers;
        }
    }
}
