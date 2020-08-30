using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floristeria
{
    public class Articulo
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Cantidad { get; set; }
        public Articulo()
        {
            this.Cantidad = 1;
            this.Precio = 1.0;
        }
    }
}
