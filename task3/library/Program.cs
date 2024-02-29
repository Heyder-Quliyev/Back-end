using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Console.WriteLine("add to string");
            // string value = Console.ReadLine();
            //bool a=  IsContainDigit(value);
            // Console.WriteLine(a);



            //foreach (int i in netice)
            //{  
            //    Console.WriteLine(i); 

            //}


            //int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //int[] netice = GetValueIndexes('a', "Azerbaijan");
            //int[] netice2 = GetValueIndexes (6, array);












            //int a = 5;
            //Change(ref a);
            //int d = a + 20;
            //Console.WriteLine(d);



            //Console.WriteLine(IsOdd(6));
            //Console.WriteLine(IsEven(7));
            //Console.WriteLine(GetValueIndexes('d'));


            //calculatorOne(45, 55);
            //calculatorOne(12, 72);

            //int a = calculatorTwo(45, 55) + 35;
            //Console.WriteLine(a);


            //int h = 10;
            //five(ref h);
            //Console.WriteLine(h);

            int a;           // out başlanğıc qiymət tələb etmir lakin, ref başlağıc bir qiymət tələb edir
            five(out a);
            Console.WriteLine(a);

        }




        static void five (/*ref*/ out int u)
        {
            u = 5;
        }





        //static int[] GetValueIndexes(int a, int[] b)
        //{

        //    int[] result = { };
        //    for (int i = 0; i < b.Length; i++)
        //    {
        //        if (a == b[i])
        //        {
        //            result = result.Append(i).ToArray();
        //        }

        //    }

        //    return result;












            //static bool IsContainDigit(string word)
            //{
            //    for (int i = 0; i < word.Length; i++)
            //    {
            //        if (word[i] >= 48 && word[i]<=57 );
            //        {
            //            return true;

            //        }
            //    }
            //    return false;
            //}



            //static int[] GetValueIndexes(char a, string b)
            //{
            //    int[] result = { };

            //    for (int i = 0; i < b.Length; i++)
            //    {
            //        if (a == b[i])
            //        {
            //            result = result.Append(i).ToArray();
            //        }
            //    }

            //    return result;
            //}













            //public static void calculatorOne(int x, int y)
            //{
            //    int sum = x + y;
            //    Console.WriteLine(sum);

            //}


            //public static int calculatorTwo(int x, int y)
            //{ 
            //    int sum = (x + y);
            //    Console.WriteLine(sum);
            //    return sum; 
            //}

            //       static bool IsOdd(int a)
            //       {
            //           if (a %2 ==1)
            //               {
            //               return true;
            //           }

            //           else { 
            //           return false;
            //           }
            //       }



            //       static bool IsEven(int b)
            //       { if (b %2 ==0)

            //           {  
            //               return true;

            //           } 

            //       else
            //           { 
            //           return false;

            //           }

            //       }


            //       static int GetValueIndexes(char a)
            //       {

            //           string name = "heyder";
            //           for (int i = 0; i< name.Length; i++)
            //           {
            //               if (a == name[i])
            //               {
            //                   return i;
            //               }


            //           }

            //return 0;



            //       }  



            //public static void Change(ref int c)
            //{ c = 20; }




        }
}
