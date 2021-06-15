using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.OleDb;
using System.Threading.Tasks;
using System.Windows.Forms;
using VistaConsola;
using Entidades;
using Serializacion;

namespace VistaForm
{
    public partial class Frm_NuevasEdiciones : Form
    {
        #region creación de objetos, listas y atributos
        private static string rutaNuevasEdiciones_CartasUno = AppDomain.CurrentDomain.BaseDirectory + "cartas_NuevasEdiciones1";
        private static string rutaNuevasEdiciones_CartasDos = AppDomain.CurrentDomain.BaseDirectory + "cartas_NuevasEdiciones2";
        private static string rutaNuevasEdiciones_PubsUno = AppDomain.CurrentDomain.BaseDirectory + "publicaciones_NuevasEdiciones1";
        private static string rutaNuevasEdiciones_PubsDos = AppDomain.CurrentDomain.BaseDirectory + "publicaciones_NuevasEdiciones2";

        static public List<Publicacion> publicaciones_nuevasEdiciones;
        static public List<Carta> cartas_nuevasEdiciones;

        private SerializadoraTxt<Publicacion> serializadoraTxtPublicacion;
        private SerializadoraTxt<Carta> serializadoraTxtCarta;
        private Stock_Dtgv<Publicacion, Carta, Barco> stock_Dtgv;
        private bool flagBtnPub = false;
        private bool flagBtnCarta = false;
        #endregion
        public Frm_NuevasEdiciones()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Al cargarse el formulario Nuevas Ediciones, se instanciaran los objetos creados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_NuevasEdiciones_Load(object sender, EventArgs e)
        {
            publicaciones_nuevasEdiciones = new List<Publicacion>();
            cartas_nuevasEdiciones = new List<Carta>();
            serializadoraTxtPublicacion = new SerializadoraTxt<Publicacion>();
            serializadoraTxtCarta = new SerializadoraTxt<Carta>();
            stock_Dtgv = new Stock_Dtgv<Publicacion, Carta, Barco>();
        }
        /// <summary>
        /// Limpia mi lista de publicaciones. Al abrir un archivo de texto, se agregará a la lista de PUBLICACIONES, luego se mostrará en el datagridview.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenFile_btnEventPublicaciones(object sender, EventArgs e)
        {
            try
            { 
            Stock.nuevasEdiciones_Publicaciones.Clear();
            DialogResult resultado = openFileDialog1.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    string fileName = openFileDialog1.FileName;
                    Stock.nuevasEdiciones_Publicaciones.AddRange(Controller.Deserializar(Stock.nuevasEdiciones_Publicaciones, fileName));
                    stock_Dtgv.Add(publicaciones_dtgvFNE, Stock.nuevasEdiciones_Publicaciones);
                    flagBtnPub = true;
                }

            }
            catch(System.Exception)
            {
                MessageBox.Show("Favor subir un archivo XML de Publicaciones", "Error.",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        /// <summary>
        /// Al abrir un archivo de texto, se agregará a la lista de CARTAS, luego se mostrará en el datagridview.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenFile_btnEventCartas(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = openFileDialog2.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    Stock.nuevasEdiciones_Cartas.Clear();
                    openFileDialog2.ShowDialog();
                    string fileName = openFileDialog2.FileName;
                    Stock.nuevasEdiciones_Cartas.AddRange(Controller.Deserializar(Stock.nuevasEdiciones_Cartas, fileName));
                    stock_Dtgv.Add(cartas_dtgvFNE, Stock.nuevasEdiciones_Cartas);
                    flagBtnCarta = true;
                }
            }

            catch (System.Exception)
            {
                MessageBox.Show("Favor subir un archivo XML de Cartas", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /// <summary>
        /// Verifica con una bandera que el usuario haya subido un archivo para poder generar el informe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_generarInforme_Click(object sender, EventArgs e)
        {
            if (flagBtnCarta == true && flagBtnPub == true)
            {
                InformeCompras frm_informeCompras = new InformeCompras();
                frm_informeCompras.Show();
            }
            else
            {
                MessageBox.Show("Deberá cargar archivos de Publicaciones y de Cartas primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Verifica con una bandera que el usuario haya subido un archivo para poder generar circulares de clientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_circularClientes_Click(object sender, EventArgs e)
        {
            if (flagBtnCarta == true && flagBtnPub == true)
            {
                Frm_CircularClientes Form2 = new Frm_CircularClientes();
                Form2.Show();
            }
            else
            { 
                MessageBox.Show("Deberá cargar archivos de Publicaciones y de Cartas primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void picHome_Clic(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void picExit_Click(object sender, EventArgs e)
        {
            DialogResult result =  MessageBox.Show("¿Está seguro que desea salir del programa?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {             
                Application.Exit();
            }
        }
    }

    

    }
