using System;
namespace ProyectoPOO
{
    class Cupcake:Postres, IServicio
    {
        public Cupcake(string sabor, string nombre, int cantidad, double precio, string tamaño): base (sabor, nombre, cantidad, precio, tamaño)
        {
        }   
        public void Panel_opciones_inicio()
        {
            string Numero_opcion;
            Console.WriteLine("------------------------------");
            Console.WriteLine("Postre: "+Nombre);
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
            Console.WriteLine("-------------------");
            Console.WriteLine("Cancelando pedido... borrando datos");
            Console.WriteLine("-------------------");
            Sabor = "";
            Precio = 0;
            Cantidad =0;
            Panel_opciones_inicio();
        }

        public void Verificar_pedido()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("Mostrando pedido...");
            Console.WriteLine("...................");
            Console.WriteLine("Postre: "+Nombre);
            Console.WriteLine("-------------------");
            Console.WriteLine("Sabor: "+Sabor);
            Console.WriteLine("Precio total: "+Precio);
            Console.WriteLine("Cantidad: "+Cantidad);
            Panel_opciones_inicio();
        }

        public void Menu_inicio()
        {
            Console.WriteLine("Escriba el sabor a elección:\n1.Fresa\n2.Chocolate\n3.Vainilla");
            Sabor = Console.ReadLine();
            Console.WriteLine("El "+Nombre+" tiene un valor de $"+Precio);
            Console.WriteLine("Escriba la cantidad del producto:");
            Cantidad = int.Parse(Console.ReadLine());
            Precio = Precio * Cantidad;
            Panel_opciones_inicio();
        }
    }
}
