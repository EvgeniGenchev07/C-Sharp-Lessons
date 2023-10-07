using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _9.Military_Elite
{
    internal interface ISoldier
    {
        string Id { get; set; }
        string ToString();
    }
}
