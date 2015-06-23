using System;

namespace ChainOfHandlers.Sample
{
    internal class MessageHandler1 : IReceiveMessageHandler
    {
        private readonly IDependency1 _dependency;

        public MessageHandler1(IDependency1 dependency)
        {
            _dependency = dependency;
        }

        public void Handle(ReceiveMessageContext context)
        {
            Console.WriteLine("Handler1.Handle");
        }
    }
}