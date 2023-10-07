using System;
namespace LazyClasses
{
    public class List<T>
    {
        private Optional<Pair<T,List<T>>> head;
        public List()
        {
            head = new Optional<Pair<T,List<T>>>();
        }
        public List(Lazy<T> headValue,Lazy<List<T>>tail)
        {
            head = new Optional<Pair<T, List<T>>>(new Lazy<Pair<T, List<T>>>(()=>new Pair<T, List<T>>(headValue,tail)));
        }
        public Lazy<RT> WithList<RT>(Lazy<RT> whenEmpty, Func<Lazy<T>, Lazy<List<T>>, Lazy<RT>> f)
        {
            return head.WithOptional(whenEmpty, pair => pair.Value.WithPair(f));
        }
    }
}
