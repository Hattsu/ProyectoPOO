using System;
namespace ProyectoPOO
{
    class Postres
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
    }
}
