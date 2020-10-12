using System;

namespace translator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Add(1,5));
        }

        public static int Add(int x, int y) {
            return x+y;
        }
    }
}
