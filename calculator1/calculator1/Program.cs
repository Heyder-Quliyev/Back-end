using System;


namespace calculator1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("please, add first number:");
            int x1 = Convert.ToInt32(Console.ReadLine());
            if (x1 < 0)
            {
                Console.Write("please, add first number:");
                x1 = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("please, add Second number:");
            int x2 = Convert.ToInt32(Console.ReadLine());
            if (x2 < 0)
            {
                Console.Write("please, add second number:");
                x1 = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Add Symbol");
            char symbol = Convert.ToChar(Console.ReadLine());



            //int result = x1 + x2;
            //Console.WriteLine(result + " Result");
            //    if (result > 0 && result < 1000)
            //    {
            //        Console.WriteLine("The sum is  than smaller 500");
            //    }
            //    else if (result > 50 && result < 100)
            //    {
            //        Console.WriteLine("The sum is smaller than 1000");
            //    }
            //    else { 
            //    Console.WriteLine("The sum is greater than 1000");
            //}


            if (symbol == '+')
            {
                Console.WriteLine((x1 + x2) + " result");
            }
            else if (symbol == '-')
            {
                Console.WriteLine((x1 - x2) + " result");
            }
            else if (symbol == '/')

            {
                if (x2 == 0)
                {
                    Console.WriteLine("eror! can't write 0 ");
                }

                Console.WriteLine((x1 / x2) + " Result");
            }
            else if (symbol == '*')
            {
                Console.WriteLine((x1 * x2) + " Result");
            }

            else if (symbol == '^' && x2 == 2)
            {
                Console.WriteLine(x1 * x1);
            }
            else if (symbol == '^' && x2 == 3)
            {
                Console.WriteLine(x1 * x1 * x1);
            }
            else if (symbol == '^' && x2 == 4)
            {
                Console.WriteLine(x1 * x1 * x1 * x1);

            }
            else if(symbol == '%')
            {
                Console.WriteLine(x1%x2);
            }


        }
    }
}
