using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] array = { 4, 5, 2, 1, 5, 2, 5, 3, 5, 6, 2, 1, 6, 2, 6, 2, 5, 3, 2, 7, 4, 6, 4, 5, 6, 2, 5, 6, 3, 7, 3, 7 };


            //Console.WriteLine(array[2]);
            //Console.WriteLine(array);

            //Console.WriteLine(array.Length);


            ///1
            

            int sum = 0;

            for (int i = 0; i < array.Length; i++)

            {
                sum += array[i];

        }

        Console.WriteLine("sum: " +sum);

            ///2
            

            int cont = 0;

            foreach(var item in array)
            {

                if (item == 5) 
                {
                    cont++;
                }

            }
            Console.WriteLine("cont: " +cont);

            ///3
            

            HashSet<int> set = new HashSet<int>();
            for (int i = 0;i < array.Length; i++)
            {
                set.Add(array[i]);
            }
            foreach(var item in set)
            {
                Console.WriteLine(item+ ",");
            }



            //4
            int count = 0;

            int a = array[0];

            for (int i = 0; i< array.Length; i++ )
            {
                if(array[i] > a )
                {
                    a = array[i];
                }
            }
            Console.WriteLine(a);

            for (int i = 0; i< array.Length; i++ )
            {
                if (array[i] == a)
                { count++; }
                    
                        }
            Console.WriteLine("repeat number " +count);



            //5

            Random random = new Random();
            int randomNumber = random.Next(1, 10);
            bool b = false;
            foreach (var item in array)
            { if (item == randomNumber)
                {
                    b = true;
                }
                        }
 Console.WriteLine(b);

            //6

            //string = Console.ReadLine();
            string name = "Heyder";
            int k = name.Length;
            bool var = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (k == array[i])
                {
                    var = true;
                }

            }
            Console.WriteLine("our name letter count " +var);



            //7

            int v = 0, index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] %3 == 0)
                {
                     v = array[i];
                    index= i;
                    break;
                }
            }

            Console.WriteLine("index " +index);
            //Console.WriteLine(array.Length);


            //8

            int max = array[0];
            int maximum = 0;

            for(int i = 0;i < array.Length; i++)
            {
                if (array[i]> max)
                {
                   max = array[i];
                    maximum = i;
                }
                    }
            Console.WriteLine("max "+ maximum);


            //9

            for (int i = 0; i < array.Length; i++)
            {


                if (array[i]==4)
                    {
                    Console.WriteLine(i);

                }

            }

















        }
    }
}
