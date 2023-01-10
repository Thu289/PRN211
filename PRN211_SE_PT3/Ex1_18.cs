using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN211_SE_PT3
{
    internal class Ex1_18
    {

        public static void Mains(string[] args)
        {
            Shop shop=new Shop();
            shop.products=new List<Product>();
            int option = 0;
            while(option!=5)
            {
                Console.WriteLine("1. Add new product: ");
                Console.WriteLine("2. Remove product");
                Console.WriteLine("3. Iterate product");
                Console.WriteLine("4. Search product");
                Console.WriteLine("5. Exit");
                Console.Write("Input your option: ");
                if (int.TryParse(Console.ReadLine(), out option) && option>=1 && option<=5)
                {
                    switch(option)
                    {
                        case 1:
                            shop.addProduct();
                            break;
                        case 2:
                            shop.removeProduct();
                            break;
                        case 3:
                            shop.iterateProductList();
                            break;
                        case 4:
                            shop.searchProduct();
                            break;
                        default: return;
                    }
                }
            }
        }

        class Product
        {
            string name, description;
            double price;
            int[] rate;
             
            public Product() { }

            public Product(string name, string description, double price, int[] rate)
            {
                Name = name;
                Description = description;
                Price = price;
                Rate = rate;
            }

            public string Name
            {
                get { return name;}
                set { name = value; }
            }

            public string Description
            {
                get { return description;}
                set { description = value; }
            }
            public double Price
            {
                get=> price;
                set
                {
                    if (value>0 && value <= 100)
                    {
                        price = value;
                    }
                    else
                    {
                        Console.WriteLine("Price must be >0 and <=100!");
                    }
                }
            }

            public int[] Rate
            {
                get => rate;
                set
                {
                    bool validate = true;
                    foreach(int item in value)
                    {
                        if (item<1 || item > 5)
                        {
                            validate= false;
                            break;
                        }
                    }
                    if (validate) rate= value;
                }
            }

            public void viewInfo()
            {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Description: " + description);
                Console.WriteLine("Price: " + price);
            }

            public double averangeRate()
            {
                int s = 0;
                foreach(int item in rate)
                {
                    s += item;
                }
                return s/rate.Length;
            }
        }

        class Shop
        {
            List<Product> productList;

            public Shop() { }

            public List<Product> products { 
                get { return productList; } 
                set => productList = value;
            }

            public void addProduct()
            {
                Product p= new Product();
                Console.Write("Input product name: ");
                p.Name=Console.ReadLine();
                Console.Write("Input product description: ");
                p.Description = Console.ReadLine(); 
                Console.Write("Input product price: ");
                p.Price = double.Parse(Console.ReadLine());
                Console.Write("Input product rate: ");
                int[] rate= new int[1];
                rate[0]=int.Parse(Console.ReadLine());
                p.Rate = rate;
                productList.Add(p);
            }

            public void removeProduct()
            {
                if (productList.Count == 0) return;
                Console.Write("Let's input name of product you want to delete: ");
                string name=Console.ReadLine();
                int index = 0;
                for (int i=0; i<productList.Count; i++)
                {
                    if (productList[i].Name.Equals(name))
                    {
                        productList.RemoveAt(i);
                    }
                }
            }

            public void iterateProductList()
            {
                if(productList.Count == 0) return;
                foreach(Product p in productList)
                {
                    p.viewInfo();
                    Console.WriteLine("Averange rate: " + p.averangeRate());
                }
            }

            public void searchProduct()
            {
                if(productList.Count==0) return;
                Console.Write("Input price 1: ");
                if(double.TryParse(Console.ReadLine(), out double price1))
                {
                    Console.Write("Input price 2:");
                    if (double.TryParse(Console.ReadLine(), out double price2))
                    {
                        double min = (price1>price2)? price2: price1;
                        double max= (price2>price1)? price2: price1;
                        foreach(Product p in productList)
                        {
                            if (p.Price>=min && p.Price<=max)
                            {
                                p.viewInfo();
                            }
                        }
                    }
                }
                
            }
        }
    }
}
