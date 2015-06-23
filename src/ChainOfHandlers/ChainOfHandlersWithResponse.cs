using System.Collections.Generic;

using ChainOfHandlers.Interfaces;

namespace ChainOfHandlers
{
    public abstract class ChainOfHandlersWithResponse<TContext, THandler, TReturn>
        where THandler : IHandler<TContext, TReturn>
    {
        private readonly IEnumerable<THandler> _handlers;

        private readonly IHandlingWithResponseStrategy<TContext, THandler, TReturn> _handlingStrategy;

        protected ChainOfHandlersWithResponse(
            IHandlingWithResponseStrategy<TContext, THandler, TReturn> handlingStrategy, 
            IEnumerable<THandler> handlers)
        {
            _handlingStrategy = handlingStrategy;
            _handlers = handlers;
        }

        protected TReturn Process(TContext context)
        {
            return _handlingStrategy.Process(_handlers, context);
        }
    }
}