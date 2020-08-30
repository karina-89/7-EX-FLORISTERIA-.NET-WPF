using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floristeria
{
    public class Arbol : Articulo
    {
        public double Altura { get; set; }
        public Arbol() {}

        public Arbol(string nombre, double altura, int cantidad, double precio)
        {
            this.Nombre = nombre;
            this.Altura = altura;
            this.Cantidad = cantidad;
            this.Precio = precio;
        }
    }
}
