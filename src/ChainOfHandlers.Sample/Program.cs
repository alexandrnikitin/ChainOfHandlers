using Autofac;

using ChainOfHandlers.HandlingStrategies;

namespace ChainOfHandlers.Sample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            // register some strategies
            builder.RegisterGeneric(typeof(AllHandlingStrategy<,>));
            builder.RegisterGeneric(typeof(ReturnManyStrategy<,,>));
            builder.RegisterGeneric(typeof(ReturnNonNullStrategy<,,>));

            // register dependencies
            builder.RegisterType<Dependency1>().As<IDependency1>();
            builder.RegisterType<Dependency2>().As<IDependency2>();

            // register handlers
            builder.RegisterType<MessageHandler1>();
            builder.RegisterType<MessageHandler2>();

            builder.Register(
                c =>
                new ReceiveMessageChain(
                    c.Resolve<AllHandlingStrategy<ReceiveMessageContext, IReceiveMessageHandler>>(),
                    new IReceiveMessageHandler[] { c.Resolve<MessageHandler1>(), c.Resolve<MessageHandler2>() }))
                .As<IReceiveMessageChain>();

            using (var container = builder.Build())
            {
                var chain = container.Resolve<IReceiveMessageChain>();
                chain.Receive(new ReceiveMessageContext());
            }
        }
    }
}