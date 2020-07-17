using System;

namespace FooBarTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Demo
            var inputArr = new int[] { 1, 3, 5, 14, 15, 16 };

            
            foreach(int input in inputArr)
            {
                var handler = HandlerFactory.GetHandler(input);
                handler.Number = input;
                Console.WriteLine("input : {0}, output: {1}", input, handler.GetResult());
            }
        }
    }
}
