
namespace VistaForm
{
    partial class Frm_Mercaderia
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
            this.btn_Actualizacion = new System.Windows.Forms.Button();
            this.btn_Stock = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Actualizacion
            // 
            this.btn_Actualizacion.BackColor = System.Drawing.Color.Black;
            this.btn_Actualizacion.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Actualizacion.ForeColor = System.Drawing.Color.White;
            this.btn_Actualizacion.Location = new System.Drawing.Point(12, 82);
            this.btn_Actualizacion.Name = "btn_Actualizacion";
            this.btn_Actualizacion.Size = new System.Drawing.Size(226, 66);
            this.btn_Actualizacion.TabIndex = 0;
            this.btn_Actualizacion.Text = "Actualización";
            this.btn_Actualizacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Actualizacion.UseVisualStyleBackColor = false;
            this.btn_Actualizacion.Click += new System.EventHandler(this.Btn_Actualizacion_Click);
            // 
            // btn_Stock
            // 
            this.btn_Stock.BackColor = System.Drawing.Color.Black;
            this.btn_Stock.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stock.ForeColor = System.Drawing.Color.White;
            this.btn_Stock.Location = new System.Drawing.Point(261, 82);
            this.btn_Stock.Name = "btn_Stock";
            this.btn_Stock.Size = new System.Drawing.Size(188, 66);
            this.btn_Stock.TabIndex = 1;
            this.btn_Stock.Text = "Stock";
            this.btn_Stock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Stock.UseVisualStyleBackColor = false;
            this.btn_Stock.Click += new System.EventHandler(this.Btn_Stock_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(461, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VistaForm.Properties.Resources.MSLTD__2_;
            this.pictureBox1.Location = new System.Drawing.Point(-17, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(478, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::VistaForm.Properties.Resources._603_6036837_hero_overlay_green_and_blue_swirl_png_clipart;
            this.pictureBox2.Location = new System.Drawing.Point(0, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(461, 141);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // Frm_Mercaderia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(461, 189);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Stock);
            this.Controls.Add(this.btn_Actualizacion);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Mercaderia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mercadería";
            this.Load += new System.EventHandler(this.Form_Mercaderia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Actualizacion;
        private System.Windows.Forms.Button btn_Stock;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}