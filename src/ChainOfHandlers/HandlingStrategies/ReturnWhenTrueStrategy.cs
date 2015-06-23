using System.Collections.Generic;

using ChainOfHandlers.Interfaces;

namespace ChainOfHandlers.HandlingStrategies
{
    public class ReturnWhenTrueStrategy<TContext, THandler> : IHandlingWithResponseStrategy<TContext, THandler, bool>
        where THandler : IHandler<TContext, bool>
    {
        public bool Process(IEnumerable<THandler> handlers, TContext context)
        {
            foreach (var handler in handlers)
            {
                if (handler.Handle(context))
                {
                    return true;
                }
            }

            return false;
        }
    }
}