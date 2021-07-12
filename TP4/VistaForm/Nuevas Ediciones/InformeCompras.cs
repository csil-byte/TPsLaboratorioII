using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VistaForm;
using Serializacion;
using Entidades;
using VistaForm.Nuevas_Ediciones;

namespace VistaConsola
{
    public partial class InformeCompras : Form
    {
        public static List<Publicacion> publicacionesInforme;
        public static List<Carta> cartasInforme;
        public InformeCompras()
        {
            InitializeComponent();
            publicacionesInforme = new List<Publicacion>();
            cartasInforme = new List<Carta>();
        }

        /// <summary>
        /// Instancia mis objetos al abrir el formulario                                   
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></paramj
        private void InformeCompras_Load(object sender, EventArgs e)
        {
            Stock_Dtgv<Publicacion, Carta, Barco> stock_Dtgv = new Stock_Dtgv<Publicacion, Carta, Barco>();

            Stock.RevisarIgualdad(Stock.nuevasEdiciones_Cartas, cartasInforme);
            Stock.RevisarIgualdad(Stock.nuevasEdiciones_Publicaciones, publicacionesInforme);

            stock_Dtgv.Add(dtgvInforme_publis, publicacionesInforme);
            stock_Dtgv.Add(dtgvInforme_cartas, cartasInforme);
        }
        /// <summary>
        /// Guardará en formato XML las nuevas ediciones obtenidas según los chequeos realizados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_guardarArchivo_Click(object sender, EventArgs e)
        {
            FrmInformeCompras_ElegirFormato formElegirFormato = new FrmInformeCompras_ElegirFormato();
            formElegirFormato.ShowDialog();
                
        }
        private void PicReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void PicExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir del programa?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }


        private void BtnCircularClientes_Click(object sender, EventArgs e)
        {
            Frm_CircularClientes Form2 = new Frm_CircularClientes();
            Form2.Show();
        }
    }
}
