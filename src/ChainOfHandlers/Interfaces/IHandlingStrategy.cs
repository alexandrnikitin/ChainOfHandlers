using System.Collections.Generic;

namespace ChainOfHandlers.Interfaces
{
    public interface IHandlingStrategy<in TContext, in THandler>
    {
        void Process(IEnumerable<THandler> handlers, TContext context);
    }
}