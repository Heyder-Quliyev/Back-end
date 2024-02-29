using System.Security.Cryptography.X509Certificates;

namespace studentlist
{
    internal class Program
    {

        public static List<Book> books = new List<Book>();

        static void Main(string[] args)
        {
            Book book = new Book();
            book.bookName = "National Geografic Wild";
            book.bookAuthor = "National Wild";
            book.bookId = 1245;
            book.bookjanr = "Scientific";
            books.Add(book);





            Console.WriteLine(book.bookAuthor + ", " + book.bookjanr + "," + book.bookName + "" + "," + book.bookId);

            while (true)
            {

                Console.WriteLine("Please, selct menu");
                Console.WriteLine("1. add book");
                Console.WriteLine("2. show book");
                Console.WriteLine("3. delete book");
                Console.WriteLine("4. update information of book");
                Console.WriteLine("5. search book");
                Console.WriteLine("6. exit ");

                int menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:

                        Add();

                        break;
                    case 2:

                        ShowBook();



                        break;
                    case 3:
                        Console.WriteLine("Add the book to be deleted");
                        string name1 = Console.ReadLine();
                        bool test = false;
                        foreach (var item in books)
                        {
                            if (name1 == item.bookName)
                            {
                                test = true;
                                books.Remove(item);
                                Console.WriteLine(" deleted ");
                                break;
                            }

                        }
                        if (test == false)
                        {
                            Console.WriteLine(" Not found! ");
                        }


                        break;

                    case 4:
                        Edit();

                        break;

                    case 5:
                        Console.WriteLine("please, write a book name");
                        string search = Console.ReadLine();
                        foreach (var item in books)
                        {
                            if (search == item.bookName)
                            {
                                Console.WriteLine(item.bookName + ", " + item.bookjanr + " , " + item.bookAuthor + " , " + item.bookId);
                            }
                        }


                        break;



                }
            }
     }

        public static void ShowBook()
        {
            foreach (var item in books)
            {
                Console.WriteLine(item.bookName + ", " + item.bookjanr + " , " + item.bookAuthor + " , " + item.bookId);
            }
        }
        public static void Add()
        {
            Console.WriteLine("write the book count");
            int say = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < say; i++)
            {
                Console.WriteLine("book name ");
                string name = Console.ReadLine();
                Console.WriteLine("author name ");
                string muellif = Console.ReadLine();
                Console.WriteLine("book janr ");
                string janr = Console.ReadLine();

                Random random = new Random();
                Book book1 = new Book();
                book1.bookName = name;
                book1.bookjanr = janr;
                book1.bookAuthor = author;
                book1.bookId = random.Next(1, 1000);
                books.Add(book1);
                Console.WriteLine((i + 1) + " added book");

            }

        }
        public static void Edit()
        {
            Console.WriteLine("please add the book name: ");
            string bookName = Console.ReadLine();
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].bookName == bookName)
                {
                    Console.WriteLine("new name ");
                    string newName = Console.ReadLine();
                    books[i].bookName = newName;
                    Console.WriteLine("changed");
                }
            }



        }
    }
}