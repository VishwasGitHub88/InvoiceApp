using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceAppBL
{
    public class CategoryManagement
    {
        //Declared as private to avoid getting updated from outside the class
        private List<Category> Categories = new List<Category>();

        public string AddCategory(Category category)
        {
            string result = string.Empty;
            Categories.Add(category);
            return result = "Category added sucessfully....";
        }
        public Category GetCategory(int categoryId)
        {
            return Categories.Where(x => x.CategoryId == categoryId).FirstOrDefault();
        }

        public int UpdateCategory(Category category)
        {
            var index = Categories.FindIndex(X => X.CategoryId == category.CategoryId);
            if (index > -1)
            {
                Categories[index].CategoryName = category.CategoryName;
                Categories[index].Description = category.Description;
               
            }
            return category.CategoryId;

        }

        public int DeleteCategory(int categoryId)
        {
            int Id = 0;
            var Category = Categories.Single(X => X.CategoryId == categoryId);
            Categories.Remove(Category);
            return Id = categoryId;
        }

        public List<Category> GetCategories()
        {
            return Categories;
        }

        public string GetCategoryId()        
        {
            
            string result = string.Join(",", Categories.Select(r => r.CategoryId));
            return result;
        }

    }
}
