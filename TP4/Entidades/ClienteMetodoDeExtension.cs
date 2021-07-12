using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ClienteMetodoDeExtension
    {

        public static int CantidadCartasPorCliente(this Clientes cliente)
        {
            int cantidad = 0;
            foreach (Barco barco in cliente.barcos)
            {
                foreach (Carta carta in barco.cartas)
                {
                    cantidad++;
                }
            }
            return cantidad;
        }
        public static int CantidadPublicacionesPorCliente(this Clientes cliente)
        {
            int cantidad = 0;
            foreach (Barco barco in cliente.barcos)
            {
                foreach (Publicacion publicacion in barco.publicaciones)
                {
                    cantidad++;
                }
            }
            return cantidad;
        }
    }
}
