
using Tienda.Modelos;


namespace Tienda
{
    public class Program
    {
        public static void Main()
        {

            Negocio negocio = new Negocio("Tienda de don PEPE");
            negocio.AgregarProducto("Zapatillas", "Nike", Enums.Categorias.Indumentaria, 250000);

            negocio.AgregarProducto("Coca", "Manaos", Enums.Categorias.Alimentos, 1500);

            negocio.AgregarProducto("smart tv", "Sony", Enums.Categorias.Electronica,500000);

            negocio.Productos[0].ModificarProducto(300000);
            negocio.Productos[1].ModificarProducto(3000);
            negocio.Productos[2].ModificarProducto(290000);

            negocio.MostrarDetalles();
        }
    }
}
