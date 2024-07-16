using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceAppBL
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public Cart Cart { get; set; }
        public bool IsPaid { get; set; }

        public static int counter;

        static Invoice()
        {
            counter = 5000;
        }
        public Invoice()
        {
            this.InvoiceId = counter++;
        }

        public Invoice(Cart cart, bool isPaid)
        {
            this.InvoiceId = counter++;
            this.Cart = cart;
            this.IsPaid = isPaid;
        }

        public string DisplayInvoice()
        {
            string result = string.Empty;
            string Products = string.Empty;

            foreach (Product product in Cart.Products)
            {
                Products = Products + "Product name :" + product.ProductName + "\n Product description :" + product.Description + "\n Product price :" + product.Price + "\n";
                     
            }


            result = "Invoice id - " + this.InvoiceId + "\n Customer name :" + this.Cart.Customer.CustomerName + "\n Customer contact :" + this.Cart.Customer.CustomerContact +
              "\n " + Products+ "\n Final amount - " + Cart.TotalPrice + "\n Payment method - " + Cart.PaymentType + "\n " + ((this.IsPaid == true) ? "Payment done":"Payment not completed").ToString() ;

            return result;
        }
    }
}
