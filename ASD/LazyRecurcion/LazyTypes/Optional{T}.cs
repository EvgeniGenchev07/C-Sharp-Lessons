using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyTypes
{
    public class Optional<T>
    {
        private Lazy<T> value;
        public Optional()
        {
            value = null;
        }
        public Optional(Lazy<T> value)
        {
            this.value = value;
        }
        public Lazy<RT> WithOptional<RT>(Lazy<RT> whenEmpty, Func<Lazy<T>, Lazy<RT>> whenFull)
        {
            if (value == null) return whenEmpty;
            return whenFull(value);
        }
        public Optional<RT> Bind<RT>(Func<Lazy<T>, Optional<RT>> f)
        {
            if (value == null) return new Optional<RT>();
            return f(value);

        }
    }
}
