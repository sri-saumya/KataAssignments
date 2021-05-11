using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taazaa_Assignment2
{
    public class ProductOperations : ProductStore
    {
      


        //show products
        public static void GetProduct()
        {
            
            Console.WriteLine("ProductID\t\tName\t\tShortCode\t\tDescription");
            Console.WriteLine(" ");
            foreach (var item in products)
            {
                Console.WriteLine(item.ProductID + "\t\t" + item.Name + "\t\t" + item.ShortCode + "\t\t\t" + item.Description);
            }
        }

      



        //Add new product
        public static void AddProduct(string pName, string pCode, string desc,int sp)
        {

            CategoryOperation.categories.ForEach((i) =>
            {
                Console.WriteLine(i.Category_ID + i.Name);
            });
            List<Category> productCategories = new List<Category>();
            string choice;
            do
            {
                Console.WriteLine("GIVE CATEGORY ID ");
                int id = Convert.ToInt32(Console.ReadLine());
                var data = CategoryOperation.categories.Single((a) => a.Category_ID == id);
                if (data != null)
                    productCategories.Add(data);
                Console.WriteLine("FOR ADDING MORE CATEGORY : yes , else : no ");
                choice = Console.ReadLine();
            } while (choice == "yes");




            products.Add(new Products
            {

                ProductID = Products.ID,
                Name = pName,
                ShortCode = pCode,
                Description = desc,
                SellingPrice = sp,
                Category = productCategories,

            });
            ListOfProducts();
        }

        public static void ListOfProducts()
        {
            Console.WriteLine("ProductID" + "\t" + "Product Name" + "\t\t" + "Product Short Code" + "\t" + "Product Description" + "\t" + "Product Selling Price" + "\t" + "Category" + "\n");
            products.ForEach((i) =>
            {
               
                    string s = "";
                    i.Category.ForEach(c => {
                        s += c.Name + ", ";
                    });

                Console.WriteLine($"{i.ProductID} \t\t {i.Name}\t\t\t {i.ShortCode}\t\t\t\t{i.Description}\t\t\t{i.SellingPrice}\t\t{s}");
            });
        }




        //Search new Product
        public void SearchById(int id)
        {
      
                var d = products.FindAll((i) => i.ProductID == id);
                if (d.Count > 0)
                {
                    d.ForEach((i) =>
                    {
                        Console.WriteLine($"{i.ProductID} \t\t {i.Name}\t\t{i.Manufacturer}\t\t{i.Description}\t\t{i.SellingPrice}");
                    });
                }
                else
                {
                    Console.WriteLine("Id Not Found");
                }
         
        }


        public static void DeleteProduct()
        {
            Console.WriteLine("Please select an option to delete");
            Console.Write("1. delete by Id\t");
            Console.WriteLine(" ");
            Console.WriteLine("2. delete by Short Code\t");
            Console.WriteLine(" ");



            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Enter product id to delete the product");
                int id = Convert.ToInt32(Console.ReadLine());



                products.RemoveAt(id - 1);
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter product short code to delete the product");
                string shortcode = Console.ReadLine();
                var producttoremove = products.Single(r => r.ShortCode == shortcode);
                products.Remove(producttoremove);
            }



        }

    }
}
