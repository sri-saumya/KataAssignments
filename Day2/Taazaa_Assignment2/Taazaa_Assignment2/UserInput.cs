using System;
using System.Collections.Generic;
using System.Text;

namespace Taazaa_Assignment2
{
    public  class UserInput
    {
  

        public static void input()
        {
            Console.WriteLine("                    PRODUCT  CATALOG");
            Console.WriteLine("");

            ProductOperations po = new ProductOperations();
            CategoryOperation co = new CategoryOperation();



            while (true)
            {

                Console.WriteLine("ENTER : CATEGORY || Product || Exit : ");
                string choice = Console.ReadLine();
                Console.WriteLine("");


                if (choice.ToUpper() == "PRODUCT")

                {

                    Console.WriteLine("Select(1,2,3,4,5) : 1.GET all products || 2.SEARCH product by ID|| 3.ADD product || 4.DELETE product || 5.Exit");
                    string Pchoice = Console.ReadLine();
                    Console.WriteLine("");

                    if (Pchoice == "1")
                    {
                        ProductOperations.GetProduct();

                    }
                    else if (Pchoice == "2")
                    {
                        Console.WriteLine("Enter id : ");
                        int id = Int32.Parse(Console.ReadLine());
                        po.SearchById(id);

                    }
                    else if (Pchoice == "3")
                    {
                        Console.WriteLine("Enter name");
                        var cn = Console.ReadLine();

                        Console.WriteLine("Enter short code");

                        var sc = Console.ReadLine();



                        if (sc.Length <= 4 )
                        {
                            Console.WriteLine("Enter description");
                            var d = Console.ReadLine();
                            Console.WriteLine("Enter selling price");
                            var s = Int32.Parse(Console.ReadLine());
                            if (s > 0)
                            {
                                ProductOperations.AddProduct(cn, sc, d, s);
                            }
                            else
                            {
                                Console.WriteLine("Selling Price Code Should be > 0");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Source Code Should be <= 4");
                        }


                    }
                    else if (Pchoice == "4")
                    {
                        ProductOperations.DeleteProduct();
                        Console.WriteLine("Product Deleted");

                    }
                    else if (Pchoice == "5")
                    {
                        Console.WriteLine("Please try again");

                    }

                }



                if (choice.ToUpper() == "CATEGORY")

                {

                    Console.WriteLine("Select(1,2,3,4,5) : 1.GET all category || 2.SEARCH category || 3.ADD Category || 4.Delete category || 5.Exit  ");
                    string Pchoice = Console.ReadLine();
                    Console.WriteLine("");

                    if (Pchoice == "1")
                    {
                        CategoryOperation.ListOfAllCategories();


                    }
                    else if (Pchoice == "2")
                    {
                        CategoryOperation.SearchCategory();

                    }
                    else if (Pchoice == "3")
                    {

                        again:
                       
                        Console.WriteLine("Enter name");
                        var cn = Console.ReadLine();
                        if (String.IsNullOrEmpty(cn))
                        {
                            Console.WriteLine("Please enter name.");
                            goto again;
                        }
                        

                        Console.WriteLine("Enter short code");
                        var sc = Console.ReadLine();
                        Console.WriteLine("Enter description");
                        var d = Console.ReadLine();
                        CategoryOperation.AddCategory(cn, sc, d);
                    }
                    else if (Pchoice == "4")
                    {
                      
                        
                        CategoryOperation.DeleteCategory();
                        Console.WriteLine("Category Deleted");

                    }
                    else if (Pchoice == "5")
                    {
                        Console.WriteLine("EXIT from Category");
                        
                    }
                   
                }

                if (choice.ToUpper() == "EXIT")
                {
                    Console.WriteLine("THANKYOU  !!");
                    break;
                }


            }

        }
    }
}
