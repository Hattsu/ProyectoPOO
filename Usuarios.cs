using System;
namespace ProyectoPOO
{
    class Usuarios : IServicio
    {
        private string Nombres{set; get;}
        private string Apellidos{set; get;}
        private int Telefono{set; get;}
        private string Dirección{set; get;}

        public Usuarios(string Nombres, string Apellidos, int Telefono, string Dirección)
        {
            this.Nombres = Nombres;
            this.Apellidos = Apellidos;
            this.Telefono = Telefono;
            this.Dirección = Dirección;
        }
        public void Panel_opciones_inicio()
        {
            string Numero_opcion;
            Console.WriteLine("Si desea ingresar sus datos de usuario o modificarlos escriba (1)");
            Console.WriteLine("Si desea Mostrarlos escriba (2)");
            Console.WriteLine("Si desea pasar al siguiente panel escriba (3)");
            Numero_opcion = Console.ReadLine();
            Cambios_opciones(Numero_opcion);
        }
        public void Cambios_opciones(string Numero_opcion)
        {
            switch (Numero_opcion.ToString())
             {
                case "1":
                    Leer_datos();
                    break;
                case "2":
                    Imprimir_datos();
                    break;
                case "3":
                    Console.WriteLine("...Saliendo...");
                    break;
             }
        }

        public void Leer_datos()
        {
            Console.WriteLine("Ingrese el nombre del cliente: ");
                Nombres = Console.ReadLine();

            Console.WriteLine("Ingrese el apellido del cliente: ");
                Apellidos = Console.ReadLine();

            Console.WriteLine("Ingrese el telefono del cliente: ");
                Telefono = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la direccion del cliente: ");
                Dirección = Console.ReadLine();
            Panel_opciones_inicio();
        }

        public void Imprimir_datos()
        {
            Console.WriteLine("...................");
            Console.WriteLine("Datos de usuario: ");
            Console.WriteLine("-------------------");
            Console.WriteLine("Nombres: "+Nombres+"\nApellidos: "+Apellidos);
            Console.WriteLine("Número de telefono-celular: "+Telefono);
            Console.WriteLine("Dirección: "+Dirección);
            Panel_opciones_inicio();
        }
    }
}
