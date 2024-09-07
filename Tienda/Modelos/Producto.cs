using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tienda.Enums;
namespace Tienda.Modelos
{
    public class Producto
    {
        private string _nombre;
        private string _marca;
        private Categorias _categoria;
        private double _precio;
        
        
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }
        public Categorias Categoria
        {
            get { return _categoria; }
            set { _categoria = value; } 
        }
        public double Precio
        {
            get { return _precio; }
            set
            {
                _precio = value;
            }
        }
        public Producto(string nombre, string marca,Categorias categoria, double precio)
        {
            Nombre = nombre;
            Marca = marca;
            Categoria = categoria;
            Precio = precio;

        }
        public void ModificarProducto(double precio)
        {
            if (precio > 0)
            {
                _precio = precio;
            }
            else
            {
                throw new ArgumentException("El precio debe ser positivo!\n");
            }
        }
        public void MostrarDetalles()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Categoria: {Categoria.ToString()}");
            Console.WriteLine($"Precio: {Precio}");       

        }
    }
}
