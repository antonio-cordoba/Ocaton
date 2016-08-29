using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public static class FunctionalExtensions
    {
        public static TResult Map<TSource, TResult>(
            this TSource @this,
            Func<TSource, TResult> fn
            ) => fn(@this);

        public static TSource Tee<TSource> (
            this TSource @this,
            Action<TSource> fn
            )
        {
            fn(@this);
            return @this;
        }

        public static IEnumerable<T> DebugValues<T>(
            this IEnumerable<T> @this,
            Action<T> @do
            )
        {
            foreach(var x in @this)
                @do(x);

            return @this;
        }

    }
}
