using HeilerEinteilung.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeilerEinteilung.HealerClasses
{
    internal class Shaman : IHealerClassInformation
    {
        public HealerClass HealerClass
        {
            get => HealerClass.Schamane;
        }

        public string ColorString
        {
            get => "ffffffff";
        }
    }
}
