

namespace InvoiceApp
{
    using InvoiceAppBL;

    public class Program
    {
        public static void Main(string[] args)
        {
            // --------------------------------Start Manage Customer details ---------------------------------

            string CustomerId;
            string CustomerName;
            string CustomerEmail;
            string CustomerContact;
            string CustomerAddress;

            CustomerManagement customerManagement = new CustomerManagement();

            // --------Add Customer details
            try
            {

                while (true)
                {
                    Console.WriteLine("Enter customer details here...");
                    Console.WriteLine("Enter customer Id ");
                    CustomerId = Console.ReadLine();
                    Console.WriteLine("Enter customer name ");
                    CustomerName = Console.ReadLine();
                    Console.WriteLine("Enter customer email ");
                    CustomerEmail = Console.ReadLine();
                    Console.WriteLine("Enter customer contact");
                    CustomerContact = Console.ReadLine();
                    Console.WriteLine("Enter customer address ");
                    CustomerAddress = Console.ReadLine();

                    Customer customer;

                    if (int.TryParse(CustomerId, out int CustomerIdresult) && !string.IsNullOrEmpty(CustomerName) && !string.IsNullOrEmpty(CustomerContact)
                        && !string.IsNullOrEmpty(CustomerAddress))
                    {
                        customer = new Customer(int.Parse(CustomerId), CustomerName, CustomerEmail, CustomerContact, CustomerAddress);
                        string result = customerManagement.AddCustomer(customer);
                        Console.WriteLine(result);
                        Console.WriteLine("\n");
                        Console.WriteLine("Do you want to add another customer details (Y/N) ?");
                        if (char.Parse(Console.ReadLine().ToUpper()) == 'N')
                        {
                            break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("Please enter valid customer details!!!!!!");
                        continue;
                    }

                }


                Console.WriteLine("\n----------------You have added these customers------------------");

                foreach (Customer customer in customerManagement.GetCustomers())
                {
                    Console.WriteLine(" CustomerId - {0},\n CustomerName - {1},\n CustomerEmail - {2},\n CustomerContact - {3},\n CustomerAddress - {4}",
                       customer.CustomerId, customer.CustomerName, customer.CustomerEmail, customer.CustomerContact, customer.CustomerAddress);
                    Console.WriteLine("\n");
                }
                Console.WriteLine("------------------------------------------------------------------");
            }
            catch { }
            // --------Update Customer details
            try
            {
                Console.WriteLine("\n");
                Console.WriteLine("Do you want update customer? (Y/N)");
                if (char.Parse(Console.ReadLine().ToUpper()) == 'Y')
                {
                    Console.WriteLine("Enter customer id to update");
                    Customer GetCustomers = new Customer();
                    GetCustomers = customerManagement.GetCustomer(int.Parse(Console.ReadLine()));

                    Console.WriteLine(" CustomerId - {0},\n CustomerName - {1},\n CustomerEmail - {2},\n CustomerContact - {3},\n CustomerAddress - {4}",
                        GetCustomers.CustomerId, GetCustomers.CustomerName, GetCustomers.CustomerEmail, GetCustomers.CustomerContact, GetCustomers.CustomerAddress);

                    Console.WriteLine("\n");

                    while (true)
                    {
                        Console.WriteLine("Update customer name ");
                        CustomerName = Console.ReadLine();
                        Console.WriteLine("Update customer email ");
                        CustomerEmail = Console.ReadLine();
                        Console.WriteLine("Update customer contact");
                        CustomerContact = Console.ReadLine();
                        Console.WriteLine("Update customer address ");
                        CustomerAddress = Console.ReadLine();

                        if (!string.IsNullOrEmpty(CustomerName) && !string.IsNullOrEmpty(CustomerContact)
                            && !string.IsNullOrEmpty(CustomerAddress))
                        {
                            GetCustomers.CustomerName = CustomerName;
                            GetCustomers.CustomerEmail = CustomerEmail;
                            GetCustomers.CustomerContact = CustomerContact;
                            GetCustomers.CustomerAddress = CustomerAddress;

                            Console.WriteLine("Customer details updated successfully for this customer id - {0}", customerManagement.UpdateCustomer(GetCustomers));
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\n");
                            Console.WriteLine("Please enter valid Customer details!!!!!!");
                            continue;
                        }
                    }
                    Console.WriteLine("\n----------------Display all customer details after the updates------------------");

                    foreach (Customer customer in customerManagement.GetCustomers())
                    {
                        Console.WriteLine(" CustomerId - {0},\n CustomerName - {1},\n CustomerEmail - {2},\n CustomerContact - {3},\n CustomerAddress - {4}",
                           customer.CustomerId, customer.CustomerName, customer.CustomerEmail, customer.CustomerContact, customer.CustomerAddress);
                        Console.WriteLine("\n");
                    }
                    Console.WriteLine("---------------------------------------------------------------------------------");
                }
            }
            catch { }

            // --------Delete Customer details
            try
            {
                Console.WriteLine("Do you want to delete any customer? (Y/N)");
                if (char.Parse(Console.ReadLine().ToUpper()) == 'Y')
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Enter customer id to Delete");
                    Customer GetCustomers = new Customer();
                    GetCustomers = customerManagement.GetCustomer(int.Parse(Console.ReadLine()));

                    Console.WriteLine(" CustomerId - {0},\n CustomerName - {1},\n CustomerEmail - {2},\n CustomerContact - {3},\n CustomerAddress - {4}",
                        GetCustomers.CustomerId, GetCustomers.CustomerName, GetCustomers.CustomerEmail, GetCustomers.CustomerContact, GetCustomers.CustomerAddress);

                    Console.WriteLine("\n");

                    Console.WriteLine("Customer Deleted successfully for this productId - {0}", customerManagement.DeleteCustomer(GetCustomers.CustomerId));
                    Console.WriteLine("--------------------------------------------------------------");
                }
            }
            catch { }

            // --------Display All Customer details
            try
            {
                Console.WriteLine("\n----------------Displaying all customers ------------------");

                foreach (Customer customer in customerManagement.GetCustomers())
                {
                    Console.WriteLine(" CustomerId - {0},\n CustomerName - {1},\n CustomerEmail - {2},\n CustomerContact - {3},\n CustomerAddress - {4}",
                       customer.CustomerId, customer.CustomerName, customer.CustomerEmail, customer.CustomerContact, customer.CustomerAddress);
                    Console.WriteLine("\n");
                }
                Console.WriteLine("\n--------------------------------------------------");
            }
            catch { }

            // --------------------------------End Manage Customer details ---------------------------------

            // --------------------------------Start Manage Category details --------------------------------            
            string CategoryId;
            string CategoryName;
            string CategoryDescription;

            CategoryManagement categoryManagement = new CategoryManagement();

            // --------Add Category details
            try
            {

                while (true)
                {
                    Console.WriteLine("Enter Category details here...");
                    Console.WriteLine("Enter Category Id ");
                    CategoryId = Console.ReadLine();
                    Console.WriteLine("Enter Category name ");
                    CategoryName = Console.ReadLine();
                    Console.WriteLine("Enter Category Description ");
                    CategoryDescription = Console.ReadLine();

                    Category category;

                    if (int.TryParse(CategoryId, out int CategoryIdresult) && !string.IsNullOrEmpty(CategoryName) && !string.IsNullOrEmpty(CategoryDescription))
                    {
                        category = new Category(int.Parse(CategoryId), CategoryName, CategoryDescription);
                        string result = categoryManagement.AddCategory(category);
                        Console.WriteLine(result);
                        Console.WriteLine("\n");
                        Console.WriteLine("Do you add another category (Y/N)?");
                        if (char.Parse(Console.ReadLine().ToUpper()) == 'N')
                        {
                            break;
                        }
                        Console.WriteLine("\n");

                    }
                    else
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("Please enter valid category details!!!!!!");
                        continue;
                    }

                }


                Console.WriteLine("\n----------------Display all category details------------------");

                foreach (Category category in categoryManagement.GetCategories())
                {
                    Console.WriteLine(" CategoryId - {0},\n CategoryName - {1},\n Description - {2}",
                       category.CategoryId, category.CategoryName, category.Description);
                    Console.WriteLine("\n");
                }
                Console.WriteLine("-----------------------------------------------------------------");
            }
            catch { }
            // --------Update category details
            try
            {
                Console.WriteLine("Do you want update category? (Y/N)");
                if (char.Parse(Console.ReadLine().ToUpper()) == 'Y')
                {


                    Console.WriteLine("Enter category id to update");
                    Category getcategory = new Category();
                    getcategory = categoryManagement.GetCategory(int.Parse(Console.ReadLine()));

                    Console.WriteLine(" CategoryId - {0},\n CategoryName - {1},\n Description - {2}",
                            getcategory.CategoryId, getcategory.CategoryName, getcategory.Description);

                    Console.WriteLine("\n");

                    while (true)
                    {
                        Console.WriteLine("Enter Category name ");
                        CategoryName = Console.ReadLine();
                        Console.WriteLine("Enter Category Description ");
                        CategoryDescription = Console.ReadLine();

                        if (!string.IsNullOrEmpty(CategoryName) && !string.IsNullOrEmpty(CategoryDescription))
                        {
                            getcategory.CategoryName = CategoryName;
                            getcategory.Description = CategoryDescription;


                            Console.WriteLine("Category details updated successfully for this category id - {0}", categoryManagement.UpdateCategory(getcategory));
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\n");
                            Console.WriteLine("Please enter valid category details!!!!!!");
                            continue;
                        }
                    }
                    Console.WriteLine("\n----------------Display all cetegory details------------------");

                    foreach (Category category in categoryManagement.GetCategories())
                    {
                        Console.WriteLine(" CategoryId - {0},\n CategoryName - {1},\n Description - {2}",
                            getcategory.CategoryId, getcategory.CategoryName, getcategory.Description);

                        Console.WriteLine("\n");
                    }
                    Console.WriteLine("-----------------------------------------------------------------");
                }

            }
            catch { }

            // --------Delete category details
            try
            {
                Console.WriteLine("Do you want delete category? (Y/N)");
                if (char.Parse(Console.ReadLine().ToUpper()) == 'Y')
                {
                    Console.WriteLine("Enter category id to Delete");
                    Category getcategory = new Category();
                    getcategory = categoryManagement.GetCategory(int.Parse(Console.ReadLine()));

                    Console.WriteLine(" CategoryId - {0},\n CategoryName - {1},\n Description - {2}",
                            getcategory.CategoryId, getcategory.CategoryName, getcategory.Description);

                    Console.WriteLine("\n");

                    Console.WriteLine("Category Deleted successfully for this category - {0}", categoryManagement.DeleteCategory(getcategory.CategoryId));

                }
            }
            catch { }

            // --------Display All category details
            try
            {
                Console.WriteLine("\n----------------Display all category details------------------");

                foreach (Category category in categoryManagement.GetCategories())
                {
                    Console.WriteLine(" CategoryId - {0},\n CategoryName - {1},\n Description - {2}",
                        category.CategoryId, category.CategoryName, category.Description);

                    Console.WriteLine("\n");
                }
                Console.WriteLine("--------------------------------------------------------------");
            }
            catch { }

            // --------------------------------End Manage Category details ---------------------------------

            // --------------------------------Start Manage Product details --------------------------------
            string ProductId;
            string ProductName;
            string Description;
            string Price;
            string Quantity;
            string Category;

            List<Category> categories = new List<Category>();
            CategoryManagement CategoriesManagement = new CategoryManagement();
            categories = categoryManagement.GetCategories();     
            var categoriesName = categories.Select(r => r.CategoryName).ToList();
            ProductManagement productManager = new ProductManagement();

            // --------Add Product details
            try
            {
                Product product;
                while (true)
                {
                    Console.WriteLine("Please add product details here..");
                    Console.WriteLine("Enter product Id ");
                    ProductId = Console.ReadLine();
                    Console.WriteLine("Enter product name ");
                    ProductName = Console.ReadLine();
                    Console.WriteLine("Enter product description ");
                    Description = Console.ReadLine();
                    Console.WriteLine("Enter product price");
                    Price = Console.ReadLine();
                    Console.WriteLine("Enter product quantity ");
                    Quantity = Console.ReadLine();
                    Console.WriteLine("Select category names from this list => {0}", string.Join(", ", categories.Select(r => r.CategoryName)).ToString());
                    Category = Console.ReadLine();
                   


                    if (int.TryParse(ProductId, out int ProductIdresult) && Double.TryParse(Price, out Double Priceresult) && int.TryParse(Quantity, out int Quantityresult) &&
                        !string.IsNullOrEmpty(ProductName) && !string.IsNullOrEmpty(Description) && (!string.IsNullOrEmpty(Category) &&
                        categories.Select(r => r.CategoryName.ToUpper()).Contains(Category.ToUpper())))
                    {
                        product = new Product(int.Parse(ProductId), ProductName, Description, Double.Parse(Price), int.Parse(Quantity),
                           categories.Where(S => S.CategoryName.ToUpper() == Category.ToUpper()).FirstOrDefault());
                        string result = productManager.AddProduct(product);
                        Console.WriteLine(result);
                        Console.WriteLine("\n");
                        Console.WriteLine("Do you want to add another product (Y/N)?");
                        if (char.Parse(Console.ReadLine().ToUpper()) == 'N')
                        {
                            break;
                        }
                        Console.WriteLine("\n");
                    }
                    else
                    {
                        Console.WriteLine("Please enter valid product details!!!!!");
                        continue;
                    }

                }

                //
                Console.WriteLine("\n----------------Display All Product details------------------");
                List<Product> Getproducts = new List<Product>();
                Getproducts = productManager.GetProducts();
                foreach (Product prod in Getproducts)
                {
                    Console.WriteLine(" ProductId - {0},\n ProductName - {1},\n Description - {2},\n Price - {3},\n Quantity - {4},\n Category name - {5}",
                       prod.ProductId, prod.ProductName, prod.Description, prod.Price, prod.Quantity, prod.Category.CategoryName);
                    Console.WriteLine("\n");
                }
                Console.WriteLine("--------------------------------------------------------------");
            }
            catch { }

            // --------Update Product details
            categories = categoryManagement.GetCategories();
            categoriesName = categories.Select(r => r.CategoryName).ToList();
            try
            {
                Console.WriteLine("Do you want update product? (Y/N)");
                if (char.Parse(Console.ReadLine().ToUpper()) == 'Y')
                {
                    Console.WriteLine("Enter product id to update");
                    Product Getproduct = new Product();
                    Getproduct = productManager.GetProduct(int.Parse(Console.ReadLine()));

                    Console.WriteLine(" ProductId - {0},\n ProductName - {1},\n Description - {2},\n Price - {3},\n Quantity - {4},\n Category name - {5}",
                        Getproduct.ProductId, Getproduct.ProductName, Getproduct.Description, Getproduct.Price, Getproduct.Quantity, Getproduct.Category.CategoryName);

                    Console.WriteLine("\n");

                    while (true)
                    {
                        Console.WriteLine("Update ProductName");
                        ProductName = Console.ReadLine();
                        Console.WriteLine("Update product description ");
                        Description = Console.ReadLine();
                        Console.WriteLine("Update product price");
                        Price = Console.ReadLine();
                        Console.WriteLine("Update product quantity ");
                        Quantity = Console.ReadLine();
                        Console.WriteLine("Select category name from the list - {0}", string.Join(", ", categories.Select(r => r.CategoryName)).ToString());
                        Category = Console.ReadLine();


                        if (Double.TryParse(Price, out Double UpdatePriceresult) && int.TryParse(Quantity, out int UpdateQuantityresult) &&
                                !string.IsNullOrEmpty(ProductName) && !string.IsNullOrEmpty(Description) && (!string.IsNullOrEmpty(Category) &&
                            categories.Select(r => r.CategoryName.ToUpper()).Contains(Category.ToUpper())))
                        {
                            Getproduct.ProductName = ProductName;
                            Getproduct.Description = Description;
                            Getproduct.Price = Double.Parse(Price);
                            Getproduct.Quantity = int.Parse(Quantity);
                            Getproduct.Category = categories.Where(S => S.CategoryName == Category).FirstOrDefault();

                            Console.WriteLine("Product updated successfully for this productId - {0}", productManager.UpdateProduct(Getproduct));
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please enter valid product details....");
                            continue;
                        }
                    }
                    //
                    Console.WriteLine("\n");
                    Console.WriteLine("---------------Display All Product details------------");
                    List<Product> Getproducts = new List<Product>();
                    Getproducts = productManager.GetProducts();
                    foreach (Product product in Getproducts)
                    {
                        Console.WriteLine(" ProductId - {0},\n ProductName - {1},\n Description - {2},\n Price - {3},\n Quantity - {4},\n Category name - {5}",
                           product.ProductId, product.ProductName, product.Description, product.Price, product.Quantity, Getproduct.Category.CategoryName);
                    }
                    Console.WriteLine("--------------------------------------------------------------");
                }
            }
            catch { }
            // --------Delete Product details

            try
            {
                Console.WriteLine("\n");
                Console.WriteLine("Do you want delete product? (Y/N)");
                if (char.Parse(Console.ReadLine().ToUpper()) == 'Y')
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Enter product id to Delete");
                    Console.WriteLine("\n");
                    Product Getproduct = new Product();
                    Getproduct = productManager.GetProduct(int.Parse(Console.ReadLine()));
                    Console.WriteLine("ProductId - {0},\n ProductName - {1},\n Description - {2},\n Price - {3},\n Quantity - {4},\n Category name - {5}",
                       Getproduct.ProductId, Getproduct.ProductName, Getproduct.Description, Getproduct.Price, Getproduct.Quantity, Getproduct.Category.CategoryName);

                    Console.WriteLine("Product Deleted successfully for this productId - {0}", productManager.DeleteProduct(Getproduct.ProductId));
                }
            }
            catch { }

            // --------Display All Product details
            try
            {
                Console.WriteLine("------------Display All Product details----------");               
                List<Product> Getproducts = new List<Product>();
                Getproducts = productManager.GetProducts();
                foreach (Product product in Getproducts)
                {
                    Console.WriteLine(" ProductId - {0},\n ProductName - {1},\n Description - {2},\n Price - {3},\n Quantity - {4},\n Category name - {5}",
                       product.ProductId, product.ProductName, product.Description, product.Price, product.Quantity, product.Category.CategoryName);
                    Console.WriteLine("\n");
                }
                Console.WriteLine("--------------------------------------------------------------");
            }
            catch { }
            // --------------------------------End  Manage Product details --------------------------------

            // --------------------------------Start  Manage Cart details --------------------------------
            Cart cart = new Cart();
            CartManagement cartManagement = new CartManagement();
            string CartCustomerID;
            string CartCategoryName;
            Customer cartCustomer = new Customer();
            Product cartproduct;
            List<Product> cartProducts = new List<Product>();
            categories = categoryManagement.GetCategories();
            categoriesName = categories.Select(r => r.CategoryName).ToList();
            List<Product> products = productManager.GetProducts();
            try
            {
                Console.WriteLine("\n");
                Console.WriteLine("---Purchase products---");
                while (true)
                {
                    Console.WriteLine("Enter a customer ID");
                    CartCustomerID = Console.ReadLine();
                    cartCustomer = customerManagement.GetCustomers().Where(X => X.CustomerId == int.Parse(CartCustomerID)).FirstOrDefault();
                    if (cartCustomer != null)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter valid customer Id!!!!!");
                        continue;
                    }

                }
                while (true)
                {
                    Console.WriteLine("Select category name from this list => {0}", string.Join(", ", categories.Select(r => r.CategoryName)).ToString());

                    CartCategoryName = Console.ReadLine();
                    if (categories.Select(X => X.CategoryName.ToUpper() == CartCategoryName.ToUpper()).FirstOrDefault())
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter valid category name");
                        continue;
                    }
                }

                while (true)
                {
                    Console.WriteLine("Select a product for above category from this list => {0}", string.Join(",", products.Select(r => r.ProductName)).ToString());
                    cartproduct = new Product();
                    string prod = Console.ReadLine();
                    cartproduct = products.Where(X => X.ProductName.ToUpper() == prod.ToUpper()).FirstOrDefault();
                    if (cartproduct != null)
                    {
                        
                        cartProducts.Add(cartproduct);
                        Console.WriteLine("Do you want to purchase next product (Y/N)?");
                        if (char.Parse(Console.ReadLine().ToUpper()) == 'N')
                        {
                            
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Enter valid product ID!!!!!");
                        continue;
                    }

                }

                Console.WriteLine("\n");
                Console.WriteLine("Add to cart ? (Y/N)");
                if (char.Parse(Console.ReadLine().ToUpper()) == 'Y')
                {
                    Console.WriteLine("--------------------------------------------------------------");
                    Console.WriteLine("Your cart details.");
                    cart = cartManagement.AddCart(cartCustomer, cartProducts);
                    Console.WriteLine(" CustomerId - {0},\n CustomerName - {1},\n CustomerEmail - {2},\n CustomerContact - {3},\n CustomerAddress - {4}",
                      cart.Customer.CustomerId, cart.Customer.CustomerName, cart.Customer.CustomerEmail, cart.Customer.CustomerContact, cart.Customer.CustomerAddress);
                    Console.WriteLine("\n");

                    foreach (Product product in cart.Products)
                    {
                        Console.WriteLine(" ProductId - {0},\n ProductName - {1},\n Description - {2},\n Price - {3},\n Quantity - {4},\n Category name - {5}",
                           product.ProductId, product.ProductName, product.Description, product.Price, product.Quantity, product.Category.CategoryName);
                        Console.WriteLine("\n");
                    }

                    Console.WriteLine("Total amount after discount - {0}", cart.TotalPrice);
                    Console.WriteLine("--------------------------------------------------------------");
                    Console.WriteLine("\n");
                    var paymentoption = (Payment[])Enum.GetValues(typeof(Payment));                    
                    Console.WriteLine("Select payment option - {0}", string.Join(", ", paymentoption.Select(r => r)).ToString());
                    cart.PaymentType = Console.ReadLine();
                    Console.WriteLine("\n");
                    Console.WriteLine("Payment sucessful..");
                    Console.WriteLine("\n");
                    Invoice invoice = new Invoice(cart, true);
                    Console.WriteLine("\n");
                    Console.WriteLine("\n");
                    Console.WriteLine("Invoice of the purchase {0}", invoice.DisplayInvoice());
                    Console.ReadKey();

                }
                else
                {
                    Console.WriteLine("Purchase unsuccessful");
                    Console.ReadKey();
                }

            }
            catch { }


            // --------------------------------End  Manage Cart details --------------------------------
            Console.ReadKey();
        }
    }

}
