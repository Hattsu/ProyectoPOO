using System;
namespace ProyectoPOO
{
    class Postres
    {
        /*public string Nombre {set; get;}
        public string Sabor {set; get;}
        public string Tamaño {set; get;}
        public int Cantidad {set; get;}
        public double Precio {set; get;}

        public Postres(string nombre, string sabor, string tamaño, int cantidad, double precio)
        {
            this.Nombre = nombre;
            this.Sabor = sabor;
            this.Tamaño = tamaño;
            this.Cantidad = cantidad;
            this.Precio = precio;
        }*/

        public void Panel_opciones_inicio()
        {
            string Numero_opcion;
            Console.WriteLine("------------------------------");
            Console.WriteLine("Si desea Cancelar su pedido escriba el valor (1)");
            Console.WriteLine("Si desea Verificar su pedido escriba el valor (2)");
            Console.WriteLine("Si desea Ver el menú de postres escriba el valor (3)");
            Console.WriteLine("Si desea salir escriba el valor (4)");
            Console.WriteLine("------------------------------");
            Numero_opcion = Console.ReadLine();
            Cambios_opciones(Numero_opcion);

        }
        public void Cambios_opciones(string Numero_opcion)
        {
            switch (Numero_opcion.ToString())
             {
                case "1":
                    Cancelar_pedido();
                    break;
                case "2":
                    Verificar_pedido();
                    break;
                case "3":
                    Menu_inicio();
                    break;
                case "4":
                    Console.WriteLine("...Saliendo...");
                    break;
            }
        }
        public void Cancelar_pedido()
        {
            Console.WriteLine("Cancelando pedido...");
        }
        public void Verificar_pedido()
        {
            Console.WriteLine("Mostrando pedido...");
        }
        public void Menu_inicio()
        {
            Console.WriteLine("Mostrando menú...");
        }
    }
}