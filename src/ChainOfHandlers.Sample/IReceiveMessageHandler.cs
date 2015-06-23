using ChainOfHandlers.Interfaces;

namespace ChainOfHandlers.Sample
{
    internal interface IReceiveMessageHandler : IHandler<ReceiveMessageContext>
    {
    }
}