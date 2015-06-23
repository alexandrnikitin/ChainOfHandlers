namespace ChainOfHandlers.Sample
{
    public interface IAzureReceiveMessageChain
    {
        void Receive(ReceiveMessageContext context);
    }
}