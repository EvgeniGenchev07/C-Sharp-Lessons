using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyClasses
{
    public class LazyVoid
    {
        private static readonly LazyVoid instance=new LazyVoid();
        private LazyVoid() {  }
        public static LazyVoid Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
