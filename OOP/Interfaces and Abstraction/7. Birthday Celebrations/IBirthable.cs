using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Birthday_Celebrations
{
    internal interface IBirthable
    {
        string Birthdate { get; set; }
        string DateSearching();
    }
}
