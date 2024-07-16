using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceAppBL
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public Category Category { get; set; }

        public Product()
        { 
        }

        public Product(int productId , string productName, string description, double price, int quantity, Category category)
        {
            this.ProductId = productId;
            this.ProductName = productName;
            this.Description = description;
            this.Price = price;
            this.Quantity = quantity;
            this.Category = category;

        }
    }
}
