using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            Dictionary<int, string> brands = new Dictionary<int, string>();
            List<object> phonelist = new List<object>();
            phonelist.Add(new { name = "xs", brand = "iphone", price = 500 });
            phonelist.Add(new { name = "s20", brand = "samsung", price = 300 });
            brands.Add(1, "iphone");
            brands.Add(2, "samsung");
            brands.Add(3, "xiaomi");
            brands.Add(4, "oppo");
            brands.Add(5, "huawei");
            while (true)
            {
                Console.WriteLine("1. Please, Add Phone Brand: ");
                Console.WriteLine("2. Please, Add Phone: ");
                Console.WriteLine("3. As to Information Phone: ");
                Console.WriteLine("Which do you want phone?");
                int number = Convert.ToInt32(Console.ReadLine());

                switch (number)
                {
                    case 1:
                        Console.Write("Add Key: ");
                        int key = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Add Brand Name: ");
                        string name = Console.ReadLine();

                        brands.Add(key, name);
                        Console.WriteLine("Added");
                        break;


                    case 2:
                        Console.WriteLine("Add Phone Name: ");
                        string phoneName = Console.ReadLine();
                        Console.WriteLine("Add Phone Brand: ");
                        string brandsName = Console.ReadLine();
                        Console.WriteLine("Add Phone Price: ");
                        int price = Convert.ToInt32(Console.ReadLine());
                        bool add = false;
                        foreach (var item in brands)
                        {
                            if (brandsName.ToLower() == item.Value.ToLower())
                            {
                                phonelist.Add(new { name = phoneName, brand = brandsName, price = price });
                                add = true;
                                Console.WriteLine("Added");
                            }



                        }
                        if (!add)
                        {
                            Console.WriteLine("Please, add the correct brand!");

                        }

                        break;
                    case 3:
                        foreach (var item in brands)

                        {
                            Console.WriteLine(item.Key + item.Value);
                        }

                        foreach (var item in brands)
                        {
                            if (number == item.Key)
                            {
                                foreach (dynamic item2 in phonelist)
                                {
                                    if (item.Value.ToLower().Trim() == item2.brand.ToLower().Trim())
                                    {
                                        Console.WriteLine(item2);
                                        break;
                                    }

                                }


                            }
                        }
                        break;

                }


            }

        }
    }
}