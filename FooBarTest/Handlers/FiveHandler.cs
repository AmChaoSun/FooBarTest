using System;
namespace FooBarTest.Handlers
{
    public class FiveHandler : Handler
    {
        public FiveHandler() : base()
        {
        }

        public override string GetResult()
        {
            return "Bar";
        }
    }
}
