using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Floristeria
{
    public class Establecimiento
    {
        public static int globalTiendaID;
        public int ID { get; set; }
        public string Nombre { get; set; }
        public List<Arbol> Arboles { get; set; }
        public List<Flor> Flores { get; set; }
        public List<Decoracion> Decoraciones { get; set; }

        public Establecimiento()
        {
            this.ID = Interlocked.Increment(ref globalTiendaID);
        }
    }
}
