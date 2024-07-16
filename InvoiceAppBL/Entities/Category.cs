using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceAppBL
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public Category()
        { }

        public Category(int categoryId, string categoryName, string description)
        {
            this.CategoryId = categoryId;
            this.CategoryName = categoryName;
            this.Description = description;
        }
    }
}
