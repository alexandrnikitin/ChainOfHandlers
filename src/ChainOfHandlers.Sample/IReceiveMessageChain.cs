namespace ChainOfHandlers.Sample
{
    public interface IReceiveMessageChain
    {
        void Receive(ReceiveMessageContext context);
    }
}