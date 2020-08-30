using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floristeria
{
    public class Flor : Articulo
    {
        public string Color { get; set; }
        public Flor() { }
        public Flor(string nombre, string color, int cantidad, double precio)
        {
            this.Nombre = nombre;
            this.Color = color;
            this.Cantidad = cantidad;
            this.Precio = precio;
        }
    }
}
