using System;

namespace ProjectTemplate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MethodTemplate();

            Console.ReadKey();

        }

        static void MethodTemplate()
        {
            Console.WriteLine("Hello AGAIN World!");
        }

        class ClassTemplate
        {
            public int Num { get; set; }

        }
    }
}



