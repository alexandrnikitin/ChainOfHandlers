using System.Collections.Generic;

using ChainOfHandlers.Interfaces;

namespace ChainOfHandlers
{
    public abstract class ChainOfHandlers<TContext, THandler>
        where THandler : IHandler<TContext>
    {
        private readonly IEnumerable<THandler> _handlers;

        private readonly IHandlingStrategy<TContext, THandler> _handlingStrategy;

        protected ChainOfHandlers(
            IHandlingStrategy<TContext, THandler> handlingStrategy, 
            IEnumerable<THandler> handlers)
        {
            _handlingStrategy = handlingStrategy;
            _handlers = handlers;
        }

        protected void Process(TContext context)
        {
            _handlingStrategy.Process(_handlers, context);
        }
    }
}