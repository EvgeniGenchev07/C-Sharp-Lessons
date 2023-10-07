using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyTypes
{
    public class Pair<T1,T2> 
        where T1 : Lazy<T1> 
        where T2 : Lazy<T2>
    {
        private Lazy<T1> first; 
        private Lazy<T2> second;
        public Pair(Lazy<T1> first, Lazy<T2> second)
        {
            this.first = first;
            this.second = second;
        }
        public Lazy<RT> WithPair<RT>(Func<Lazy<T1>, Lazy<T2>, Lazy<RT>> f)
        {
            return f(first, second);
        }
    }
}
