using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HeilerEinteilung
{
    public class PlayerInformation
    {
        [XmlAttribute]
        public PlayerType PlayerType;

        [XmlAttribute]
        public string Name;

        [XmlAttribute]
        public HealerClass HealerClass;

        public PlayerInformation()
        {
        }

        public PlayerInformation(PlayerType playerType, string name, HealerClass healerClass)
        {
            PlayerType = playerType;
            Name = name;
            HealerClass = healerClass;
        }
    }
}
