using System;
namespace ProyectoPOO
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Constructores
            Usuarios usuarios = new Usuarios("", "", 0, "");
            Pasteles pasteles = new Pasteles("", "Pastel", 0, 4, "");
            Cupcake cupcake = new Cupcake("", "Cupcake", 0, 0.25, "");
            Helados helados = new Helados("", "Helado", 0, 0.75, "");

            //Listas
            List<IServicio> Panel_lista = new List<IServicio>();
            Panel_lista.Add(usuarios);
            Panel_lista.Add(pasteles);
            Panel_lista.Add(cupcake);
            Panel_lista.Add(helados);
            
            //For each para usar el metodo que inicia los paneles
            foreach(IServicio Item in Panel_lista)
            {
                Item.Panel_opciones_inicio();
            }
        }
    }
}
