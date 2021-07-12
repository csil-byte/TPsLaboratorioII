using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Entidades;
using Serializacion;
using VistaConsola;
using VistaForm.Nuevas_Ediciones;

namespace VistaForm {
    public delegate void NombreDelegado();
    public partial class Frm_NuevasEdiciones : Form {
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
        public Frm_NuevasEdiciones() {
            InitializeComponent();
        }
        /// <summary>
        /// Al cargarse el formulario Nuevas Ediciones, se instanciaran los objetos creados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_NuevasEdiciones_Load(object sender, EventArgs e) {
            publicaciones_nuevasEdiciones = new List<Publicacion>();
            cartas_nuevasEdiciones = new List<Carta>();
            serializadoraTxtPublicacion = new SerializadoraTxt<Publicacion>();
            serializadoraTxtCarta = new SerializadoraTxt<Carta>();
            stock_Dtgv = new Stock_Dtgv<Publicacion, Carta, Barco>();

            txtAbrirCartas.Text = "Favor abrir listado de cartas";
            txtAbrirPub.Text = "Favor abrir listado de publicaciones";
        }

        /// <summary>
        /// Instanciará formulario para elegir tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenPublicaciones_btnEventPublicaciones(object sender, EventArgs e) {
            try {
                FrmNuevasEdiciones_ElegirTabla formElegirTabla = new FrmNuevasEdiciones_ElegirTabla();
                NombreDelegado nombreDelegado = new NombreDelegado(formElegirTabla.Publicaciones_CargarLstBox);
                nombreDelegado();
                formElegirTabla.ShowDialog();
                stock_Dtgv.Add(publicaciones_dtgvFNE, Stock.nuevasEdiciones_Publicaciones);
                flagBtnPub = true;
                txtAbrirPub.Visible = false;
            } catch (Exception ex) {
                throw ex;
            }
        }

        /// <summary>
        /// Instanciará formulario para elegir tabla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenCartas_btnEventCartas(object sender, EventArgs e) {
            try {
                FrmNuevasEdiciones_ElegirTabla formElegirTabla = new FrmNuevasEdiciones_ElegirTabla();
                NombreDelegado nombreDelegado = new NombreDelegado(formElegirTabla.Cartas_CargarLstBox);
                nombreDelegado();

                formElegirTabla.ShowDialog();
                stock_Dtgv.Add(cartas_dtgvFNE, Stock.nuevasEdiciones_Cartas);
                flagBtnCarta = true;

                txtAbrirCartas.Visible = false;
            } catch (Exception ex) {
                throw ex;
            }
        }
        /// <summary>
        /// Verifica con una bandera que el usuario haya subido un archivo para poder generar el informe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_generarInforme_Click(object sender, EventArgs e) {
            if (flagBtnCarta == true && flagBtnPub == true) {
                InformeCompras frm_informeCompras = new InformeCompras();
                frm_informeCompras.Show();
            } else {
                MessageBox.Show("Deberá cargar archivos de Publicaciones y de Cartas primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Verifica con una bandera que el usuario haya subido un archivo para poder generar circulares de clientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PicHome_Click(object sender, EventArgs e) {
            this.Hide();
        }

        /// <summary>
        /// Al hacer click, se cerrará la aplicación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PicExit_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir del programa?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes) {
                Application.Exit();
            }
        }

    }



}
