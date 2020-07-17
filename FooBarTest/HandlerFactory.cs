using System;
using FooBarTest.Handlers;
namespace FooBarTest
{
    public static class HandlerFactory
    {
        public static Handler GetHandler(int number)
        {
            if(number % 15 == 0)
            {
                return new FifteenHandler();
            }
            else if (number % 3 == 0)
            {
                return new ThreeHandler();
            }
            else if (number % 5 == 0)
            {
                return new FiveHandler();
            }
            else
            {
                return new Handler();
            }
        }
    }
}
