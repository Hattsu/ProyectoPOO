using System;
namespace ProyectoPOO
{
    class Helados:Postres
    {
        public Helados(string sabor, string nombre, int cantidad, double precio, string tamaño): base (sabor, nombre, cantidad, precio, tamaño){}  
        public void Panel_opciones_inicio(){}
        public void Cambios_opciones(string Numero_opcion){}
        public void Cancelar_pedido(){}
        public void Verificar_pedido(){}
        public void Menu_inicio(){}
    }
}
