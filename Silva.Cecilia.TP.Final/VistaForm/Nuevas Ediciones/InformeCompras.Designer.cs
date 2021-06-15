
namespace VistaConsola
{
    partial class InformeCompras
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.dtgvInforme_publis = new System.Windows.Forms.DataGridView();
            this.dtgvInforme_cartas = new System.Windows.Forms.DataGridView();
            this.rdoPublicacion = new System.Windows.Forms.RadioButton();
            this.rdoCartas = new System.Windows.Forms.RadioButton();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.picReturn = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInforme_publis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInforme_cartas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_titulo.Location = new System.Drawing.Point(86, 11);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(527, 42);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Informe : Mercadería a renovar";
            // 
            // dtgvInforme_publis
            // 
            this.dtgvInforme_publis.AllowUserToAddRows = false;
            this.dtgvInforme_publis.AllowUserToDeleteRows = false;
            this.dtgvInforme_publis.AllowUserToResizeColumns = false;
            this.dtgvInforme_publis.AllowUserToResizeRows = false;
            this.dtgvInforme_publis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvInforme_publis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvInforme_publis.Location = new System.Drawing.Point(24, 68);
            this.dtgvInforme_publis.Name = "dtgvInforme_publis";
            this.dtgvInforme_publis.Size = new System.Drawing.Size(663, 190);
            this.dtgvInforme_publis.TabIndex = 1;
            // 
            // dtgvInforme_cartas
            // 
            this.dtgvInforme_cartas.AllowUserToAddRows = false;
            this.dtgvInforme_cartas.AllowUserToDeleteRows = false;
            this.dtgvInforme_cartas.AllowUserToResizeColumns = false;
            this.dtgvInforme_cartas.AllowUserToResizeRows = false;
            this.dtgvInforme_cartas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvInforme_cartas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvInforme_cartas.Location = new System.Drawing.Point(24, 283);
            this.dtgvInforme_cartas.Name = "dtgvInforme_cartas";
            this.dtgvInforme_cartas.Size = new System.Drawing.Size(663, 197);
            this.dtgvInforme_cartas.TabIndex = 4;
            // 
            // rdoPublicacion
            // 
            this.rdoPublicacion.AutoSize = true;
            this.rdoPublicacion.BackColor = System.Drawing.SystemColors.Control;
            this.rdoPublicacion.Checked = true;
            this.rdoPublicacion.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.rdoPublicacion.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.rdoPublicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPublicacion.Location = new System.Drawing.Point(8, 104);
            this.rdoPublicacion.Name = "rdoPublicacion";
            this.rdoPublicacion.Size = new System.Drawing.Size(118, 22);
            this.rdoPublicacion.TabIndex = 6;
            this.rdoPublicacion.TabStop = true;
            this.rdoPublicacion.Text = "Publicaciones";
            this.rdoPublicacion.UseVisualStyleBackColor = false;
            // 
            // rdoCartas
            // 
            this.rdoCartas.AutoSize = true;
            this.rdoCartas.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.rdoCartas.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.rdoCartas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCartas.Location = new System.Drawing.Point(8, 29);
            this.rdoCartas.Name = "rdoCartas";
            this.rdoCartas.Size = new System.Drawing.Size(70, 22);
            this.rdoCartas.TabIndex = 7;
            this.rdoCartas.Text = "Cartas";
            this.rdoCartas.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(1, 61);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox9);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox8);
            this.splitContainer1.Panel1.Controls.Add(this.picExit);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox4);
            this.splitContainer1.Panel1.Controls.Add(this.picReturn);
            this.splitContainer1.Panel1.Controls.Add(this.rdoPublicacion);
            this.splitContainer1.Panel1.Controls.Add(this.rdoCartas);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lbl_titulo);
            this.splitContainer1.Panel2.Controls.Add(this.dtgvInforme_cartas);
            this.splitContainer1.Panel2.Controls.Add(this.dtgvInforme_publis);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox6);
            this.splitContainer1.Size = new System.Drawing.Size(895, 499);
            this.splitContainer1.SplitterDistance = 193;
            this.splitContainer1.TabIndex = 8;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox9.Image = global::VistaForm.Properties.Resources._3102353_200;
            this.pictureBox9.Location = new System.Drawing.Point(8, 181);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(175, 50);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 15;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.btn_guardarArchivo_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox8.Image = global::VistaForm.Properties.Resources._2469455_200;
            this.pictureBox8.Location = new System.Drawing.Point(8, 125);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(175, 50);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 14;
            this.pictureBox8.TabStop = false;
            // 
            // picExit
            // 
            this.picExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picExit.Image = global::VistaForm.Properties.Resources.power_off_458936;
            this.picExit.Location = new System.Drawing.Point(8, 398);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(177, 49);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExit.TabIndex = 13;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Image = global::VistaForm.Properties.Resources.ship_3619166_960_720;
            this.pictureBox4.Location = new System.Drawing.Point(8, 51);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(175, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // picReturn
            // 
            this.picReturn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picReturn.Image = global::VistaForm.Properties.Resources._424_4245488_png_file_return_arrow_icon;
            this.picReturn.Location = new System.Drawing.Point(8, 283);
            this.picReturn.Name = "picReturn";
            this.picReturn.Size = new System.Drawing.Size(177, 50);
            this.picReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picReturn.TabIndex = 10;
            this.picReturn.TabStop = false;
            this.picReturn.Click += new System.EventHandler(this.picReturn_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::VistaForm.Properties.Resources.blue_2700749_1280;
            this.pictureBox6.Location = new System.Drawing.Point(-210, -14);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(920, 510);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VistaForm.Properties.Resources.MSLTD__2_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(895, 62);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // InformeCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 570);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "InformeCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InformeCompras";
            this.Load += new System.EventHandler(this.InformeCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInforme_publis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInforme_cartas)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.DataGridView dtgvInforme_publis;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dtgvInforme_cartas;
        private System.Windows.Forms.RadioButton rdoPublicacion;
        private System.Windows.Forms.RadioButton rdoCartas;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox picReturn;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}