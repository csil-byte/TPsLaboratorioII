using System;
using System.Windows.Forms;
using Entidades;



namespace VistaForm {
    public partial class Frm_Mercaderia : Form {
        //private static string rutaPub = AppDomain.CurrentDomain.BaseDirectory + "listaPublicacionesStock";
        //private static string rutaCartas = AppDomain.CurrentDomain.BaseDirectory + "listaCartasStock";

        private FrmInicioPrograma initForm;
        public Stock stock;
        public Frm_Mercaderia() {
            InitializeComponent();

        }

        /// <summary>
        /// Abrirá Form Stock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Stock_Click(object sender, EventArgs e) {
            Frm_Stock frm_Stock = new Frm_Stock();
            frm_Stock.Show();

        }
        /// <summary>
        /// Al cargarse este menú principal, guardará en archivos XML todo lo necesario para el funcionamiento del programa.
        /// Instanciará el objeto Stock, el cual es un singleton.
        /// Y deserializará las cartas y publicaciones en listas para su posterior manejo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Mercaderia_Load(object sender, EventArgs e) {
            initForm = new FrmInicioPrograma();
            initForm.ShowDialog();

            stock = Stock.GetStock();
            ControllerDAO.LeerBarcos(Stock.Barcos);
            ControllerDAO.LeerCartas(Stock.Cartas);
            ControllerDAO.LeerClientes(Stock.Clientes);
            ControllerDAO.LeerPublicaciones(Stock.Publicaciones);
            Controller.ObtenerBarcosPorCadaCliente(Stock.Clientes, Stock.Barcos);
        }

        /// <summary>
        /// Abrirá Form Nuevas Ediciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Actualizacion_Click(object sender, EventArgs e) {
            Frm_NuevasEdiciones frm_NuevasEdiciones = new Frm_NuevasEdiciones();
            frm_NuevasEdiciones.Show();
        }

    }
}
