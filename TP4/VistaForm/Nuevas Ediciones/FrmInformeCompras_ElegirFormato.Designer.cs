
namespace VistaForm.Nuevas_Ediciones
{
    partial class FrmInformeCompras_ElegirFormato
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.rdoPublicacion = new System.Windows.Forms.RadioButton();
            this.rdoCartas = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.rdoXml = new System.Windows.Forms.RadioButton();
            this.rdoTxt = new System.Windows.Forms.RadioButton();
            this.rdoPdf = new System.Windows.Forms.RadioButton();
            this.picPdf = new System.Windows.Forms.PictureBox();
            this.picTxt = new System.Windows.Forms.PictureBox();
            this.picXml = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picFondo = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPdf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picXml)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.MenuText;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(27, 274);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(381, 35);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // rdoPublicacion
            // 
            this.rdoPublicacion.AutoSize = true;
            this.rdoPublicacion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdoPublicacion.Checked = true;
            this.rdoPublicacion.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.rdoPublicacion.FlatAppearance.BorderSize = 5;
            this.rdoPublicacion.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.rdoPublicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPublicacion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdoPublicacion.Location = new System.Drawing.Point(206, 16);
            this.rdoPublicacion.Name = "rdoPublicacion";
            this.rdoPublicacion.Size = new System.Drawing.Size(164, 29);
            this.rdoPublicacion.TabIndex = 8;
            this.rdoPublicacion.TabStop = true;
            this.rdoPublicacion.Text = "Publicaciones";
            this.rdoPublicacion.UseVisualStyleBackColor = false;
            // 
            // rdoCartas
            // 
            this.rdoCartas.AutoSize = true;
            this.rdoCartas.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdoCartas.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.rdoCartas.FlatAppearance.BorderSize = 5;
            this.rdoCartas.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.rdoCartas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCartas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rdoCartas.Location = new System.Drawing.Point(10, 15);
            this.rdoCartas.Name = "rdoCartas";
            this.rdoCartas.Size = new System.Drawing.Size(93, 29);
            this.rdoCartas.TabIndex = 9;
            this.rdoCartas.Text = "Cartas";
            this.rdoCartas.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoCartas);
            this.groupBox1.Controls.Add(this.rdoPublicacion);
            this.groupBox1.Location = new System.Drawing.Point(27, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 52);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rdoXml
            // 
            this.rdoXml.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoXml.ForeColor = System.Drawing.Color.White;
            this.rdoXml.Location = new System.Drawing.Point(27, 126);
            this.rdoXml.Name = "rdoXml";
            this.rdoXml.Size = new System.Drawing.Size(119, 24);
            this.rdoXml.TabIndex = 12;
            this.rdoXml.TabStop = true;
            this.rdoXml.Text = "XML";
            this.rdoXml.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoXml.UseVisualStyleBackColor = true;
            // 
            // rdoTxt
            // 
            this.rdoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTxt.ForeColor = System.Drawing.Color.White;
            this.rdoTxt.Location = new System.Drawing.Point(158, 126);
            this.rdoTxt.Name = "rdoTxt";
            this.rdoTxt.Size = new System.Drawing.Size(119, 24);
            this.rdoTxt.TabIndex = 13;
            this.rdoTxt.TabStop = true;
            this.rdoTxt.Text = "Texto";
            this.rdoTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoTxt.UseVisualStyleBackColor = true;
            // 
            // rdoPdf
            // 
            this.rdoPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPdf.ForeColor = System.Drawing.Color.White;
            this.rdoPdf.Location = new System.Drawing.Point(292, 126);
            this.rdoPdf.Name = "rdoPdf";
            this.rdoPdf.Size = new System.Drawing.Size(119, 24);
            this.rdoPdf.TabIndex = 14;
            this.rdoPdf.TabStop = true;
            this.rdoPdf.Text = "PDF";
            this.rdoPdf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoPdf.UseVisualStyleBackColor = true;
            // 
            // picPdf
            // 
            this.picPdf.BackColor = System.Drawing.Color.White;
            this.picPdf.Image = global::VistaForm.Properties.Resources.pdf;
            this.picPdf.Location = new System.Drawing.Point(292, 156);
            this.picPdf.Name = "picPdf";
            this.picPdf.Size = new System.Drawing.Size(116, 96);
            this.picPdf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPdf.TabIndex = 4;
            this.picPdf.TabStop = false;
            // 
            // picTxt
            // 
            this.picTxt.BackColor = System.Drawing.Color.White;
            this.picTxt.Image = global::VistaForm.Properties.Resources.txt;
            this.picTxt.Location = new System.Drawing.Point(158, 156);
            this.picTxt.Name = "picTxt";
            this.picTxt.Size = new System.Drawing.Size(116, 96);
            this.picTxt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTxt.TabIndex = 3;
            this.picTxt.TabStop = false;
            // 
            // picXml
            // 
            this.picXml.BackColor = System.Drawing.Color.White;
            this.picXml.Image = global::VistaForm.Properties.Resources.xml;
            this.picXml.Location = new System.Drawing.Point(27, 156);
            this.picXml.Name = "picXml";
            this.picXml.Size = new System.Drawing.Size(116, 96);
            this.picXml.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picXml.TabIndex = 2;
            this.picXml.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VistaForm.Properties.Resources.MSLTD__2_;
            this.pictureBox1.Location = new System.Drawing.Point(-23, -10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(601, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // picFondo
            // 
            this.picFondo.Image = global::VistaForm.Properties.Resources._603_6036837_hero_overlay_green_and_blue_swirl_png_clipart;
            this.picFondo.Location = new System.Drawing.Point(-79, 40);
            this.picFondo.Name = "picFondo";
            this.picFondo.Size = new System.Drawing.Size(525, 292);
            this.picFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFondo.TabIndex = 11;
            this.picFondo.TabStop = false;
            // 
            // FrmInformeCompras_ElegirFormato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(441, 330);
            this.Controls.Add(this.rdoPdf);
            this.Controls.Add(this.rdoTxt);
            this.Controls.Add(this.rdoXml);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.picPdf);
            this.Controls.Add(this.picTxt);
            this.Controls.Add(this.picXml);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picFondo);
            this.Name = "FrmInformeCompras_ElegirFormato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elegir formato";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPdf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picXml)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picXml;
        private System.Windows.Forms.PictureBox picTxt;
        private System.Windows.Forms.PictureBox picPdf;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.RadioButton rdoPublicacion;
        private System.Windows.Forms.RadioButton rdoCartas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.PictureBox picFondo;
        private System.Windows.Forms.RadioButton rdoXml;
        private System.Windows.Forms.RadioButton rdoTxt;
        private System.Windows.Forms.RadioButton rdoPdf;
    }
}