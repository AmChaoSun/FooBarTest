using System;
namespace FooBarTest.Handlers
{
    public class Handler : IHandler
    {
        //I think it would be more flexible to not setting number in the constrcutor
        public Handler() { }
        public int Number { get; set; }

        public virtual string GetResult()
        {
            return Number.ToString();
        }
    }
}
