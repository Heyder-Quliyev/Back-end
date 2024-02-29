using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentlist
{
    internal class Book
    {

        public string bookName;
        public string bookAutor;  
        public int bookId;
        public string bookJanr;


        public static void Add()
        {
            Console.WriteLine("How many do you add books?");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("name of book");
                string name = Console.ReadLine();
                Console.WriteLine("name of autor");
                string autor = Console.ReadLine();
                Console.WriteLine("boob id");
                string id = Console.ReadLine();
                Console.WriteLine("janr of book");
                string janr = Console.ReadLine();


                Random random = new Random();
                Book book1 = new Book();
                book1.bookName = name;
                book1.bookAutor = autor;
                book1.bookJanr = janr;
                book1.bookId = random.Next(1, 1000);
                books.Add(book1);
                Console.WriteLine("Added");

            }
        }
        public static void Edit()
        {

            Console.WriteLine("Please, want to change add name of book");
            string bookName = Console.ReadLine();
            for (int i = 0; i<book.Count; i++ )
            {
                if(book[i].bookName == bookName)
                {
                    Console.WriteLine("");

                }
            }

        }


                }
    }