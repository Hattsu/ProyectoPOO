using System;
namespace ProyectoPOO
{
    class Program
    {
        public static void Main(string[] args)
        {
            Usuarios usuarios = new Usuarios("", "", 0, "");
            usuarios.Panel_usuario();
            Pasteles pasteles = new Pasteles("", "Pastel", 0, 4, "");
            pasteles.Panel_opciones_inicio();
            Cupcake cupcake = new Cupcake("", "Cupcake", 0, 0.25, "");
            cupcake.Panel_opciones_inicio();
            Helados helados = new Helados("", "Helado", 0, 0.75, "");
            helados.Panel_opciones_inicio();
        }
    }
}
