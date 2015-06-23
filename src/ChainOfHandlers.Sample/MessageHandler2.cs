using System;

namespace ChainOfHandlers.Sample
{
    internal class MessageHandler2 : IReceiveMessageHandler
    {
        private readonly IDependency2 _dependency;

        public MessageHandler2(IDependency2 dependency)
        {
            _dependency = dependency;
        }

        public void Handle(ReceiveMessageContext context)
        {
            Console.WriteLine("Handler2.Handle");
        }
    }
}