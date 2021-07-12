using System;
using System.Threading;
using System.Windows.Forms;

namespace VistaForm
{

    public delegate void InvokeTextBox();

    public partial class FrmInicioPrograma : Form
    {

        private event InvokeTextBox InvokeText;
        private Thread t1;

        public FrmInicioPrograma()
        {
            InitializeComponent();
            this.InvokeText += TxtBoxCargar;
        }

        /// <summary>
        /// Iniciará un thread y lo empezará 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmInicioPrograma_Load(object sender, EventArgs e)
        {
            t1 = new Thread(TxtBoxCargar);
            timerLoading.Start();
            t1.Start();
        }

        /// <summary>
        /// Permitirá acceder al control txtBoxCarga
        /// </summary>
        /// <param name="value"></param>
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

        /// <summary>
        /// Cargará el textbox
        /// </summary>
        private void TxtBoxCargar()
        {
            try
            {
                InvocarTextBox("CARGANDO    LISTAS");
                Thread.Sleep(1000);
                InvocarTextBox("CARGANDO    CARTAS");
                Thread.Sleep(1000);
                InvocarTextBox("CARGANDO    BARQUITOS");
                Thread.Sleep(1000);
                InvocarTextBox("CARGANDO    EL MAR, LAS OLAS");
                Thread.Sleep(1000);
                InvocarTextBox("CARGANDO    Y EL VIENTO");
                Thread.Sleep(1000);
                InvocarTextBox("CARGANDO    SUCUNDUMSUCUNDUM");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// Irá aumentando el progressbar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerLoadingTick(object sender, EventArgs e)
        {

            if (prbLoading.Value < 100)
            {
                prbLoading.Value += 1;
            }
            else
            {
                timerLoading.Stop();
                this.Close();
            }

        }

        /// <summary>
        /// Si el hilo está corriendo, lo termina
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmInicioPrograma_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.InvokeText -= TxtBoxCargar;
            if (t1.IsAlive)
            {
                t1.Abort();
            }
        }
    }
}
 