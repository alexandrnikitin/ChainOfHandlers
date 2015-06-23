using System.Collections.Generic;

using ChainOfHandlers.Interfaces;

namespace ChainOfHandlers.HandlingStrategies
{
    public class ReturnManyStrategy<TContext, THandler, TOut> :
        IHandlingWithResponseStrategy<TContext, THandler, IEnumerable<TOut>>
        where THandler : IHandler<TContext, IEnumerable<TOut>>
    {
        public IEnumerable<TOut> Process(IEnumerable<THandler> handlers, TContext context)
        {
            var list = new List<TOut>();
            foreach (var handler in handlers)
            {
                var result = handler.Handle(context);
                if (result != null)
                {
                    list.AddRange(result);
                }
            }
            return list;
        }
    }
}