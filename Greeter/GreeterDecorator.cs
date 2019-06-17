namespace TryAutoFac.Decorator
{
    public abstract class GreeterDecorator : IGreeter
    {
        protected IGreeter _greeter;
        public GreeterDecorator(IGreeter greeter)
        {
            _greeter = greeter;
        }
        public virtual string Say(string message)
        {
            return _greeter.Say(message);
        }
    }
}