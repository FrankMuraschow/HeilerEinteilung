using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeilerEinteilung.Interfaces
{
    internal interface IHealerClassInformation
    {
        HealerClass HealerClass { get; }
        string ColorString { get; }
    }
}
