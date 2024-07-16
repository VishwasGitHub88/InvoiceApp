using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceAppBL
{
    public class CartManagement
    {
        private Cart cart = new Cart();
        public Cart AddCart(Customer customer, List<Product> products)
        {
            double TotalAmount;
            string result = string.Empty;
            cart.Customer = customer;
            cart.Products = products;

            TotalAmount = products.Sum(x => x.Price);           
            cart.TotalPrice = decimal.Parse(CalculateDiscount(TotalAmount).ToString());

            return cart;
        }

        //Calculate discount
        public double CalculateDiscount(double totalAmount)
        {
            //Apply discount
            if (totalAmount > 500.00)
            {
                return totalAmount - ((totalAmount * 5)/100);
            }
            else if (totalAmount > 100.00)
            {
                return totalAmount - ((totalAmount * 2) / 100);
            }
            else
            {
                return totalAmount;
            }           
        }
    }
}
