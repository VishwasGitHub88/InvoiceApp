using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceAppBL
{
    public class ProductManagement
    {
        //Declared as private to avoid getting updated from outside the class
        private List<Product> Products = new List<Product>();

        public string AddProduct(Product product)
        {
            string result = string.Empty;
            Products.Add(product);
           return result = "Product added sucessfully....";
        }
        public Product GetProduct(int productId)
        {
            return Products.Where(x=>x.ProductId == productId).FirstOrDefault();
        }

        public int UpdateProduct(Product product)
        {
            var index = Products.FindIndex(X => X.ProductId == product.ProductId);
            if (index > -1)
            {                
                Products[index].ProductName = product.ProductName;
                Products[index].Description = product.Description;
                Products[index].Price = product.Price;
                Products[index].Quantity = product.Quantity;
                Products[index].ProductId = product.ProductId;
            }
            return product.ProductId;

        }

        public int DeleteProduct(int productId)
        {
            int Prod = 0;
            var Product = Products.Single(X => X.ProductId == productId);
            Products.Remove(Product);
            return Prod = productId;
        }

        public List<Product> GetProducts() 
        {
            return Products;
        }


    }
}
