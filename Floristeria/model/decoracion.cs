using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floristeria
{
    public class Decoracion : Articulo
    {
        public Material Material { get; set; }
        public Decoracion()
        {
            this.Material = Material.Madera;
        }
        public Decoracion(string nombre, Material material, int cantidad, double precio)
        {
            this.Nombre = nombre;
            this.Material = material;
            this.Cantidad = cantidad;
            this.Precio = precio;
        }
    }

    public enum Material
    {
        Madera,
        Plástico
    }
}
