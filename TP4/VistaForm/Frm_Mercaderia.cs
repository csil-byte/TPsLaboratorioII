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
using VistaConsola;
using VistaForm;


namespace VistaForm
{
    public partial class Frm_Mercaderia : Form
    {
        //private static string rutaPub = AppDomain.CurrentDomain.BaseDirectory + "listaPublicacionesStock";
        //private static string rutaCartas = AppDomain.CurrentDomain.BaseDirectory + "listaCartasStock";

        public Stock stock;
        public Frm_Mercaderia()
        {
            InitializeComponent();        
        }      
        private void Btn_Stock_Click(object sender, EventArgs e)
        {
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
        private void Form_Mercaderia_Load(object sender, EventArgs e)
        {
            stock = Stock.GetStock();
            ControllerDAO.LeerBarcos(Stock.Barcos);
            ControllerDAO.LeerCartas(Stock.Cartas);
            ControllerDAO.LeerClientes(Stock.Clientes);
            ControllerDAO.LeerPublicaciones(Stock.Publicaciones);
                                
            foreach (Carta cartita in Stock.Cartas)
            {
                listBox1.Items.Add(cartita.Titulo);              
            }
            foreach (Publicacion publicacion in Stock.Publicaciones)
            {
                listBox2.Items.Add(publicacion.Titulo);
            }
            foreach (Clientes cliente in Stock.Clientes)
            {
                listBox3.Items.Add(cliente.Nombre);
            }
            foreach (Barco barco in Stock.Barcos)
            {
                listBox4.Items.Add(barco.NombreBarco);
            }

            Controller.ObtenerBarcosPorCadaCliente(Stock.Clientes, Stock.Barcos);
        }
        private void Btn_Actualizacion_Click(object sender, EventArgs e)
        {
            Frm_NuevasEdiciones frm_NuevasEdiciones = new Frm_NuevasEdiciones();
            frm_NuevasEdiciones.Show();
        }
    }
}
