using HeilerEinteilung.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeilerEinteilung.HealerClasses
{
    internal class Druid : IHealerClassInformation
    {
        public HealerClass HealerClass
        {
            get => HealerClass.Druide;
        }

        public string ColorString
        {
            get => "ffffffff";
        }
    }
}
