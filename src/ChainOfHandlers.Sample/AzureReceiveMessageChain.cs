using System.Collections.Generic;

using ChainOfHandlers.Interfaces;

namespace ChainOfHandlers.Sample
{
    internal class AzureReceiveMessageChain : ChainOfHandlers<ReceiveMessageContext, IReceiveMessageHandler>, IAzureReceiveMessageChain
    {
        public AzureReceiveMessageChain(
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