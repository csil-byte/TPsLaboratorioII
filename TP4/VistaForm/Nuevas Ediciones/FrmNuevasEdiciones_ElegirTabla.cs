using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaForm.Nuevas_Ediciones
{
    public partial class FrmNuevasEdiciones_ElegirTabla : Form
    {

        public FrmNuevasEdiciones_ElegirTabla()
        {
            InitializeComponent();
        }

        public void Cartas_CargarLstBox()
        {
            lstbxTablas.Items.Add("dbo.cartasNuevasEdiciones1");
            lstbxTablas.Items.Add("dbo.cartasNuevasEdiciones2");
        }

        public void Publicaciones_CargarLstBox()
        {
            lstbxTablas.Items.Add("dbo.publicacionesNuevasEdiciones1");
            lstbxTablas.Items.Add("dbo.publicacionesNuevasEdiciones2");
        }       
        private void BtnAceptar_click(object sender, EventArgs e)
        {
            string tablaSeleccionada = lstbxTablas.SelectedItem.ToString();
            switch (tablaSeleccionada)
            {
                case "dbo.cartasNuevasEdiciones1":
                    ControllerDAO.LeerCartas(Stock.nuevasEdiciones_Cartas, tablaSeleccionada);   
                    break;
                case "dbo.cartasNuevasEdiciones2":
                    ControllerDAO.LeerCartas(Stock.nuevasEdiciones_Cartas, tablaSeleccionada);
                    break;
                case "dbo.publicacionesNuevasEdiciones1":
                    ControllerDAO.LeerPublicaciones(Stock.nuevasEdiciones_Publicaciones, tablaSeleccionada);
                    break;
                case "dbo.publicacionesNuevasEdiciones2":
                    ControllerDAO.LeerPublicaciones(Stock.nuevasEdiciones_Publicaciones, tablaSeleccionada);
                    break;
            }
            this.Close();
        }
    }
}
