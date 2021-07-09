using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaForm
{
    public partial class FrmInicioPrograma : Form
    {
        public FrmInicioPrograma()
        {
            InitializeComponent();
            Application.EnableVisualStyles();
        }

        private void FrmInicioPrograma_Load(object sender, EventArgs e)
        {
            Thread t1 = new Thread(TxtBoxCargar);
            timerLoading.Start();
            t1.Start();          
        }
        public void InvocarTextBox(string value)
        {

            if (InvokeRequired)
            {
                this.BeginInvoke(new Action<string>(InvocarTextBox), new object[] { value });
                return;
            }

            txtboxCarga.Text = string.Empty;
            txtboxCarga.Text += value;
            
        }
        private void TxtBoxCargar()
        {
            try
            {
                InvocarTextBox("CARGANDO    LISTAS");
                Thread.Sleep(500);
                InvocarTextBox("CARGANDO    CARTAS");
                Thread.Sleep(500);
                InvocarTextBox("CARGANDO    BARQUITOS");
                Thread.Sleep(500);
                InvocarTextBox("CARGANDO    EL MAR, LAS OLAS");
                Thread.Sleep(450);
                InvocarTextBox("CARGANDO    Y EL VIENTO SUCUNDUMSUCUNDUM");               
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void TimerLoadingTick(object sender, EventArgs e)
        {

                if (prbLoading.Value < 100)
                {
                    prbLoading.Value += 1;
                }
                else
                {
                    timerLoading.Stop();
                    Frm_Mercaderia frmMercaderia = new Frm_Mercaderia();
                    this.Hide();
                    frmMercaderia.ShowDialog();
                    
                }

        }
    }
}
