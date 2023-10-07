using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Food_Shortage
{
    internal interface IBuyer
    {
        int Food { get; set; }
        void BuyFood();
    }
}
