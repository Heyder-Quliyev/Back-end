using System;

namespace firstbackend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string testHello = ("Hello World And Guys");
            char x = 'A';
            float testFloat = 1 / 3F;
            double testDouble = 1 / 3D;
decimal testDecimal = 1 / 3M;

            Console.WriteLine(testFloat);
            Console.WriteLine(testDouble);
            Console.WriteLine(testDecimal);

            byte ageByte = +15;
            int ageInt = -15;
            long ageLong = -15;

            Console.WriteLine(ageByte);
            Console.WriteLine(ageInt);
            Console.WriteLine(ageLong);


            Console.WriteLine(testHello);
            Console.WriteLine(testHello);

        }
    }
}
