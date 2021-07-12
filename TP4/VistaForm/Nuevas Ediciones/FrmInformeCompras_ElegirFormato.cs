using Entidades;
using Serializacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VistaConsola;

namespace VistaForm.Nuevas_Ediciones
{
    public partial class FrmInformeCompras_ElegirFormato : Form
    {
        public FrmInformeCompras_ElegirFormato()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (rdoXml.Checked || rdoTxt.Checked || rdoPdf.Checked)
            {
                if (rdoPublicacion.Checked)
                {
                    SeleccionarFormatoPublicaciones();
                }
                else
                {
                    SeleccionarFormatoCartas();
                }
            }
            else
            {
                MessageBox.Show("Favor seleccionar un formato para guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void SeleccionarFormatoPublicaciones()
        {
            if (rdoXml.Checked)
            {
                SerializadoraXml<List<Publicacion>> serializadoraPub = new SerializadoraXml<List<Publicacion>>();
                if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName != "")
                {
                    serializadoraPub.Guardar(saveFileDialog.FileName, InformeCompras.publicacionesInforme);
                }
            }
            else if (rdoTxt.Checked)
            {
                SerializadoraTxt<Publicacion> serializadoraTexto = new SerializadoraTxt<Publicacion>();
                if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName != "")
                {
                    serializadoraTexto.Guardar(saveFileDialog.FileName, InformeCompras.publicacionesInforme);
                }
            else
            {
                    Pdf<Publicacion> pdf = new Pdf<Publicacion>();
                    if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName != "")
                    {
                        pdf.CrearPdf(saveFileDialog.FileName, InformeCompras.publicacionesInforme);
                    }
                }              
            }
        }

        public void SeleccionarFormatoCartas()
        {
            if (rdoXml.Checked)
            {
                SerializadoraXml<List<Carta>> serializadoraCarta = new SerializadoraXml<List<Carta>>();
                if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName != "")
                {
                    serializadoraCarta.Guardar(saveFileDialog.FileName, InformeCompras.cartasInforme);
                }
            }
            else if (rdoTxt.Checked)
            {
                SerializadoraTxt<Carta> serializadoraTexto = new SerializadoraTxt<Carta>();
                if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName != "")
                {
                    serializadoraTexto.Guardar(saveFileDialog.FileName, InformeCompras.cartasInforme);
                }
            }
            else 
            {
                Pdf<Carta> pdf = new Pdf<Carta>();
                if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName != "")
                {
                    pdf.CrearPdf(saveFileDialog.FileName, InformeCompras.cartasInforme);
                }
            }
           
                   
        }
    }
}
