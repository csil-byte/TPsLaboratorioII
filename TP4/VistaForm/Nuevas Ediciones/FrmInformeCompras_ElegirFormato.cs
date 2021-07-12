using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Entidades;
using Serializacion;
using VistaConsola;

namespace VistaForm.Nuevas_Ediciones {
    public partial class FrmInformeCompras_ElegirFormato : Form {

        private const string FILTROTXT = "txt files(*.txt)|*.txt";
        private const string FILTROXML = "xml files(*.xml)|*.xml";
        private const string FILTROPDF = "pdf files(*.pdf)|*.pdf";

        public FrmInformeCompras_ElegirFormato() {
            InitializeComponent();
        }

        /// <summary>
        /// Si alguno de los radio button está chequeado, llamará al método correspondiente.
        /// Si ninguno está abierto, le avisará al usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAceptar_Click(object sender, EventArgs e) {
            if (rdoXml.Checked || rdoTxt.Checked || rdoPdf.Checked) {
                if (rdoPublicacion.Checked) {
                    SeleccionarFormatoPublicaciones();
                } else {
                    SeleccionarFormatoCartas();
                }
            } else {
                MessageBox.Show("Favor seleccionar un formato para guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Verifica cual formato está chequeado y guardará una lista de publicaciones según lo chequeado.
        /// </summary>
        public void SeleccionarFormatoPublicaciones() {
            if (rdoXml.Checked) {
                saveFileDialog.Filter = FILTROXML;
                SerializadoraXml<List<Publicacion>> serializadoraPub = new SerializadoraXml<List<Publicacion>>();
                if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName != "") {
                    serializadoraPub.Guardar(saveFileDialog.FileName, InformeCompras.publicacionesInforme);
                }
            } else if (rdoTxt.Checked) {
                saveFileDialog.Filter = FILTROTXT;
                SerializadoraTxt<Publicacion> serializadoraTexto = new SerializadoraTxt<Publicacion>();
                if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName != "") {
                    serializadoraTexto.Guardar(saveFileDialog.FileName, InformeCompras.publicacionesInforme);
                }
            } else {
                saveFileDialog.Filter = FILTROPDF;
                Pdf<Publicacion> pdf = new Pdf<Publicacion>();
                if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName != "") {
                    pdf.CrearPdf(saveFileDialog.FileName, InformeCompras.publicacionesInforme);
                }
            }
        }

        /// <summary>
        /// Verifica cual formato está chequeado y guardará una lista de cartas según lo chequeado.
        /// </summary>
        public void SeleccionarFormatoCartas() {
            if (rdoXml.Checked) {
                saveFileDialog.Filter = FILTROXML;
                SerializadoraXml<List<Carta>> serializadoraCarta = new SerializadoraXml<List<Carta>>();
                if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName != "") {
                    serializadoraCarta.Guardar(saveFileDialog.FileName, InformeCompras.cartasInforme);
                }
            } else if (rdoTxt.Checked) {
                saveFileDialog.Filter = FILTROTXT;
                SerializadoraTxt<Carta> serializadoraTexto = new SerializadoraTxt<Carta>();
                if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName != "") {
                    serializadoraTexto.Guardar(saveFileDialog.FileName, InformeCompras.cartasInforme);
                }
            } else {
                saveFileDialog.Filter = FILTROPDF;
                Pdf<Carta> pdf = new Pdf<Carta>();
                if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.FileName != "") {
                    pdf.CrearPdf(saveFileDialog.FileName, InformeCompras.cartasInforme);
                }
            }
        }
    }
}
