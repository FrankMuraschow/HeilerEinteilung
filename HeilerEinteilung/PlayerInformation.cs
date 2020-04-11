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
        public PlayerClass PlayerClass;

        public PlayerInformation()
        {
        }

        public PlayerInformation(PlayerType playerType, string name, PlayerClass playerClass)
        {
            PlayerType = playerType;
            Name = name;
            PlayerClass = playerClass;
        }
    }
}
