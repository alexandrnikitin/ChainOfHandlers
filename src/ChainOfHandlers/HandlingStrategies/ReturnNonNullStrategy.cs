using System.Collections.Generic;
using System.Linq;

using ChainOfHandlers.Interfaces;

namespace ChainOfHandlers.HandlingStrategies
{
    public class ReturnNonNullStrategy<TContext, THandler, TOut> : IHandlingWithResponseStrategy<TContext, THandler, TOut>
        where TOut : class 
        where THandler : IHandler<TContext, TOut>
    {
        public TOut Process(IEnumerable<THandler> handlers, TContext context)
        {
            return handlers.Select(handler => handler.Handle(context)).FirstOrDefault(@object => @object != null);
        }
    }
}