using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceAppBL
{
    public class Cart
    {
        public Customer Customer { get; set; }
        public List<Product> Products { get; set; }
        public Decimal TotalPrice { get; set; }
        public string PaymentType;
    }
}
