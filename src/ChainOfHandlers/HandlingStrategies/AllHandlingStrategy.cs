using System.Collections.Generic;

using ChainOfHandlers.Interfaces;

namespace ChainOfHandlers.HandlingStrategies
{
    public class AllHandlingStrategy<TContext, THandler> : IHandlingStrategy<TContext, THandler>
        where THandler : IHandler<TContext>
    {
        public void Process(IEnumerable<THandler> handlers, TContext context)
        {
            foreach (var handler in handlers)
            {
                handler.Handle(context);
            }
        }
    }
}