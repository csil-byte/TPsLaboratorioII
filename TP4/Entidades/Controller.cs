using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serializacion;


namespace Entidades
{
    public static class Controller
    {
        /// <summary>
        /// Itera sobre lista de barcos hasta encontrar el pasado por parametro y retorna su ID.
        /// </summary>
        /// <param name="nombreBarco"></param>
        /// <returns></returns>
        public static int BuscarBarcoPorId(string nombreBarco)
        {
            foreach (Barco barco in Stock.Barcos)
            {
                if (nombreBarco == barco.NombreBarco)
                {
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
        public static void AgregarPublicacionesABarcos(int[] idBarcos, Publicacion pub)
        {
            try
            {
                for (int i = 0; i < Stock.Barcos.Count; i++)
                {
                    pub.obtenenerIdBarcos(idBarcos);
                    foreach (Barco barquito in Stock.Barcos)
                    {
                        if (pub.idBarcosPublicaciones[i] == barquito.IdBarco)
                        {
                            barquito.publicaciones.Add(pub);
                        }
                    }
                }
            }
            catch (Exception e)
            {

            }
        }
        /// <summary>
        /// Agrega la carta recibida por parámetro a todos los barcos que la tengan. Recibe idBarcos que son todos los id de barcos que la tienen.
        /// </summary>
        /// <param name="idBarcos"></param>
        /// <param name="carta"></param>
        public static void AgregarCartasABarcos(int[] idBarcos, Carta carta)
        {
            try
            {
                for (int i = 0; i < Stock.Barcos.Count; i++)
                {
                    carta.obtenenerIdBarcos(idBarcos);
                    foreach (Barco barquito in Stock.Barcos)
                    {
                        if (carta.idBarcosCartas[i] == barquito.IdBarco)
                        {
                            barquito.cartas.Add(carta);
                        }
                    }
                }
            }
            catch (Exception e)
            { }

        }
        /// <summary>
        /// Agrega a la lista de barcos de cada cliente los barcos que le corresponden según el ID CLIENTE que ambos comparten.
        /// </summary>
        /// <param name="listaClientes"></param>
        /// <param name="listaBarcos"></param>      
        public static void ObtenerBarcosPorCadaCliente(List<Clientes> listaClientes, List<Barco> listaBarcos)
        {
            foreach (Barco barquito in listaBarcos)
            {
                foreach (Clientes clientesito in listaClientes)
                {
                    if (barquito.IdCliente == clientesito.IdCliente)
                    {
                        clientesito.barcos.Add(barquito);
                    }
                }
            }
        }



        #region COSAS A BORRAR


        //#region generar Listas y obj

        //private static SerializadoraXml<List<Publicacion>> serializacionPubs;
        //private static SerializadoraXml<List<Carta>> serializacionCarta;
        //private static SerializadoraXml<List<Clientes>> serializacionCliente;

        //private static List<Publicacion> publicacionesXml;
        //private static List<Carta> cartasXml;
        //private static List<Clientes> clientesXml;


        //private static List<Publicacion> UnoPubli_ListaNuevasEdiciones = new List<Publicacion>();
        //private static List<Publicacion> DosPubli_ListaNuevasEdiciones = new List<Publicacion>();


        //private static List<Carta> UnoCarta_ListaNuevasEdiciones = new List<Carta>();
        //private static List<Carta> DosCarta_ListaNuevasEdiciones = new List<Carta>();

        //#endregion
        //#region generar Rutas
        //private static string rutaNuevasEdiciones_CartasUno = AppDomain.CurrentDomain.BaseDirectory + "cartas_NuevasEdiciones1";
        //private static string rutaNuevasEdiciones_CartasDos = AppDomain.CurrentDomain.BaseDirectory + "cartas_NuevasEdiciones2";
        //private static string rutaNuevasEdiciones_PubsUno = AppDomain.CurrentDomain.BaseDirectory + "publicaciones_NuevasEdiciones1";
        //private static string rutaNuevasEdiciones_PubsDos = AppDomain.CurrentDomain.BaseDirectory + "publicaciones_NuevasEdiciones2";

        //private static string rutaPub = AppDomain.CurrentDomain.BaseDirectory + "listaPublicacionesStock";
        //private static string rutaCartas = AppDomain.CurrentDomain.BaseDirectory + "listaCartasStock";
        //private static string rutaClientes = AppDomain.CurrentDomain.BaseDirectory + "listaClientes";
        //#endregion

        /// <summary>
        /// Constructor privado y estático de la clase Controller. Instanciara todos los objetos de Serializadora y Listas.
        /// </summary>
        //static Controller()
        //{
        //    serializacionCarta = new SerializadoraXml<List<Carta>>();
        //    cartasXml = new List<Carta>();
        //    serializacionPubs = new SerializadoraXml<List<Publicacion>>();
        //    publicacionesXml = new List<Publicacion>();
        //    clientesXml = new List<Clientes>();
        //    serializacionCliente = new SerializadoraXml<List<Clientes>>();
        //}
        ///// <summary>
        ///// Carga los objetos clientes, publicaciones, cartas, barcos y listas.
        ///// 
        ///// </summary>
        //private static void cargarObjetos()
        //{
        //    #region AGREGAR BARCOS
        //    Barco barco1 = new Barco("SKANDI PACIFIC", Barco.tipoBarco.Bulker);
        //    Barco barco2 = new Barco("ALOLA", Barco.tipoBarco.Dredger);
        //    Barco barco3 = new Barco("BLAZING SUN", Barco.tipoBarco.Tanker);
        //    Barco barco4 = new Barco("OCEAN BREEZE", Barco.tipoBarco.Tanker);
        //    Barco barco5 = new Barco("BLUE SAPPHIRE", Barco.tipoBarco.Cargo);
        //    Barco barco6 = new Barco("CAPTAIN D", Barco.tipoBarco.Dredger);
        //    Barco barco7 = new Barco("SANTA BARBARA", Barco.tipoBarco.Fishing);
        //    Barco barco8 = new Barco("JOURNEY", Barco.tipoBarco.Livestock);
        //    Barco barco9 = new Barco("STRIMON", Barco.tipoBarco.Tanker);
        //    #endregion
        //    #region AGREGAR BARCOS A CLIENTES | INSTANCIAR CLIENTES
        //    clientesXml.Add(new Clientes("TRITON NAVEGACIONES SA"));
        //    clientesXml.Last().barcos.Add(barco1);
        //    clientesXml.Last().barcos.Add(barco2);
        //    clientesXml.Last().barcos.Add(barco9);
        //    clientesXml.Add(new Clientes("SAILING SEAS"));
        //    clientesXml.Last().barcos.Add(barco3);
        //    clientesXml.Last().barcos.Add(barco4);
        //    clientesXml.Add(new Clientes("AL MAR SA"));
        //    clientesXml.Last().barcos.Add(barco5);
        //    clientesXml.Add(new Clientes("POSEIDON SHIPPING"));
        //    clientesXml.Last().barcos.Add(barco6);
        //    clientesXml.Last().barcos.Add(barco7);
        //    clientesXml.Add(new Clientes("OBSIDIAN MARITIMA"));
        //    clientesXml.Last().barcos.Add(barco8);
        //    #endregion
        //    #region CARTAS AGREGA A LISTA

        //    cartasXml.Add(new Carta("Río de la Plata Interior", 2018, "SHN", "ARH118", 1, DateTime.Parse("22/02/2018")));
        //    barco1.cartas.Add(cartasXml.Last()); barco2.cartas.Add(cartasXml.Last()); barco7.cartas.Add(cartasXml.Last()); barco9.cartas.Add(cartasXml.Last());

        //    cartasXml.Add(new Carta("Puerto de Buenos Aires", 2018, "SHN", "ARH156", 1, DateTime.Parse("15/03/2018")));
        //    barco2.cartas.Add(cartasXml.Last()); barco4.cartas.Add(cartasXml.Last()); barco7.cartas.Add(cartasXml.Last()); barco9.cartas.Add(cartasXml.Last());

        //    cartasXml.Add(new Carta("Rada y Puerto La Plata", 2016, "SHN", "ARH157", 1, DateTime.Parse("15/05/2016")));
        //    barco1.cartas.Add(cartasXml.Last()); barco3.cartas.Add(cartasXml.Last()); barco6.cartas.Add(cartasXml.Last()); barco8.cartas.Add(cartasXml.Last());

        //    cartasXml.Add(new Carta("Desde Arroyo Chuy hasta Mar del Plata", 2010, "SOHMA", "UY1", 1, DateTime.Parse("01/01/2010")));
        //    barco4.cartas.Add(cartasXml.Last()); barco6.cartas.Add(cartasXml.Last()); barco9.cartas.Add(cartasXml.Last());

        //    cartasXml.Add(new Carta("Desde Arroyo Chuy hasta Montevideo", 2018, "SOHMA", "UY3", 1, DateTime.Parse("08/03/2018")));
        //    barco2.cartas.Add(cartasXml.Last()); barco4.cartas.Add(cartasXml.Last()); barco6.cartas.Add(cartasXml.Last()); barco8.cartas.Add(cartasXml.Last());

        //    cartasXml.Add(new Carta("Puerto de La Paloma ", 2005, "SOHMA", "UY19", 1, DateTime.Parse("23/04/2005")));
        //    barco1.cartas.Add(cartasXml.Last()); barco2.cartas.Add(cartasXml.Last()); barco6.cartas.Add(cartasXml.Last());

        //    cartasXml.Add(new Carta("Bahía de Maldonado e Isla de Lobos", 2018, "SOHMA", "UY31", 1, DateTime.Parse("21/06/2018")));
        //    barco4.cartas.Add(cartasXml.Last()); barco6.cartas.Add(cartasXml.Last()); barco9.cartas.Add(cartasXml.Last()); barco8.cartas.Add(cartasXml.Last());

        //    cartasXml.Add(new Carta("Aproximación al Puerto de Montevideo", 2018, "SOHMA", "UY40", 1, DateTime.Parse("06/09/2018")));
        //    barco1.cartas.Add(cartasXml.Last()); barco2.cartas.Add(cartasXml.Last()); barco6.cartas.Add(cartasXml.Last()); barco7.cartas.Add(cartasXml.Last());

        //    cartasXml.Add(new Carta("Gran Canaria to El Hierro", 2018, "ADMIRALTY", "BA1861", 1, DateTime.Parse("22/02/2010")));
        //    barco4.cartas.Add(cartasXml.Last()); barco5.cartas.Add(cartasXml.Last()); barco7.cartas.Add(cartasXml.Last()); barco9.cartas.Add(cartasXml.Last());

        //    cartasXml.Add(new Carta("Bahia de Montevideo", 2020, "ADMIRALTY", "BA001", 1, DateTime.Parse("15/02/2020")));
        //    barco3.cartas.Add(cartasXml.Last()); barco6.cartas.Add(cartasXml.Last()); barco9.cartas.Add(cartasXml.Last());
        //    cartasXml.Add(new Carta("Approaches to the Falkland Islands", 2018, "ADMIRALTY", "BA2505", 1, DateTime.Parse("25/05/2018")));
        //    barco1.cartas.Add(cartasXml.Last()); barco4.cartas.Add(cartasXml.Last()); barco7.cartas.Add(cartasXml.Last());
        //    cartasXml.Add(new Carta("Pebble Island to Port Fitzroy", 2018, "ADMIRALTY", "BA2507", 1, DateTime.Parse("25/05/2018")));
        //    barco2.cartas.Add(cartasXml.Last()); barco5.cartas.Add(cartasXml.Last()); barco9.cartas.Add(cartasXml.Last());
        //    cartasXml.Add(new Carta("Port Fitzroy to Eagle Passage", 2019, "ADMIRALTY", "BA2508", 1, DateTime.Parse("15/03/2019")));
        //    barco4.cartas.Add(cartasXml.Last()); barco6.cartas.Add(cartasXml.Last()); barco7.cartas.Add(cartasXml.Last());
        //    cartasXml.Add(new Carta("The Falkland Islands", 2019, "ADMIRALTY", "BA2512", 1, DateTime.Parse("21/03/2019")));
        //    barco5.cartas.Add(cartasXml.Last()); barco7.cartas.Add(cartasXml.Last()); barco9.cartas.Add(cartasXml.Last());
        //    cartasXml.Add(new Carta("Eagle Passage to New Island", 2020, "ADMIRALTY", "BA2513", 1, DateTime.Parse("15/03/2020")));
        //    barco2.cartas.Add(cartasXml.Last()); barco4.cartas.Add(cartasXml.Last()); barco8.cartas.Add(cartasXml.Last());
        //    cartasXml.Add(new Carta("New Island to Pebble Island", 2018, "ADMIRALTY", "BA2514", 1, DateTime.Parse("22/02/2018")));
        //    barco3.cartas.Add(cartasXml.Last()); barco5.cartas.Add(cartasXml.Last()); barco7.cartas.Add(cartasXml.Last());

        //    cartasXml.Add(new Carta("Río Paraná 1", 2019, "SHN", "H1001", 1, DateTime.Parse("04/07/2019")));
        //    barco1.cartas.Add(cartasXml.Last()); barco4.cartas.Add(cartasXml.Last()); barco5.cartas.Add(cartasXml.Last()); barco9.cartas.Add(cartasXml.Last());
        //    cartasXml.Add(new Carta("Río Paraná 2", 2012, "SHN", "H1002", 1, DateTime.Parse("12/06/2012")));
        //    barco2.cartas.Add(cartasXml.Last()); barco3.cartas.Add(cartasXml.Last()); barco6.cartas.Add(cartasXml.Last()); barco8.cartas.Add(cartasXml.Last());

        //    cartasXml.Add(new Carta("Río Paraná 3", 2005, "SHN", "H1003", 1, DateTime.Parse("02/02/2005")));
        //    barco3.cartas.Add(cartasXml.Last()); barco5.cartas.Add(cartasXml.Last()); barco9.cartas.Add(cartasXml.Last());
        //    cartasXml.Add(new Carta("Río Paraná 4", 2020, "SHN", "H1004", 1, DateTime.Parse("06/02/2020")));
        //    barco1.cartas.Add(cartasXml.Last()); barco5.cartas.Add(cartasXml.Last()); barco7.cartas.Add(cartasXml.Last());
        //    cartasXml.Add(new Carta("Río Paraná 5", 2018, "SHN", "H1005", 1, DateTime.Parse("22/05/2018")));

        //    barco2.cartas.Add(cartasXml.Last()); barco6.cartas.Add(cartasXml.Last()); barco8.cartas.Add(cartasXml.Last());
        //    cartasXml.Add(new Carta("Río Paraná 6", 2019, "SHN", "H1006", 1, DateTime.Parse("22/01/2019")));

        //    barco1.cartas.Add(cartasXml.Last()); barco5.cartas.Add(cartasXml.Last()); barco6.cartas.Add(cartasXml.Last()); barco9.cartas.Add(cartasXml.Last());
        //    cartasXml.Add(new Carta("Río Paraná 7", 2012, "SHN", "H1007", 1, DateTime.Parse("03/02/2012")));
        //    barco1.cartas.Add(cartasXml.Last()); barco2.cartas.Add(cartasXml.Last()); barco3.cartas.Add(cartasXml.Last()); barco7.cartas.Add(cartasXml.Last());

        //    cartasXml.Add(new Carta("Río Paraná 8", 2005, "SHN", "H1008", 1, DateTime.Parse("22/02/2005")));
        //    barco5.cartas.Add(cartasXml.Last()); barco7.cartas.Add(cartasXml.Last()); barco9.cartas.Add(cartasXml.Last());
        //    cartasXml.Add(new Carta("Río Paraná 9", 2020, "SHN", "H1009", 1, DateTime.Parse("15/02/2010")));
        //    barco3.cartas.Add(cartasXml.Last()); barco6.cartas.Add(cartasXml.Last()); barco8.cartas.Add(cartasXml.Last());
        //    cartasXml.Add(new Carta("Río Paraná 10", 2018, "SHN", "H1010", 1, DateTime.Parse("22/02/2018")));
        //    barco5.cartas.Add(cartasXml.Last()); barco7.cartas.Add(cartasXml.Last()); barco9.cartas.Add(cartasXml.Last());


        //    #endregion                      
        //    #region PUBLICACION AGREGAR A LISTA
        //    publicacionesXml.Add(new Publicacion(1, Publicacion.Formato.Digital, "Waste Assessment Guidelines", 2012, "IMO", "KB531E", 1));
        //    barco8.publicaciones.Add(publicacionesXml.Last()); barco7.publicaciones.Add(publicacionesXml.Last()); barco6.publicaciones.Add(publicacionesXml.Last()); 

        //    publicacionesXml.Add(new Publicacion(2, Publicacion.Formato.Hardbook, "IMDG Code Supplement", 2008, "IMO", "KK210F", 1)); //here
        //    barco7.publicaciones.Add(publicacionesXml.Last()); barco4.publicaciones.Add(publicacionesXml.Last()); barco3.publicaciones.Add(publicacionesXml.Last()); barco1.publicaciones.Add(publicacionesXml.Last());

        //    publicacionesXml.Add(new Publicacion(2, Publicacion.Formato.Digital, "IMDG Code Supplement", 2008, "IMO", "KK210M", 1)); //here
        //    barco8.publicaciones.Add(publicacionesXml.Last()); barco5.publicaciones.Add(publicacionesXml.Last()); barco2.publicaciones.Add(publicacionesXml.Last()); barco1.publicaciones.Add(publicacionesXml.Last());

        //    publicacionesXml.Add(new Publicacion(1, Publicacion.Formato.Hardbook, "2011 ESP Code, 2020", 2020, "IMO", "KC265F", 1));
        //    barco7.publicaciones.Add(publicacionesXml.Last()); barco5.publicaciones.Add(publicacionesXml.Last()); barco3.publicaciones.Add(publicacionesXml.Last());

        //    publicacionesXml.Add(new Publicacion(2, Publicacion.Formato.Hardbook, "SOLAS Consolidated Edition", 2004, "IMO", "KA110S", 1)); //here
        //    barco8.publicaciones.Add(publicacionesXml.Last()); barco7.publicaciones.Add(publicacionesXml.Last()); barco5.publicaciones.Add(publicacionesXml.Last()); barco3.publicaciones.Add(publicacionesXml.Last());

        //    publicacionesXml.Add(new Publicacion(2, Publicacion.Formato.Digital, "SOLAS Consolidated Edition", 2004, "IMO", "KA110S", 1)); //here
        //    barco7.publicaciones.Add(publicacionesXml.Last()); barco5.publicaciones.Add(publicacionesXml.Last()); barco4.publicaciones.Add(publicacionesXml.Last()); barco2.publicaciones.Add(publicacionesXml.Last()); barco1.publicaciones.Add(publicacionesXml.Last());
        //    barco9.publicaciones.Add(publicacionesXml.Last());

        //    publicacionesXml.Add(new Publicacion(1, Publicacion.Formato.Hardbook, "31st Session 2019", 2019, "IMO", "KG110S", 1)); //here
        //    barco9.publicaciones.Add(publicacionesXml.Last());
        //    barco8.publicaciones.Add(publicacionesXml.Last()); barco5.publicaciones.Add(publicacionesXml.Last()); barco3.publicaciones.Add(publicacionesXml.Last());

        //    publicacionesXml.Add(new Publicacion(1, Publicacion.Formato.Hardbook, "Nautical Almanac", 2020, "Admiralty", "NP314-21", 1)); //here
        //    barco6.publicaciones.Add(publicacionesXml.Last()); barco4.publicaciones.Add(publicacionesXml.Last()); barco1.publicaciones.Add(publicacionesXml.Last());

        //    publicacionesXml.Add(new Publicacion(1, Publicacion.Formato.Hardbook, "Mariner's Handbook", 2021, "IMO", "NP100", 1));
        //    barco8.publicaciones.Add(publicacionesXml.Last()); barco5.publicaciones.Add(publicacionesXml.Last()); barco2.publicaciones.Add(publicacionesXml.Last()); barco1.publicaciones.Add(publicacionesXml.Last());

        //    publicacionesXml.Add(new Publicacion(1, Publicacion.Formato.Digital, "Mariner's Handbook", 2021, "IMO", "NP100", 1));
        //    barco6.publicaciones.Add(publicacionesXml.Last()); barco5.publicaciones.Add(publicacionesXml.Last());

        //    publicacionesXml.Add(new Publicacion(1, Publicacion.Formato.Hardbook, "Admiralty Tide Tables (ATT) South China Sea and Indonesia", 2020, "2020", "NP205", 1)); //here
        //    barco8.publicaciones.Add(publicacionesXml.Last()); barco6.publicaciones.Add(publicacionesXml.Last()); barco4.publicaciones.Add(publicacionesXml.Last()); barco2.publicaciones.Add(publicacionesXml.Last()); barco1.publicaciones.Add(publicacionesXml.Last());

        //    publicacionesXml.Add(new Publicacion(1, Publicacion.Formato.Hardbook, "Admiralty Tide Tables (ATT) United Kingdom and Ireland", 2019, "Admiralty", "NP201", 1)); barco3.publicaciones.Add(publicacionesXml.Last()); barco1.publicaciones.Add(publicacionesXml.Last());

        //    publicacionesXml.Add(new Publicacion(1, Publicacion.Formato.Hardbook, "Admiralty Sailing Directions: Arctic Pilot", 2018, "Admiralty", "NP12", 1));
        //    barco7.publicaciones.Add(publicacionesXml.Last()); barco5.publicaciones.Add(publicacionesXml.Last());

        //    publicacionesXml.Add(new Publicacion(1, Publicacion.Formato.Hardbook, "Admiralty Sailing Directions: Bay of Biscay Pilot", 2019, "Admiralty", "NP22", 1)); barco2.publicaciones.Add(publicacionesXml.Last());
        //    barco8.publicaciones.Add(publicacionesXml.Last()); barco7.publicaciones.Add(publicacionesXml.Last()); barco5.publicaciones.Add(publicacionesXml.Last()); barco9.publicaciones.Add(publicacionesXml.Last());

        //    publicacionesXml.Add(new Publicacion(1, Publicacion.Formato.Hardbook, "ISM Code and Guidelines", 2018, "IMO", "ID117E", 1));
        //    barco9.publicaciones.Add(publicacionesXml.Last());
        //    barco7.publicaciones.Add(publicacionesXml.Last()); barco5.publicaciones.Add(publicacionesXml.Last());

        //    publicacionesXml.Add(new Publicacion(1, Publicacion.Formato.Digital, "ISM Code and Guidelines", 2018, "IMO", "ID117E", 1));
        //    barco1.publicaciones.Add(publicacionesXml.Last());  barco8.publicaciones.Add(publicacionesXml.Last()); barco4.publicaciones.Add(publicacionesXml.Last()); barco9.publicaciones.Add(publicacionesXml.Last());

        //    publicacionesXml.Add(new Publicacion(1, Publicacion.Formato.Hardbook, "Jurisdicciones Marítimas", 2018, "SOHMA", "UYP3", 1));
        //    barco6.publicaciones.Add(publicacionesXml.Last()); barco5.publicaciones.Add(publicacionesXml.Last()); barco3.publicaciones.Add(publicacionesXml.Last()); barco2.publicaciones.Add(publicacionesXml.Last()); barco1.publicaciones.Add(publicacionesXml.Last()); barco9.publicaciones.Add(publicacionesXml.Last());

        //    publicacionesXml.Add(new Publicacion(1, Publicacion.Formato.Hardbook, "Catálogo de Cartas y Publicaciones Náuticas", 2002, "SOHMA", "UYP2", 1));
        //    barco5.publicaciones.Add(publicacionesXml.Last()); barco4.publicaciones.Add(publicacionesXml.Last()); barco2.publicaciones.Add(publicacionesXml.Last());
        //    barco9.publicaciones.Add(publicacionesXml.Last());

        //    publicacionesXml.Add(new Publicacion(1, Publicacion.Formato.Hardbook, "Sistema de Balizamiento Marítimo I.A.L.A.", 2018, "SOHMA", "UYP5", 1));
        //    barco5.publicaciones.Add(publicacionesXml.Last()); barco3.publicaciones.Add(publicacionesXml.Last()); barco1.publicaciones.Add(publicacionesXml.Last());

        //    publicacionesXml.Add(new Publicacion(1, Publicacion.Formato.Hardbook, "Load Lines, Consolidated", 2005, "IMO", "IB701E", 1));
        //    barco8.publicaciones.Add(publicacionesXml.Last()); barco4.publicaciones.Add(publicacionesXml.Last());

        //    publicacionesXml.Add(new Publicacion(1, Publicacion.Formato.Hardbook, "Tonnage Measurement of Ships 1969", 1970, "IMO", "I713E", 1));
        //    barco5.publicaciones.Add(publicacionesXml.Last()); barco3.publicaciones.Add(publicacionesXml.Last()); barco2.publicaciones.Add(publicacionesXml.Last()); barco1.publicaciones.Add(publicacionesXml.Last());

        //    publicacionesXml.Add(new Publicacion(1, Publicacion.Formato.Hardbook, "Guidelines of Fatigue", 2019, "IMO", "IMO968E", 1));
        //    barco8.publicaciones.Add(publicacionesXml.Last()); barco6.publicaciones.Add(publicacionesXml.Last());
        //    barco5.publicaciones.Add(publicacionesXml.Last()); barco4.publicaciones.Add(publicacionesXml.Last()); barco3.publicaciones.Add(publicacionesXml.Last());

        //    publicacionesXml.Add(new Publicacion(1, Publicacion.Formato.Hardbook, "SUA Convention, Suppression of Unlawful Acts", 2004, "IMO", "IA462E", 1));
        //    barco5.publicaciones.Add(publicacionesXml.Last()); barco4.publicaciones.Add(publicacionesXml.Last()); barco2.publicaciones.Add(publicacionesXml.Last()); barco1.publicaciones.Add(publicacionesXml.Last());

        //    publicacionesXml.Add(new Publicacion(1, Publicacion.Formato.Hardbook, "Life-Saving Appliance (LSA) Code", 2017, "IMO", "IE982E", 1));
        //    barco9.publicaciones.Add(publicacionesXml.Last()); barco7.publicaciones.Add(publicacionesXml.Last()); barco1.publicaciones.Add(publicacionesXml.Last());

        //    publicacionesXml.Add(new Publicacion(1, Publicacion.Formato.Hardbook, "COLREG CONSOLIDATED EDITION", 2018, "IMO", "COLREG", 1));
        //    barco6.publicaciones.Add(publicacionesXml.Last());  barco8.publicaciones.Add(publicacionesXml.Last()); barco5.publicaciones.Add(publicacionesXml.Last()); barco4.publicaciones.Add(publicacionesXml.Last()); barco3.publicaciones.Add(publicacionesXml.Last()); barco2.publicaciones.Add(publicacionesXml.Last()); barco1.publicaciones.Add(publicacionesXml.Last());

        //    publicacionesXml.Add(new Publicacion(1, Publicacion.Formato.Hardbook, "Facilitation Convention (FAL)", 2017, "IMO", "ID350E", 1));
        //    barco8.publicaciones.Add(publicacionesXml.Last()); barco4.publicaciones.Add(publicacionesXml.Last());
        //    barco9.publicaciones.Add(publicacionesXml.Last());

        //    publicacionesXml.Add(new Publicacion(1, Publicacion.Formato.Hardbook, "Fire Safety Systems (FSS) Code", 2015, "IMO", "IB155E", 1));
        //    barco6.publicaciones.Add(publicacionesXml.Last()); barco3.publicaciones.Add(publicacionesXml.Last()); barco1.publicaciones.Add(publicacionesXml.Last());

        //    publicacionesXml.Add(new Publicacion(1, Publicacion.Formato.Hardbook, "IAMSAR Manual Volume III", 2016, "WITHERBY", "BPG-2016", 1));
        //    barco2.publicaciones.Add(publicacionesXml.Last());
        //    barco9.publicaciones.Add(publicacionesXml.Last());

        //    publicacionesXml.Add(new Publicacion(1, Publicacion.Formato.Digital, "ALRS 2", 2015, "Admiralty", "NP23", 1));
        //    barco8.publicaciones.Add(publicacionesXml.Last()); barco5.publicaciones.Add(publicacionesXml.Last()); barco2.publicaciones.Add(publicacionesXml.Last()); barco1.publicaciones.Add(publicacionesXml.Last());

        //    publicacionesXml.Add(new Publicacion(1, Publicacion.Formato.Digital, "ALRS 2", 2015, "Admiralty", "NP23", 1));
        //    barco4.publicaciones.Add(publicacionesXml.Last()); barco1.publicaciones.Add(publicacionesXml.Last());

        //    publicacionesXml.Add(new Publicacion(1, Publicacion.Formato.Digital, "ALRS 2", 2015, "Admiralty", "NP24", 1));
        //    barco8.publicaciones.Add(publicacionesXml.Last()); barco6.publicaciones.Add(publicacionesXml.Last()); barco3.publicaciones.Add(publicacionesXml.Last()); barco2.publicaciones.Add(publicacionesXml.Last());

        //    publicacionesXml.Add(new Publicacion(1, Publicacion.Formato.Hardbook, "International Code of Signals", 2005, "IMO", "IA994E", 1));
        //    barco8.publicaciones.Add(publicacionesXml.Last()); barco5.publicaciones.Add(publicacionesXml.Last()); barco3.publicaciones.Add(publicacionesXml.Last()); barco2.publicaciones.Add(publicacionesXml.Last());

        //    publicacionesXml.Add(new Publicacion(1, Publicacion.Formato.Digital, "International Code of Signals", 2005, "IMO", "IA994E", 1));
        //    barco5.publicaciones.Add(publicacionesXml.Last()); barco4.publicaciones.Add(publicacionesXml.Last()); barco3.publicaciones.Add(publicacionesXml.Last()); barco1.publicaciones.Add(publicacionesXml.Last());
        //    barco9.publicaciones.Add(publicacionesXml.Last());



        //    #endregion
        //}       
        ///// <summary>
        ///// Invoca a cargarObjetos y los guarda en formato XML en rutas preestablecidas.
        ///// </summary>
        //public static void GuardarXml()
        //{
        //    cargarObjetos();
        //    serializacionCarta.Guardar(rutaCartas, cartasXml);
        //    serializacionPubs.Guardar(rutaPub, publicacionesXml);
        //    serializacionCliente.Guardar(rutaClientes, clientesXml);
        //}
        ///// <summary>
        ///// Llama al metodo Leer para guardar cada objeto dentro de la lista, luego la devuelve.
        ///// </summary>
        ///// <param name="listaPub"></param>
        ///// <returns></returns>
        //public static  List<Publicacion> Deserializar(List<Publicacion> listaPub, string ruta)
        //{
        //   try
        //    {
        //        serializacionPubs.Leer(ruta, out listaPub);
        //        return listaPub;
        //    }
        //    catch (NullReferenceException)
        //    {
        //        throw new Exception("La lista es null");
        //    }
        //    catch (Exception e)
        //    {
        //        throw e;
        //    }
        //}
        ///// <summary>
        ///// Sobrecarga. Llama al metodo Leer para guardar cada objeto dentro de la lista, luego la devuelve.
        ///// </summary>
        ///// <param name="lista"></param>
        ///// <returns></returns>
        //public static  List<Carta> Deserializar(List<Carta> lista, string ruta)
        //{
        //    try
        //    {
        //       // Lista();
        //        serializacionCarta.Leer(ruta, out lista);
        //        return lista;
        //    }
        //    catch (NullReferenceException)
        //    {
        //        throw new Exception("La lista es null");
        //    }
        //}
        ///// <summary>
        ///// Sobrecarga. Llama al metodo Leer para guardar cada objeto dentro de la lista, luego la devuelve.
        ///// </summary>
        ///// <param name="lista"></param>
        ///// <returns></returns>
        //public static List<Clientes> Deserializar(List<Clientes> lista, string ruta)
        //{
        //    try
        //    {
        //        // Lista();
        //        serializacionCliente.Leer(ruta, out lista);
        //        return lista;
        //    }
        //    catch (NullReferenceException)
        //    {
        //        throw new Exception("La lista es null");
        //    }
        //}
        ///// <summary>
        ///// Crea y agrega los datos necesarios para poder subir archivos de 'nuevas ediciones'
        ///// </summary>
        //public static void agregarDatos_Serializar_NuevasEdiciones()
        //{
        //    UnoCarta_ListaNuevasEdiciones.Add(new Carta("Río de la Plata Interior", 2021, "SHN", "ARH118", 1, DateTime.Parse("10/05/2021")));
        //    UnoCarta_ListaNuevasEdiciones.Add(new Carta("Desde Arroyo Chuy hasta Mar del Plata", 2021, "SOHMA", "UY1", 1, DateTime.Parse("18/02/2021")));
        //    UnoCarta_ListaNuevasEdiciones.Add(new Carta("Puerto de La Paloma ", 2021, "SOHMA", "UY19", 1, DateTime.Parse("01/01/2021")));
        //    UnoCarta_ListaNuevasEdiciones.Add(new Carta("Gran Canaria to El Hierro", 201, "ADMIRALTY", "BA1861", 1, DateTime.Parse("22/01/2017")));
        //    UnoCarta_ListaNuevasEdiciones.Add(new Carta("The Falkland Islands", 2021, "ADMIRALTY", "BA2512", 1, DateTime.Parse("05/03/2021")));
        //    UnoCarta_ListaNuevasEdiciones.Add(new Carta("Muelle San Blas", 2021, "MANA", "MA123", 1, DateTime.Parse("05/03/2021")));

        //    serializacionCarta.Guardar(rutaNuevasEdiciones_CartasUno, UnoCarta_ListaNuevasEdiciones);


        //    DosCarta_ListaNuevasEdiciones.Add(new Carta("Río Paraná 1", 2010, "SHN", "H1001", 1, DateTime.Parse("22/02/2010")));
        //    DosCarta_ListaNuevasEdiciones.Add(new Carta("Río Paraná 3", 2021, "SHN", "H1003", 1, DateTime.Parse("14/04/2021")));
        //    DosCarta_ListaNuevasEdiciones.Add(new Carta("Río Paraná 6", 2021, "SHN", "H1006", 1, DateTime.Parse("11/06/2021")));
        //    DosCarta_ListaNuevasEdiciones.Add(new Carta("Río Paraná 5", 2021, "SHN", "H1005", 1, DateTime.Parse("01/01/2021")));
        //    DosCarta_ListaNuevasEdiciones.Add(new Carta("Donde chocó el Titanic", 2021, "JCAMERON","TINIC",
        //        1,DateTime.Parse("01/01/2021")));


        //    serializacionCarta.Guardar(rutaNuevasEdiciones_CartasDos, DosCarta_ListaNuevasEdiciones);

        //    UnoPubli_ListaNuevasEdiciones.Add(new Publicacion(2, Publicacion.Formato.Hardbook, "IMDG Code Supplement", 2021, "IMO", "KK210F", 1));
        //    UnoPubli_ListaNuevasEdiciones.Add(new Publicacion(2, Publicacion.Formato.Digital, "IMDG Code Supplement", 2021, "IMO", "KK210F", 1));
        //    UnoPubli_ListaNuevasEdiciones.Add(new Publicacion(2, Publicacion.Formato.Hardbook, "SOLAS Consolidated Edition", 2021, "IMO", "KA110S", 1));
        //    UnoPubli_ListaNuevasEdiciones.Add(new Publicacion(1, Publicacion.Formato.Hardbook, "Nautical Almanac", 2021, "Admiralty", "NP314-21", 1));

        //    UnoPubli_ListaNuevasEdiciones.Add(new Publicacion(1, Publicacion.Formato.Hardbook, "Garbage Record Book", 2021, "American Nautical", "LOGBOOK-GARBAGE", 1));
        //    UnoPubli_ListaNuevasEdiciones.Add(new Publicacion(1, Publicacion.Formato.Hardbook, "Ballast Water Record Book", 2021, "American Nautical", "LOGBOOK-BWM", 1));

        //    serializacionPubs.Guardar(rutaNuevasEdiciones_PubsUno, UnoPubli_ListaNuevasEdiciones);


        //    DosPubli_ListaNuevasEdiciones.Add(new Publicacion(1, Publicacion.Formato.Hardbook, "Admiralty Tide Tables (ATT) South China Sea and Indonesia", 2021, "2020", "NP205", 1));
        //    DosPubli_ListaNuevasEdiciones.Add(new Publicacion(1, Publicacion.Formato.Hardbook, "Admiralty Sailing Directions: Bay of Biscay Pilot", 2021, "Admiralty", "NP22", 1));
        //    DosPubli_ListaNuevasEdiciones.Add(new Publicacion(1, Publicacion.Formato.Hardbook, "Admiralty Tide Tables (ATT) United Kingdom and Ireland", 2021, "Admiralty", "NP201", 1));
        //    DosPubli_ListaNuevasEdiciones.Add(new Publicacion(1, Publicacion.Formato.Hardbook, "Engine Log Book", 2021, "Witherby Seamanship", "LOGBOOK-ENGINE", 1));

        //    serializacionPubs.Guardar(rutaNuevasEdiciones_PubsDos, DosPubli_ListaNuevasEdiciones);
        //}



        #endregion




    }
}
