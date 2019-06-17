using System;

namespace TryAutoFac.Decorator
{
    public class Greeter : IGreeter
    {
        public string Say(string message)
        {
            var result = $"Hi: { message }";
            Console.WriteLine(result);

            return result;
        }

    }
}