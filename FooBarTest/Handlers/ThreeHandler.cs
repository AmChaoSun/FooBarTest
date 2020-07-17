using System;
using FooBarTest.Handlers;

namespace FooBarTest
{
    public class ThreeHandler : Handler
    {
        public ThreeHandler() : base()
        {
        }

        public override string GetResult()
        {
            return "Foo";
        }
    }
}
