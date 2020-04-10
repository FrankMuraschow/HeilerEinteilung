using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HeilerEinteilung
{
    [XmlRoot]
    public class Players
    {
        public List<PlayerInformation> PlayerInformations = new List<PlayerInformation>();
    }
}
