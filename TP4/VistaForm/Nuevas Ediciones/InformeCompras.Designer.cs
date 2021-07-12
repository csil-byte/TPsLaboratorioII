
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.dtgvInforme_publis = new System.Windows.Forms.DataGridView();
            this.dtgvInforme_cartas = new System.Windows.Forms.DataGridView();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCartas_abrirArchivo = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.picReturn = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInforme_publis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInforme_cartas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.SystemColors.WindowText;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_titulo.Location = new System.Drawing.Point(68, 22);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(527, 33);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Mercadería a renovar : Sector Compras";
            // 
            // dtgvInforme_publis
            // 
            this.dtgvInforme_publis.AllowUserToAddRows = false;
            this.dtgvInforme_publis.AllowUserToDeleteRows = false;
            this.dtgvInforme_publis.AllowUserToResizeColumns = false;
            this.dtgvInforme_publis.AllowUserToResizeRows = false;
            this.dtgvInforme_publis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgvInforme_publis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvInforme_publis.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvInforme_publis.Location = new System.Drawing.Point(17, 68);
            this.dtgvInforme_publis.Name = "dtgvInforme_publis";
            this.dtgvInforme_publis.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvInforme_publis.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvInforme_publis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvInforme_publis.Size = new System.Drawing.Size(646, 190);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvInforme_cartas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvInforme_cartas.Location = new System.Drawing.Point(17, 282);
            this.dtgvInforme_cartas.Name = "dtgvInforme_cartas";
            this.dtgvInforme_cartas.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dtgvInforme_cartas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvInforme_cartas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvInforme_cartas.Size = new System.Drawing.Size(646, 197);
            this.dtgvInforme_cartas.TabIndex = 4;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(1, 47);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.WindowText;
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox3);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.btnCartas_abrirArchivo);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox9);
            this.splitContainer1.Panel1.Controls.Add(this.picExit);
            this.splitContainer1.Panel1.Controls.Add(this.picReturn);
            this.splitContainer1.Panel1.ForeColor = System.Drawing.SystemColors.Desktop;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.WindowText;
            this.splitContainer1.Panel2.Controls.Add(this.dtgvInforme_publis);
            this.splitContainer1.Panel2.Controls.Add(this.dtgvInforme_cartas);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_titulo);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox2);
            this.splitContainer1.Size = new System.Drawing.Size(919, 513);
            this.splitContainer1.SplitterDistance = 209;
            this.splitContainer1.TabIndex = 8;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::VistaForm.Properties.Resources.circular_cliente;
            this.pictureBox3.Location = new System.Drawing.Point(7, 204);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(178, 51);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.BtnCircularClientes_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(8, 177);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 26);
            this.button3.TabIndex = 19;
            this.button3.Text = "Circular Clientes";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.BtnCircularClientes_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(8, 412);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 26);
            this.button2.TabIndex = 18;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.PicExit_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(9, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 26);
            this.button1.TabIndex = 17;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.PicReturn_Click);
            // 
            // btnCartas_abrirArchivo
            // 
            this.btnCartas_abrirArchivo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCartas_abrirArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCartas_abrirArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCartas_abrirArchivo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCartas_abrirArchivo.Location = new System.Drawing.Point(9, 47);
            this.btnCartas_abrirArchivo.Name = "btnCartas_abrirArchivo";
            this.btnCartas_abrirArchivo.Size = new System.Drawing.Size(178, 26);
            this.btnCartas_abrirArchivo.TabIndex = 16;
            this.btnCartas_abrirArchivo.Text = "Guardar";
            this.btnCartas_abrirArchivo.UseVisualStyleBackColor = true;
            this.btnCartas_abrirArchivo.Click += new System.EventHandler(this.Btn_guardarArchivo_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox9.Image = global::VistaForm.Properties.Resources.save_image_icon_17;
            this.pictureBox9.Location = new System.Drawing.Point(10, 74);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(177, 51);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 15;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.Btn_guardarArchivo_Click);
            // 
            // picExit
            // 
            this.picExit.BackColor = System.Drawing.SystemColors.Control;
            this.picExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picExit.Image = global::VistaForm.Properties.Resources.power_off_458936;
            this.picExit.Location = new System.Drawing.Point(8, 438);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(177, 44);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picExit.TabIndex = 13;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.PicExit_Click);
            // 
            // picReturn
            // 
            this.picReturn.BackColor = System.Drawing.SystemColors.Control;
            this.picReturn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picReturn.Image = global::VistaForm.Properties.Resources._424_4245488_png_file_return_arrow_icon;
            this.picReturn.Location = new System.Drawing.Point(8, 323);
            this.picReturn.Name = "picReturn";
            this.picReturn.Size = new System.Drawing.Size(177, 47);
            this.picReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picReturn.TabIndex = 10;
            this.picReturn.TabStop = false;
            this.picReturn.Click += new System.EventHandler(this.PicReturn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::VistaForm.Properties.Resources._603_6036837_hero_overlay_green_and_blue_swirl_png_clipart;
            this.pictureBox2.Location = new System.Drawing.Point(-216, -9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(916, 535);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VistaForm.Properties.Resources.MSLTD__2_;
            this.pictureBox1.Location = new System.Drawing.Point(-55, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1022, 62);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // InformeCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(901, 570);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.splitContainer1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "InformeCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InformeCompras";
            this.Load += new System.EventHandler(this.InformeCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInforme_publis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInforme_cartas)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.DataGridView dtgvInforme_publis;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dtgvInforme_cartas;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox picReturn;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCartas_abrirArchivo;
    }
}