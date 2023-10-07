using LazyClasses;
using System;

namespace LazyRecurcion
{
    internal class Program
    {
        public Optional<int> Divide(Lazy<int> x, Lazy<int> y)
        {
            if (y == null) return new Optional<int>();
            return new Optional<int>(new Lazy<int>(() => x.Value / y.Value));
        }
        static void Main(string[] args)
        {
            SideEffect.ReadingNumber()
            .Bind(x => SideEffect.ReadingNumber()
            .Bind(y =>
            {
                var sum = new Lazy<int>(() => x.Value + y.Value);
                return SideEffect.PrintingNumber(sum);
            }))
            .Execute();

        }
    }
}
