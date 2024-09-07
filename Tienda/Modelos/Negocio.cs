using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

using System.Threading.Tasks;
using Tienda.Enums;

namespace Tienda.Modelos
{
    public class Negocio
    {
        private string _nombre;

        private List<Producto> _productos = new List<Producto>();

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public List<Producto> Productos
        {
            get { return _productos; }
            set { _productos= value; }
        }

        public Negocio(string nombre)
        {
            Nombre = nombre;
        }
        //sobrecargo el constructor
        public Negocio(string nombre, List<Producto> productos)
        {
            Nombre = nombre;
            Productos = productos;
        }
        public void AgregarProducto(string nombre,string marca, Categorias categoria, double precio)
        {
            Producto producto = new Producto(nombre,marca,categoria,precio);
            Productos.Add(producto);
        }

        public void MostrarDetalles()
        {
            Console.WriteLine($"Lista de productos: ");
            foreach(var producto in Productos)
            {
                Console.WriteLine("-------------------------------");
                producto.MostrarDetalles();
                Console.WriteLine("-------------------------------\n");
            }
        }
    }
}
