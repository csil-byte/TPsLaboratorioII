namespace Entidades {
    public static class ClienteMetodoDeExtension {

        /// <summary>
        /// Contará cantidad de cartas total por cada cliente y cada barco
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public static int CantidadCartasPorCliente(this Clientes cliente) {
            int cantidad = 0;
            foreach (Barco barco in cliente.barcos) {
                foreach (Carta carta in barco.cartas) {
                    cantidad++;
                }
            }
            return cantidad;
        }
        /// <summary>
        /// Contará cantidad de publicaciones total por cada cliente y cada barco
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public static int CantidadPublicacionesPorCliente(this Clientes cliente) {
            int cantidad = 0;
            foreach (Barco barco in cliente.barcos) {
                foreach (Publicacion publicacion in barco.publicaciones) {
                    cantidad++;
                }
            }
            return cantidad;
        }
    }
}
