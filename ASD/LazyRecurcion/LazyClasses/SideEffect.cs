using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyClasses
{
    public class SideEffect<T>
    {
        private Func<Lazy<T>> func;
        public SideEffect(Func<Lazy<T>> func)
        {
            this.func = func;
        }
        public SideEffect<RT> Bind<RT>(Func<Lazy<T>, SideEffect<RT>> secondEffct)
        {
            return new SideEffect<RT>(()=>secondEffct(func()).func());
        }
        public void Execute()
        {
            func();
        }
    }
    public static class SideEffect
    {
        public static SideEffect<T> Make<T>(Func<Lazy<T>> func)
        {
            return new SideEffect<T>(func);
        }
        public static SideEffect<int> ReadingNumber()
        {
            return new SideEffect<int>(() =>
            {
                var num = int.Parse(Console.ReadLine());
                return new Lazy<int>(() => num);
            });
        }
        public static SideEffect<LazyVoid> PrintingNumber(Lazy<int> num)
        {
            return new SideEffect<LazyVoid>(() =>
            {
                Console.WriteLine(num.Value);
                return new Lazy<LazyVoid>(()=>LazyVoid.Instance);
            });
        }
    }
}
