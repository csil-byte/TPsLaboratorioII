
namespace VistaForm
{
    partial class Frm_NuevasEdiciones
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPublicaciones_abrirArchivo = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.publicaciones_dtgvFNE = new System.Windows.Forms.DataGridView();
            this.btn_generarInforme = new System.Windows.Forms.Button();
            this.btn_circularClientes = new System.Windows.Forms.Button();
            this.cartas_dtgvFNE = new System.Windows.Forms.DataGridView();
            this.btnCartas_abrirArchivo = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.picBxBackground_nuevasEdiciones = new System.Windows.Forms.PictureBox();
            this.picBxHeader_nuevasEdiciones = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.publicaciones_dtgvFNE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartas_dtgvFNE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxBackground_nuevasEdiciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxHeader_nuevasEdiciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPublicaciones_abrirArchivo
            // 
            this.btnPublicaciones_abrirArchivo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPublicaciones_abrirArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPublicaciones_abrirArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublicaciones_abrirArchivo.Location = new System.Drawing.Point(6, 119);
            this.btnPublicaciones_abrirArchivo.Name = "btnPublicaciones_abrirArchivo";
            this.btnPublicaciones_abrirArchivo.Size = new System.Drawing.Size(167, 36);
            this.btnPublicaciones_abrirArchivo.TabIndex = 1;
            this.btnPublicaciones_abrirArchivo.Text = "Abrir archivo : Publicaciones";
            this.btnPublicaciones_abrirArchivo.UseVisualStyleBackColor = true;
            this.btnPublicaciones_abrirArchivo.Click += new System.EventHandler(this.OpenFile_btnEventPublicaciones);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // publicaciones_dtgvFNE
            // 
            this.publicaciones_dtgvFNE.AllowUserToAddRows = false;
            this.publicaciones_dtgvFNE.AllowUserToDeleteRows = false;
            this.publicaciones_dtgvFNE.AllowUserToResizeColumns = false;
            this.publicaciones_dtgvFNE.AllowUserToResizeRows = false;
            this.publicaciones_dtgvFNE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.publicaciones_dtgvFNE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.publicaciones_dtgvFNE.Location = new System.Drawing.Point(13, 17);
            this.publicaciones_dtgvFNE.Name = "publicaciones_dtgvFNE";
            this.publicaciones_dtgvFNE.Size = new System.Drawing.Size(579, 170);
            this.publicaciones_dtgvFNE.TabIndex = 3;
            // 
            // btn_generarInforme
            // 
            this.btn_generarInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generarInforme.Location = new System.Drawing.Point(13, 393);
            this.btn_generarInforme.Name = "btn_generarInforme";
            this.btn_generarInforme.Size = new System.Drawing.Size(231, 46);
            this.btn_generarInforme.TabIndex = 4;
            this.btn_generarInforme.Text = "Generar Informe";
            this.btn_generarInforme.UseVisualStyleBackColor = true;
            this.btn_generarInforme.Click += new System.EventHandler(this.btn_generarInforme_Click);
            // 
            // btn_circularClientes
            // 
            this.btn_circularClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_circularClientes.Location = new System.Drawing.Point(361, 393);
            this.btn_circularClientes.Name = "btn_circularClientes";
            this.btn_circularClientes.Size = new System.Drawing.Size(231, 46);
            this.btn_circularClientes.TabIndex = 5;
            this.btn_circularClientes.Text = "Circular Clientes";
            this.btn_circularClientes.UseVisualStyleBackColor = true;
            this.btn_circularClientes.Click += new System.EventHandler(this.btn_circularClientes_Click);
            // 
            // cartas_dtgvFNE
            // 
            this.cartas_dtgvFNE.AllowUserToAddRows = false;
            this.cartas_dtgvFNE.AllowUserToDeleteRows = false;
            this.cartas_dtgvFNE.AllowUserToResizeColumns = false;
            this.cartas_dtgvFNE.AllowUserToResizeRows = false;
            this.cartas_dtgvFNE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.cartas_dtgvFNE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartas_dtgvFNE.Location = new System.Drawing.Point(13, 207);
            this.cartas_dtgvFNE.Name = "cartas_dtgvFNE";
            this.cartas_dtgvFNE.Size = new System.Drawing.Size(579, 166);
            this.cartas_dtgvFNE.TabIndex = 8;
            // 
            // btnCartas_abrirArchivo
            // 
            this.btnCartas_abrirArchivo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCartas_abrirArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCartas_abrirArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCartas_abrirArchivo.Location = new System.Drawing.Point(6, 245);
            this.btnCartas_abrirArchivo.Name = "btnCartas_abrirArchivo";
            this.btnCartas_abrirArchivo.Size = new System.Drawing.Size(167, 34);
            this.btnCartas_abrirArchivo.TabIndex = 7;
            this.btnCartas_abrirArchivo.Text = "Abrir archivo: Cartas";
            this.btnCartas_abrirArchivo.UseVisualStyleBackColor = true;
            this.btnCartas_abrirArchivo.Click += new System.EventHandler(this.OpenFile_btnEventCartas);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(-1, 58);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnPublicaciones_abrirArchivo);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox5);
            this.splitContainer1.Panel1.Controls.Add(this.btnCartas_abrirArchivo);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox4);
            this.splitContainer1.Panel1.Controls.Add(this.picExit);
            this.splitContainer1.Panel1.Controls.Add(this.picHome);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btn_generarInforme);
            this.splitContainer1.Panel2.Controls.Add(this.btn_circularClientes);
            this.splitContainer1.Panel2.Controls.Add(this.cartas_dtgvFNE);
            this.splitContainer1.Panel2.Controls.Add(this.publicaciones_dtgvFNE);
            this.splitContainer1.Panel2.Controls.Add(this.picBxBackground_nuevasEdiciones);
            this.splitContainer1.Size = new System.Drawing.Size(789, 458);
            this.splitContainer1.SplitterDistance = 181;
            this.splitContainer1.TabIndex = 10;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Image = global::VistaForm.Properties.Resources.ship_3619166_960_720;
            this.pictureBox5.Location = new System.Drawing.Point(6, 276);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(167, 47);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Image = global::VistaForm.Properties.Resources._2469455_200;
            this.pictureBox4.Location = new System.Drawing.Point(6, 152);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(167, 47);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // picExit
            // 
            this.picExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picExit.Image = global::VistaForm.Properties.Resources.power_off_458936;
            this.picExit.Location = new System.Drawing.Point(6, 379);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(167, 46);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExit.TabIndex = 16;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // picHome
            // 
            this.picHome.BackColor = System.Drawing.SystemColors.Control;
            this.picHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHome.Image = global::VistaForm.Properties.Resources._1200px_Home_Icon_svg;
            this.picHome.Location = new System.Drawing.Point(6, 17);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(167, 47);
            this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHome.TabIndex = 16;
            this.picHome.TabStop = false;
            this.picHome.Click += new System.EventHandler(this.picHome_Clic);
            // 
            // picBxBackground_nuevasEdiciones
            // 
            this.picBxBackground_nuevasEdiciones.Image = global::VistaForm.Properties.Resources.blue_2700749_1280;
            this.picBxBackground_nuevasEdiciones.Location = new System.Drawing.Point(-175, -72);
            this.picBxBackground_nuevasEdiciones.Name = "picBxBackground_nuevasEdiciones";
            this.picBxBackground_nuevasEdiciones.Size = new System.Drawing.Size(829, 610);
            this.picBxBackground_nuevasEdiciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBxBackground_nuevasEdiciones.TabIndex = 9;
            this.picBxBackground_nuevasEdiciones.TabStop = false;
            // 
            // picBxHeader_nuevasEdiciones
            // 
            this.picBxHeader_nuevasEdiciones.Image = global::VistaForm.Properties.Resources.MSLTD__2_;
            this.picBxHeader_nuevasEdiciones.Location = new System.Drawing.Point(-1, 0);
            this.picBxHeader_nuevasEdiciones.Name = "picBxHeader_nuevasEdiciones";
            this.picBxHeader_nuevasEdiciones.Size = new System.Drawing.Size(789, 60);
            this.picBxHeader_nuevasEdiciones.TabIndex = 6;
            this.picBxHeader_nuevasEdiciones.TabStop = false;
            // 
            // Frm_NuevasEdiciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 511);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.picBxHeader_nuevasEdiciones);
            this.Name = "Frm_NuevasEdiciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevas Ediciones";
            this.Load += new System.EventHandler(this.Frm_NuevasEdiciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.publicaciones_dtgvFNE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartas_dtgvFNE)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxBackground_nuevasEdiciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxHeader_nuevasEdiciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPublicaciones_abrirArchivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView publicaciones_dtgvFNE;
        private System.Windows.Forms.Button btn_generarInforme;
        private System.Windows.Forms.Button btn_circularClientes;
        private System.Windows.Forms.PictureBox picBxHeader_nuevasEdiciones;
        private System.Windows.Forms.DataGridView cartas_dtgvFNE;
        private System.Windows.Forms.Button btnCartas_abrirArchivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.PictureBox picBxBackground_nuevasEdiciones;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox picExit;
    }
}

