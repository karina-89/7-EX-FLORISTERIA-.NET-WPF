using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Floristeria
{
    [XmlRoot("Database")]
    [XmlInclude(typeof(Establecimiento))]
    public class Database
    {
        public List<Establecimiento> Establecimientos = new List<Establecimiento>();
    }
}
