using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Stock
    {
        static public List<Publicacion> Publicaciones;
        static public List<Carta> Cartas;
        static public List<Clientes> Clientes;
        static public List<Barco> Barcos;
        private static Stock singleton;

        //private static string rutaClientes = AppDomain.CurrentDomain.BaseDirectory + "listaClientes";

        static public List<Publicacion> nuevasEdiciones_Publicaciones = new List<Publicacion>();
        static public List<Carta> nuevasEdiciones_Cartas = new List<Carta>();

        /// <summary>
        /// Constructor sin paramatros que instanciara las listas Publicaciones y Cartas
        /// </summary>
        public Stock()
        {
            Publicaciones = new List<Publicacion>();
            Cartas = new List<Carta>();
            Clientes = new List<Clientes>();
            Barcos = new List<Barco>();
            
            //Clientes.AddRange(Controller.Deserializar(Clientes, rutaClientes));


        }
        /// <summary>
        /// Propiedad que permitirá la instancia de la clase Stock sólo si es la primera vez que se llama a la propiedad.
        /// </summary>
        /// <returns></returns>
        public static Stock GetStock()
        {
            if (Stock.singleton is null)
            {
                Stock.singleton = new Stock();
            }
            return Stock.singleton;
        }

        /// <summary>
        /// Recibe una lista por parámetro y revisa que elementos tiene en común con Stock.Publicaciones, los agrega a una nueva lista y la devuelve.
        /// </summary>
        /// <param name="listaRevisar"></param>
        /// <param name="nuevaLista"></param>
        /// <returns></returns>
        public static List<Publicacion> RevisarIgualdad (List<Publicacion> listaRevisar, List<Publicacion> nuevaLista)
        {
            foreach (Publicacion publicacionLista in listaRevisar)
            {
                foreach (Publicacion publiStock in Publicaciones)
                {
                    if (publiStock.Codigo == publicacionLista.Codigo && publiStock.eFormato == publicacionLista.eFormato)
                    {
                        nuevaLista.Add(publiStock);
                        continue;
                    }
                }
            }                            
            return nuevaLista;
        }
        /// <summary>
        /// Sobrecarga. Recibe una lista por parámetro y revisa que elementos tiene en común con Stock.Publicaciones, los agrega a una nueva lista y la devuelve.
        /// </summary>
        /// <param name="listaRevisar"></param>
        /// <param name="nuevaLista"></param>
        /// <returns></returns>
        public static List<Carta> RevisarIgualdad(List<Carta> listaRevisar, List<Carta> nuevaLista)
        {
            foreach (Carta cartaLista in listaRevisar)
            {
                foreach (Carta cartaStock in Cartas)
                {
                    if (cartaStock.Codigo == cartaLista.Codigo )
                    {
                        nuevaLista.Add(cartaStock);
                        continue;
                    }
                }
            }
            return nuevaLista;
        }


        #region SOBRECARGA DE OPERADORES
        /// <summary>
        /// Sobrecarga del operador == que verifica si la PUBLICACIÓN pasada por parámetro es igual a la contenida dentro de la lista.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static bool operator ==(Stock s, Publicacion m)
        {

            foreach (Publicacion merc in Stock.Publicaciones)
            {
                if (merc.Codigo == m.Codigo)
                {
                    merc.Cantidad += m.Cantidad;
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Sobrecarga del operador == que verifica si la CARTA pasada por parámetro es igual a la contenida dentro de la lista.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static bool operator ==(Stock s, Carta m)
        {
            foreach (Carta merc in Stock.Cartas)
            {
                if (merc.Codigo == m.Codigo )
                {
                   merc.Cantidad += m.Cantidad;
                    return true;                   
                }
            }
            return false;
        }
        /// <summary>
        /// Sobrecarga del operador != que verifica si la PUBLICACIÓN pasada por parámetro es igual a la contenida dentro de la lista, retorna lo opuesto al ==
        /// </summary>
        /// <param name="s"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static bool operator !=(Stock s, Publicacion m)
        {
            return !(s == m);
        }
        /// <summary>
        /// Sobrecarga del operador != que verifica si la CARTA pasada por parámetro es igual a la contenida dentro de la lista, retorna lo opuesto al ==
        /// </summary>
        /// <param name="s"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static bool operator !=(Stock s, Carta m)
        {
            return !(s == m);
        }
         
        /// <summary>
        /// Sobrecarga del operador + verifica si lo recibido por parametro es igual a la lista, si no lo es, la agrega.
        /// Si es igual, sumará 1 unidad a la cantidad.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static bool operator +(Stock s, Publicacion m)
        {           
            if ((s != m))
            {
                Stock.Publicaciones.Add(m);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Sobrecarga del operador + verifica si lo recibido por parametro es igual a la lista, si no lo es, la agrega.
        /// Si es igual, sumará 1 unidad a la cantidad.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        public static bool operator +(Stock s, Carta m)
        {
            if (s != m)
            {
                Stock.Cartas.Add(m);
                return true;
            }
            return false;
        }

        #endregion

        /// <summary>
        /// Cuando se agrega un obj del tipo mercadería al datagrid, se agrega a ese barco. Para eso itera sobre clientes y si es igual al pasado por parámetro, busca hasta encontrar su barco y si es del tipo publicación, lo agrega a esa lista. si es del tipo carta, lo agrega a esa lista.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="cliente"></param>
        /// <param name="barco"></param>
        public static void AgregarMercaderia_alBarco(Object obj, string cliente, string barco)
        {
            foreach (Clientes clientesito in Clientes)
            {
                if (cliente == clientesito.Nombre)
                {
                    foreach (Barco barquito in clientesito.barcos)
                    {
                        if (obj.GetType() == typeof(Publicacion) && barco == barquito.NombreBarco)
                        {
                            barquito.publicaciones.Add((Publicacion)obj);
                            return;
                        }
                        if (obj.GetType() == typeof(Carta) && barco == barquito.NombreBarco)
                        {
                            barquito.cartas.Add((Carta)obj);
                            return;
                        }
                    }
                }
            }
        }

        public static List<Barco> RevisarIgualdadBarcoSeleccionado(Publicacion publi, List<Barco> listaBarcos)
        {
            foreach (Clientes clientesito in Stock.Clientes)
            {
                foreach (Barco barquito in clientesito.barcos)
                {
                    
                        foreach (Publicacion publicacion in barquito.publicaciones)
                        {

                        if (publicacion.Codigo == publi.Codigo && publicacion.eFormato == publi.eFormato)
                            {
                                listaBarcos.Add(barquito);
                             break;
                            }
                        
                        }                                          
                }              
            }
            return listaBarcos;            
        }

        
    }
}
