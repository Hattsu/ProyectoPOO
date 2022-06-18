using System;
namespace ProyectoPOO
{
    class Postres : IServicio
    {
        public string Nombre {set; get;}
        public string Sabor {set; get;}
        public int Cantidad {set; get;}
        public double Precio {set; get;}
        public string Tamaño {set; get;}
        
        public Postres(string sabor, string nombre, int cantidad, double precio, string tamaño)
        {
            this.Nombre = nombre;
            this.Sabor = sabor;
            this.Cantidad = cantidad;
            this.Precio = precio;
            this.Tamaño = tamaño;
            
        }

        // Metodo para iniciar el panel        
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

        //Metodo para cambiar/llamar a los distintos metodos implementados
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

        //Metodo para cancelar los pedidos, básicamente resetea los valores ingresados
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

        // Metodo para imprimir los datos ingresados

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

        //  Metodo para ingresar datos de tipo string 
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
