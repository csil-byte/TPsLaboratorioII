using System;
using System.Collections.Generic;


namespace Entidades {
    public static class Controller {
        /// <summary>
        /// Itera sobre lista de barcos hasta encontrar el pasado por parametro y retorna su ID.
        /// </summary>
        /// <param name="nombreBarco"></param>
        /// <returns></returns>
        public static int BuscarBarcoPorId(string nombreBarco) {
            foreach (Barco barco in Stock.Barcos) {
                if (nombreBarco == barco.NombreBarco) {
                    return barco.IdBarco;
                }
            }
            return 0;
        }
        /// <summary>
        /// Agrega la publicación recibida por parámetro a todos los barcos que la tengan. Recibe idBarcos que son todos los id de barcos que la tienen.
        /// </summary>
        /// <param name="idBarcos"></param>
        /// <param name="pub"></param>
        public static void AgregarPublicacionesABarcos(int[] idBarcos, Publicacion pub) {
            try {
                for (int i = 0; i < Stock.Barcos.Count; i++) {
                    pub.obtenenerIdBarcos(idBarcos);
                    foreach (Barco barquito in Stock.Barcos) {
                        if (pub.idBarcosPublicaciones[i] == barquito.IdBarco) {
                            barquito.publicaciones.Add(pub);
                        }
                    }
                }
            } catch (Exception e) {

            }
        }
        /// <summary>
        /// Agrega la carta recibida por parámetro a todos los barcos que la tengan. Recibe idBarcos que son todos los id de barcos que la tienen.
        /// </summary>
        /// <param name="idBarcos"></param>
        /// <param name="carta"></param>
        public static void AgregarCartasABarcos(int[] idBarcos, Carta carta) {
            try {
                for (int i = 0; i < Stock.Barcos.Count; i++) {
                    carta.obtenenerIdBarcos(idBarcos);
                    foreach (Barco barquito in Stock.Barcos) {
                        if (carta.idBarcosCartas[i] == barquito.IdBarco) {
                            barquito.cartas.Add(carta);
                        }
                    }
                }
            } catch (Exception e) { }

        }
        /// <summary>
        /// Agrega a la lista de barcos de cada cliente los barcos que le corresponden según el ID CLIENTE que ambos comparten.
        /// </summary>
        /// <param name="listaClientes"></param>
        /// <param name="listaBarcos"></param>      
        public static void ObtenerBarcosPorCadaCliente(List<Clientes> listaClientes, List<Barco> listaBarcos) {
            foreach (Barco barquito in listaBarcos) {
                foreach (Clientes clientesito in listaClientes) {
                    if (barquito.IdCliente == clientesito.IdCliente) {
                        clientesito.barcos.Add(barquito);
                    }
                }
            }
        }







    }
}
