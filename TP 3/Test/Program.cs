using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using VistaForm;
using Serializacion;
using System.IO;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Cecilia Silva. TP3 2D, probando probando";

            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("------------------------MARITIME SOLUTIONS LTD-------------------------");
            Console.WriteLine("-----------------------------------------------------------------------");



            #region instancias para funcionamiento
            SerializadoraXml<List<Publicacion>> serializacionPubs = new SerializadoraXml<List<Publicacion>>();
            SerializadoraXml<List<Carta>> serializacionCarta = new SerializadoraXml<List<Carta>>();
            SerializadoraXml<List<Clientes>> serializacionCliente = new SerializadoraXml<List<Clientes>>();

            List<Carta> cartasConsola = new List<Carta>();
            List<Clientes> clientesConsola = new List<Clientes>();
            List<Publicacion> publicacionesConsola = new List<Publicacion>();
            List<Barco> barcosConsola = new List<Barco>();

            Stock stocksito = new Stock();

           string rutaPub = AppDomain.CurrentDomain.BaseDirectory + "listaPublicacionesStock";
           string rutaCartas = AppDomain.CurrentDomain.BaseDirectory + "listaCartasStock";
           string rutaClientes = AppDomain.CurrentDomain.BaseDirectory + "listaClientes";

        Publicacion publicacion = new Publicacion(2, Publicacion.Formato.Hardbook, "Tanker Structures", 2021, "IMO", "AN2021", 1);


            /// Esta publicación ya está en la lista, no debería poder agregarse de nuevo
            Publicacion publicacionDuplicada = new Publicacion(2, Publicacion.Formato.Hardbook, "IMDG Code Supplement", 2008, "IMO", "KK210F", 1);

            Controller.GuardarXml();
            Controller.agregarDatos_Serializar_NuevasEdiciones();
            Stock.Publicaciones.AddRange(Controller.Deserializar(publicacionesConsola, rutaPub));
            Stock.Cartas.AddRange(Controller.Deserializar(Stock.Cartas, rutaCartas));



            #endregion

            Console.WriteLine("                                                   ");
            Console.WriteLine("                                                   ");
            Console.WriteLine("                                                   ");

            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("------------------------AGREGAR PUBLICACIONES-------------------------");
            Console.WriteLine("-----------------------------------------------------------------------");


            Console.WriteLine("                                                   ");
            Console.WriteLine("                                                   ");
            Console.WriteLine("                                                   ");


            if (stocksito + publicacion)
            {
                Console.WriteLine("Se agregó la publicación {0} con éxito", publicacion.Titulo);
                publicacionesConsola.Add(publicacion);
            }


           Console.WriteLine("                                                   ");
            Console.WriteLine("                                                   ");
            Console.WriteLine("                                                   ");


            if (stocksito + publicacionDuplicada)
            {
                Console.WriteLine("Se agregó la publicación con éxito");
            }
            else
            {
                Console.WriteLine("No se pudo agregar la publicación {0}.", publicacionDuplicada.Titulo);
            }
            Console.WriteLine("                                                   ");
            Console.WriteLine("                                                   ");
            Console.WriteLine("                                                   ");

            Console.Write("-----------------PRESIONE UNA TECLA PARA CONTINUAR--------------------------");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("------------------------MARITIME SOLUTIONS LTD-------------------------");
            Console.WriteLine("-----------------------------------------------------------------------");

            Console.WriteLine("                                                   ");
            Console.WriteLine("                                                   ");
            Console.WriteLine("                                                   ");

            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("-------------¿QUE BARCOS TIENEN LA PUBLICACIÓN DUPLICADA?--------------");
            Console.WriteLine("-----------------------------------------------------------------------");


            Console.WriteLine("                                                   ");
            Console.WriteLine("                                                   ");
            Console.WriteLine("                                                   ");


            Console.WriteLine("La publicación duplicada es: {0} . \nNo se pudo agregar porque ya estaba en la lista. Su código es {1}.", publicacionDuplicada.Titulo, publicacionDuplicada.Codigo);

            Console.WriteLine("                                                   ");
            Console.WriteLine("                                                   ");

            //// DEBERÍA MOSTRAR LOS SIGUIENTES BARCOS:
            //////SANTA BARBARA
            ///OCEAN BREEZE
            ///BLAZING SUN
            ///SKANDI PACIFIC

            Stock.revisarIgualdadBarcoSeleccionado(publicacionDuplicada, barcosConsola);

            if (barcosConsola.Count > 0)
            {
                foreach (Barco barquito in barcosConsola)
                {
                    Console.WriteLine(barquito.NombreBarco);
                }
            }
            else
            {
                Console.WriteLine("Oops, ningún barco tiene esta publicación");
            }

            



            Console.ReadKey();

        }
    
    }
}
