using System.Collections.Generic;

namespace ChainOfHandlers.Interfaces
{
    public interface IHandlingWithResponseStrategy<in TContext, in THandler, out TOut>
    {
        TOut Process(IEnumerable<THandler> handlers, TContext context);
    }

    //public interface IHandlersProcessorWithReturnMany<in TContext, in THandler, TOut>
    //{
    //    #region Public Methods and Operators

    //    List<TOut> Process(IEnumerable<THandler> handlers, TContext context);

    //    #endregion
    //}
}