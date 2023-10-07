using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Border_Control
{
    internal interface IIdentifiable
    {
        string Id { get; set; }
        void IdSearching(string el);
    }
}
