using System;
namespace ProyectoPOO
{
    interface IServicio
    {
        public void Panel_opciones_inicio();
        public void Cambios_opciones(string Numero_opcion);
        public void Cancelar_pedido();
        public void Verificar_pedido();
        public void Menu_inicio();
    }
}
