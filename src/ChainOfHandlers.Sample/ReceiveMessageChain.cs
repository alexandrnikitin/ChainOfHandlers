using System.Collections.Generic;

using ChainOfHandlers.Interfaces;

namespace ChainOfHandlers.Sample
{
    internal class ReceiveMessageChain : ChainOfHandlers<ReceiveMessageContext, IReceiveMessageHandler>, IReceiveMessageChain
    {
        public ReceiveMessageChain(
            IHandlingStrategy<ReceiveMessageContext, IReceiveMessageHandler> handlingStrategy,
            IEnumerable<IReceiveMessageHandler> handlers)
            : base(handlingStrategy, handlers)
        {
        }

        public void Receive(ReceiveMessageContext context)
        {
            Process(context);
        }
    }
}