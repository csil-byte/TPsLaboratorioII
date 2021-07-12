using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Entidades {
    public class ControllerDAO {
        private static string connectionStr;
        private static SqlConnection conexion;
        private static SqlCommand comando;
        public static int[] idBarcosCartas;
        public static int[] idBarcosPublicaciones;

        private static void Conectarse() {
            connectionStr = " Server = localhost ; Database = TP4; Trusted_Connection = true ; ";
            conexion = new SqlConnection(connectionStr);
            comando = new SqlCommand {
                CommandType = CommandType.Text,
                Connection = conexion
            };
        }

        #region Lectura
        /// <summary>
        /// Lectura de cartas según lista
        /// </summary>
        /// <param name="cartasStock"></param>
        public static void LeerCartas(List<Carta> cartasStock) {
            Conectarse();
            cartasStock.Clear();
            Carta carta;
            conexion.Open();
            comando.CommandText = "SELECT * FROM dbo.cartasStock";

            SqlDataReader myReader = comando.ExecuteReader();

            try {
                while (myReader.Read()) {
                    DateTime dateTime = new DateTime();
                    dateTime = (DateTime)myReader["FechaEdicion"];

                    carta = new Carta(myReader["Nombre"].ToString(), Convert.ToInt32(myReader["Edicion"]), myReader["Editor"].ToString(), myReader["Codigo"].ToString(), Convert.ToInt32(myReader["Cantidad"]), dateTime);

                    cartasStock.Add(carta);

                    string[] words = ((myReader["IdBarcos"]).ToString()).Split(',');
                    int[] idBarcosCartas = new int[words.Length];
                    for (int i = 0; i < words.Length; i++) {
                        idBarcosCartas[i] = Convert.ToInt32(words[i]);
                    }
                    carta.obtenenerIdBarcos(idBarcosCartas);
                    Controller.AgregarCartasABarcos(idBarcosCartas, carta);
                }
            } catch (Exception e) {
                throw new ControllerDaoExcepcion("Hubo un error");
            } finally {
                myReader.Close();
                conexion.Close();
            }

        }
        /// <summary>
        /// Lectura de cartas según tabla
        /// </summary>
        /// <param name="cartasStock"></param>
        /// <param name="tabla"></param>
        public static void LeerCartas(List<Carta> cartasStock, string tabla) {
            Conectarse();
            cartasStock.Clear();
            Carta carta;
            conexion.Open();

            string query = $"Select * from {tabla}";
            comando.CommandText = query;
            SqlDataReader myReader = comando.ExecuteReader();

            try {
                while (myReader.Read()) {
                    DateTime dateTime = new DateTime();
                    dateTime = (DateTime)myReader["FechaEdicion"];

                    carta = new Carta(myReader["Nombre"].ToString(), Convert.ToInt32(myReader["Edicion"]), myReader["Editor"].ToString(), myReader["Codigo"].ToString(), Convert.ToInt32(myReader["Cantidad"]), dateTime);

                    cartasStock.Add(carta);
                }
            } catch (Exception e) {
                throw new ControllerDaoExcepcion("Hubo un error");
            } finally {
                myReader.Close();
                conexion.Close();
            }

        }
       /// <summary>
       /// Lectura según listado
       /// </summary>
       /// <param name="publicacionesStock"></param>
        public static void LeerPublicaciones(List<Publicacion> publicacionesStock) {
            Conectarse();
            publicacionesStock.Clear();

            Publicacion publicacion;
            conexion.Open();
            comando.CommandText = "SELECT * FROM dbo.publicacionesStock";
            SqlDataReader myReader = comando.ExecuteReader();
            try {
                while (myReader.Read()) {

                    publicacion = new Publicacion(
                    Convert.ToInt32(myReader["Tomos"]),
                    (Publicacion.Formato)Enum.Parse(typeof(Publicacion.Formato), myReader["eFormato"].ToString()),
                    myReader["Titulo"].ToString(),
                    Convert.ToInt32(myReader["Edicion"]),
                    myReader["Editor"].ToString(),
                    myReader["Codigo"].ToString(),
                    Convert.ToInt32(myReader["Cantidad"]));

                    publicacionesStock.Add(publicacion);

                    string[] words = ((myReader["IdBarcos"]).ToString()).Split(',');
                    int[] idBarcosPublicaciones = new int[words.Length];
                    for (int i = 0; i < words.Length; i++) {
                        idBarcosPublicaciones[i] = Convert.ToInt32(words[i]);
                    }
                    publicacion.obtenenerIdBarcos(idBarcosPublicaciones);
                    Controller.AgregarPublicacionesABarcos(idBarcosPublicaciones, publicacion);
                }
            } catch (Exception e) {
                throw e;
            } finally {
                myReader.Close();
                conexion.Close();
            }
        }
       /// <summary>
       /// Lectura según tabla
       /// </summary>
       /// <param name="publicacionesStock"></param>
       /// <param name="tabla"></param>
        public static void LeerPublicaciones(List<Publicacion> publicacionesStock, string tabla) {
            Conectarse();
            publicacionesStock.Clear();
            Publicacion publicacion;
            conexion.Open();
            string query = $"Select * from {tabla}";
            comando.CommandText = query;
            SqlDataReader myReader = comando.ExecuteReader();
            try {
                while (myReader.Read()) {

                    publicacion = new Publicacion(
                    Convert.ToInt32(myReader["Tomos"]),
                    (Publicacion.Formato)Enum.Parse(typeof(Publicacion.Formato), myReader["eFormato"].ToString()),
                    myReader["Titulo"].ToString(),
                    Convert.ToInt32(myReader["Edicion"]),
                    myReader["Editor"].ToString(),
                    myReader["Codigo"].ToString(),
                    Convert.ToInt32(myReader["Cantidad"]));

                    publicacionesStock.Add(publicacion);

                    //string[] words = ((myReader["IdBarcos"]).ToString()).Split(',');
                    //int[] idBarcosPublicaciones = new int[words.Length];
                    //for (int i = 0; i < words.Length; i++)
                    //{
                    //    idBarcosPublicaciones[i] = Convert.ToInt32(words[i]);
                    //}
                    //publicacion.obtenenerIdBarcos(idBarcosPublicaciones);
                    //Controller.AgregarPublicacionesABarcos(idBarcosPublicaciones, publicacion);
                }
            } catch (Exception e) {
                throw e;
            } finally {
                myReader.Close();
                conexion.Close();
            }
        }       
       /// <summary>
       /// Lectura de clientes
       /// </summary>
       /// <param name="listaClientes"></param>
        public static void LeerClientes(List<Clientes> listaClientes) {
            listaClientes.Clear();
            Conectarse();
            try {
                Clientes cliente;
                conexion.Open();
                comando.CommandText = "SELECT * FROM dbo.clientes";
                SqlDataReader myReader = comando.ExecuteReader();

                while (myReader.Read()) {
                    cliente = new Clientes(myReader["Nombre"].ToString(), Convert.ToInt32(myReader["IdCliente"]));
                    listaClientes.Add(cliente);
                }
                myReader.Close();
                conexion.Close();
            } catch (Exception e) {
                throw e;
            }
        }        
        /// <summary>
        /// Lectura de barcos
        /// </summary>
        /// <param name="listaBarcos"></param>
        public static void LeerBarcos(List<Barco> listaBarcos) {
            listaBarcos.Clear();
            Conectarse();
            try {
                Barco barco;
                conexion.Open();
                comando.CommandText = "SELECT * FROM dbo.barcos";
                SqlDataReader myReader = comando.ExecuteReader();

                while (myReader.Read()) {
                    barco = new Barco(myReader["NOMBRE BARCO"].ToString(), (Barco.tipoBarco)Enum.Parse(typeof(Barco.tipoBarco), myReader["TIPO BARCO"].ToString()), Convert.ToInt32(myReader["ID CLIENTE"]), Convert.ToInt32(myReader["ID BARCO"]));
                    listaBarcos.Add(barco);
                }
                myReader.Close();
                conexion.Close();
            } catch (Exception e) {
                throw e;
            }
        }
        #endregion

        #region Guardar
        public static void GuardarCarta(Carta carta, int idBarco, bool estaDuplicada) {

            Conectarse();
            conexion.Open();

            if (estaDuplicada == false) {
                comando.CommandText = "INSERT INTO [cartasStock] ([Edicion], [Nombre], [Editor], [Codigo], [Cantidad], [FechaEdicion], [IdBarcos])" + "Values (@edicion, @nombre, @editor, @codigo, @cantidad, @fechaEdicion, @idBarcos)";
                comando.Parameters.AddWithValue("@edicion", carta.Edicion);
                comando.Parameters.AddWithValue("@nombre", carta.Titulo);
                comando.Parameters.AddWithValue("@editor", carta.Editor);
                comando.Parameters.AddWithValue("@codigo", carta.Codigo);
                comando.Parameters.AddWithValue("@cantidad", carta.Cantidad);
                comando.Parameters.AddWithValue("@fechaEdicion", carta.FechaCorreccion);
                comando.Parameters.AddWithValue("@idBarcos", idBarco);
                comando.ExecuteNonQuery();
            } else {
                int idCarta = EncontrarCartaPorId(carta);
                comando.CommandText = "UPDATE [cartasStock] SET IdBarcos = concat([IdBarcos], ', ', @IdBarcossssss) WHERE IdCarta = @value";
                comando.Parameters.AddWithValue("@value", idCarta);
                comando.Parameters.AddWithValue("@IdBarcossssss", idBarco.ToString());
                comando.ExecuteNonQuery();
            }
            conexion.Close();
        }
        public static void GuardarPublicacion(Publicacion publicacion, int idBarco, bool estaDuplicada) {

            Conectarse();
            conexion.Open();
            int idPublicacion;

            try {
                if (estaDuplicada == false) {
                    comando.CommandText = "INSERT INTO [publicacionesStock] ([Edicion], [Titulo], [Editor], [Codigo], [Cantidad], [eFormato], [Tomos], [IdBarcos])" + "Values (@edicion, @titulo, @editor, @codigo, @cantidad, @eFormato, @Tomos, @idBarcos)";
                    comando.Parameters.AddWithValue("@edicion", publicacion.Edicion);
                    comando.Parameters.AddWithValue("@titulo", publicacion.Titulo);
                    comando.Parameters.AddWithValue("@editor", publicacion.Editor);
                    comando.Parameters.AddWithValue("@codigo", publicacion.Codigo);
                    comando.Parameters.AddWithValue("@cantidad", publicacion.Cantidad);// add instead of replace
                    comando.Parameters.AddWithValue("@eFormato", publicacion.eFormato.ToString());
                    comando.Parameters.AddWithValue("@Tomos", publicacion.Tomos);
                    comando.Parameters.AddWithValue("@idBarcos", idBarco);
                    comando.ExecuteNonQuery();
                } else {
                    idPublicacion = EncontrarPublicacionPorId(publicacion);
                    comando.CommandText = "UPDATE [publicacionesStock] SET IdBarcos = concat([IdBarcos], ', ', @IdBarcoss) WHERE IdPublicacion = @value";
                    comando.Parameters.AddWithValue("@value", idPublicacion);
                    comando.Parameters.AddWithValue("@IdBarcoss", idBarco); //// append instead of replace
                    comando.ExecuteNonQuery();
                }
            } catch (Exception exe) {
                throw new Exception(exe.Message);
            } finally {
                conexion.Close();

            }
        }
        #endregion

        #region Auxiliares
        /// <summary>
        ///  Busca según el código el ID al que corresponde el objeto.
        /// </summary>
        /// <param name="publicacion"></param>
        /// <returns></returns>
        private static int EncontrarPublicacionPorId(Publicacion publicacion) {
            comando.CommandText = "SELECT * FROM dbo.publicacionesStock WHERE [Codigo] = @publicacionCodigo";
            comando.Parameters.AddWithValue("@publicacionCodigo", publicacion.Codigo);
            SqlDataReader myReader = comando.ExecuteReader();
            myReader.Read();
            int idPublicacion = Convert.ToInt32(myReader["IdPublicacion"]);
            myReader.Close();
            return idPublicacion;
        }
        /// <summary>
        /// Busca según el código el ID al que corresponde el objeto.
        /// </summary>
        /// <param name="carta"></param>
        /// <returns></returns>
        private static int EncontrarCartaPorId(Carta carta) {
            comando.CommandText = "SELECT * FROM dbo.cartasStock WHERE [Codigo] = @cartaCodigo";
            comando.Parameters.AddWithValue("@cartaCodigo", carta.Codigo);
            SqlDataReader myReader = comando.ExecuteReader();
            int idCarta;
            myReader.Read();
            idCarta = Convert.ToInt32(myReader["IdCarta"]);
            myReader.Close();
            return idCarta;
        }



        #endregion

    }
}
