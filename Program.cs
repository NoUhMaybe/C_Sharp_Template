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
            public int Num1 { get; set; }
            public int Num2 { get; init; } //Can only be set inside an object initializer after construction
            public int Num3 { get; private set; } //Can only be set inside the class methods

            public int Sum()
            {
                return Num1 + Num2 + Num3;
            }

        }
    }
}



