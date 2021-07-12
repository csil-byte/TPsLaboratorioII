using System;
using System.Windows.Forms;
using Entidades;

namespace VistaForm.Nuevas_Ediciones {
    public partial class FrmNuevasEdiciones_ElegirTabla : Form {

        /// <summary>
        /// Inicializará el componente
        /// </summary>
        public FrmNuevasEdiciones_ElegirTabla() {
            InitializeComponent();
        }

        /// <summary>
        /// Cargará las opciones para cartas
        /// </summary>
        public void Cartas_CargarLstBox() {
            lstbxTablas.Items.Add("Cartas especiales");
            lstbxTablas.Items.Add("Cartas Río Paraná");
        }

        /// <summary>
        /// Cargará las opciones para publicaciones
        /// </summary>
        public void Publicaciones_CargarLstBox() {
            lstbxTablas.Items.Add("Listado de publicaciones especiales");
            lstbxTablas.Items.Add("Listado de publicaciones ordinarios");
        }

        /// <summary>
        /// Según la opción seleccionada, leerá 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAceptar_click(object sender, EventArgs e) {
            string tablaSeleccionada = lstbxTablas.SelectedItem.ToString();
            switch (tablaSeleccionada) {
                case "Cartas especiales":
                    ControllerDAO.LeerCartas(Stock.nuevasEdiciones_Cartas, "dbo.cartasNuevasEdiciones1");
                    break;
                case "Cartas Río Paraná":
                    ControllerDAO.LeerCartas(Stock.nuevasEdiciones_Cartas, "dbo.cartasNuevasEdiciones2");
                    break;
                case "Listado de publicaciones especiales":
                    ControllerDAO.LeerPublicaciones(Stock.nuevasEdiciones_Publicaciones, "dbo.publicacionesNuevasEdiciones1");
                    break;
                case "Listado de publicaciones ordinarios":
                    ControllerDAO.LeerPublicaciones(Stock.nuevasEdiciones_Publicaciones, "dbo.publicacionesNuevasEdiciones2");
                    break;
            }
            this.Close();
        }
    }
}
