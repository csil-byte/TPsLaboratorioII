using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using VistaForm;

namespace VistaConsola
{
    public partial class Frm_CircularClientes : Form
    {
        private List<Publicacion> publicaciones = new List<Publicacion>();
        private List<Carta> cartas = new List<Carta>();
        Stock_Dtgv<Publicacion, Carta, Barco> stock_Dtgv = new Stock_Dtgv<Publicacion, Carta, Barco>();
        public Frm_CircularClientes()
        {
            InitializeComponent();            
        }
        /// <summary>
        /// Al abrirse el formulario, se cargará el treeView con clientes y barcos, llamando al método CargarTreeView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_CircularClientes_Load(object sender, EventArgs e)
        {
            CargarTreeView();
        }
        /// <summary>
        /// Genera stringbuilder para el richtextbox
        /// </summary>
        /// <returns></returns>
        private string Cargar_RchTxtBox_Info()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("Nos comunicamos en esta ocasión para enviarles la circular de nuevas ediciones que según nuestra base de datos deberían actualizar para {0}", treeView1.SelectedNode.Text));
            sb.AppendLine(string.Format("En caso de requerir una cotización, favor volver con detalles."));

            return sb.ToString();
        }
        /// <summary>
        /// Itera sobre cada cliente y sus barcos para agregarlos como nodos al treeview.
        /// </summary>
        private void CargarTreeView ()
        {
            int i = 0;
            foreach (Clientes clientesito in Stock.Clientes)
            {
                treeView1.Nodes.Add(clientesito.Nombre);
                var node = treeView1.Nodes[i];

                foreach (Barco barquito in clientesito.barcos)
                {
                    node.Nodes.Add(barquito.NombreBarco);     
                }
                i++;
            }
        }       
       /// <summary>
       /// Este método permite cargar los datagrid según el barco elegido.
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void CheckedNode(object sender, TreeViewEventArgs e)
        {
            dtgv_cartas.DataSource = null;
            dtgv_publicaciones.DataSource = null;

            cartas.Clear();
            publicaciones.Clear();

            if (treeView1.SelectedNode.Level != 0)
            {
                txtBox_nombre.Text = treeView1.SelectedNode.Text;
                RevisarIgualdadBarcoSeleccionado();             ///////// acá rompe 
                rchTxtBox_info.Text = Cargar_RchTxtBox_Info();
                stock_Dtgv.Add(dtgv_publicaciones, publicaciones);
                stock_Dtgv.Add(dtgv_cartas, cartas);              
            }
            else
            {
                dtgv_cartas.DataSource = null;
                dtgv_publicaciones.DataSource = null;
                rchTxtBox_info.Text = string.Empty;
                txtBox_nombre.Text = "Seleccionar barco";
            }
        }
        /// <summary>
        /// Las listas de infomesCompras retornaran al sector de Compras la mercadería a renovar, las listas de circularClientes se encargaran de fijarse de esa mercadería cuales corresponden al barco seleccionado para poder así tener esa información en las listas de este formulario.
        /// </summary>
        private void RevisarIgualdadBarcoSeleccionado()
        {
            foreach (Clientes clientesito in Stock.Clientes)
            {
                foreach (Barco barquito in clientesito.barcos)
                {
                    if (treeView1.SelectedNode.Text == barquito.NombreBarco)
                    {
                        Stock.RevisarIgualdad(InformeCompras.publicacionesInforme, publicaciones);
                        Stock.RevisarIgualdad(InformeCompras.cartasInforme, cartas);
                    }
                }
            }
        }
        private void Pic_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir del programa?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void Pic_Return_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
