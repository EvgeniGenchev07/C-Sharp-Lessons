using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_date_structures
{
    public class Optional<T>
    {
        private Box<T> box;
        public Optional()
        {
            box = null;
        }
        public Optional(T value)
        {
            box.Value = value;
        }
        public bool HasValue => box!=null;
        public void WithValue(Action<T> action)
        {
            if (HasValue)
            {
                action(box.Value);
            }
        }
        public Optional<R> WithValue<R>(Func<T,R> func)
        {
            if (HasValue)
            {
                return new Optional<R>(func(box.Value));
            }
            return new Optional<R>();
        }

    }
}
