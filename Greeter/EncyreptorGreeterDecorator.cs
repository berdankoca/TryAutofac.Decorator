using System;

namespace TryAutoFac.Decorator
{
    public class EnycreptorGreetorDecorator : GreeterDecorator
    {
        public EnycreptorGreetorDecorator(IGreeter greeter)
            : base(greeter)
        {

        }

        public override string Say(string message)
        {
            var result = $"Hi from Enycreptor: { base.Say(message) }";
            Console.WriteLine(result);

            return result;
        }
    }
}