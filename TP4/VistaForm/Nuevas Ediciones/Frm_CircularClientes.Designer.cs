
namespace VistaConsola
{
    partial class Frm_CircularClientes
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
            this.txtBox_nombre = new System.Windows.Forms.TextBox();
            this.rchTxtBox_info = new System.Windows.Forms.RichTextBox();
            this.dtgv_publicaciones = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.pic_Return = new System.Windows.Forms.PictureBox();
            this.pic_Exit = new System.Windows.Forms.PictureBox();
            this.dtgv_cartas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_publicaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Return)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_cartas)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBox_nombre
            // 
            this.txtBox_nombre.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtBox_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_nombre.Enabled = false;
            this.txtBox_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_nombre.ForeColor = System.Drawing.SystemColors.Window;
            this.txtBox_nombre.Location = new System.Drawing.Point(218, 70);
            this.txtBox_nombre.Name = "txtBox_nombre";
            this.txtBox_nombre.Size = new System.Drawing.Size(570, 40);
            this.txtBox_nombre.TabIndex = 0;
            this.txtBox_nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rchTxtBox_info
            // 
            this.rchTxtBox_info.BackColor = System.Drawing.SystemColors.WindowText;
            this.rchTxtBox_info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rchTxtBox_info.Enabled = false;
            this.rchTxtBox_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchTxtBox_info.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rchTxtBox_info.Location = new System.Drawing.Point(218, 121);
            this.rchTxtBox_info.Name = "rchTxtBox_info";
            this.rchTxtBox_info.Size = new System.Drawing.Size(570, 101);
            this.rchTxtBox_info.TabIndex = 1;
            this.rchTxtBox_info.Text = "";
            // 
            // dtgv_publicaciones
            // 
            this.dtgv_publicaciones.AllowUserToAddRows = false;
            this.dtgv_publicaciones.AllowUserToDeleteRows = false;
            this.dtgv_publicaciones.AllowUserToResizeColumns = false;
            this.dtgv_publicaciones.AllowUserToResizeRows = false;
            this.dtgv_publicaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgv_publicaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_publicaciones.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv_publicaciones.Location = new System.Drawing.Point(218, 228);
            this.dtgv_publicaciones.Name = "dtgv_publicaciones";
            this.dtgv_publicaciones.ReadOnly = true;
            this.dtgv_publicaciones.Size = new System.Drawing.Size(570, 132);
            this.dtgv_publicaciones.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VistaForm.Properties.Resources.MSLTD__2_;
            this.pictureBox1.Location = new System.Drawing.Point(-66, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(864, 64);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // treeView1
            // 
            this.treeView1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.treeView1.BackColor = System.Drawing.SystemColors.InfoText;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ForeColor = System.Drawing.SystemColors.Window;
            this.treeView1.ItemHeight = 22;
            this.treeView1.LineColor = System.Drawing.Color.White;
            this.treeView1.Location = new System.Drawing.Point(3, 175);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(209, 338);
            this.treeView1.TabIndex = 4;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.CheckedNode);
            // 
            // pic_Return
            // 
            this.pic_Return.BackColor = System.Drawing.SystemColors.Window;
            this.pic_Return.Image = global::VistaForm.Properties.Resources._424_4245488_png_file_return_arrow_icon;
            this.pic_Return.Location = new System.Drawing.Point(3, 70);
            this.pic_Return.Name = "pic_Return";
            this.pic_Return.Size = new System.Drawing.Size(209, 47);
            this.pic_Return.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Return.TabIndex = 14;
            this.pic_Return.TabStop = false;
            this.pic_Return.Click += new System.EventHandler(this.Pic_Return_Click);
            // 
            // pic_Exit
            // 
            this.pic_Exit.BackColor = System.Drawing.SystemColors.Window;
            this.pic_Exit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_Exit.Image = global::VistaForm.Properties.Resources.power_off_458936;
            this.pic_Exit.Location = new System.Drawing.Point(3, 123);
            this.pic_Exit.Name = "pic_Exit";
            this.pic_Exit.Size = new System.Drawing.Size(209, 46);
            this.pic_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Exit.TabIndex = 14;
            this.pic_Exit.TabStop = false;
            this.pic_Exit.Click += new System.EventHandler(this.Pic_Exit_Click);
            // 
            // dtgv_cartas
            // 
            this.dtgv_cartas.AllowUserToAddRows = false;
            this.dtgv_cartas.AllowUserToDeleteRows = false;
            this.dtgv_cartas.AllowUserToResizeColumns = false;
            this.dtgv_cartas.AllowUserToResizeRows = false;
            this.dtgv_cartas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgv_cartas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_cartas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv_cartas.Location = new System.Drawing.Point(218, 366);
            this.dtgv_cartas.Name = "dtgv_cartas";
            this.dtgv_cartas.ReadOnly = true;
            this.dtgv_cartas.Size = new System.Drawing.Size(570, 147);
            this.dtgv_cartas.TabIndex = 15;
            // 
            // Frm_CircularClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(788, 515);
            this.Controls.Add(this.rchTxtBox_info);
            this.Controls.Add(this.dtgv_cartas);
            this.Controls.Add(this.pic_Exit);
            this.Controls.Add(this.pic_Return);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.dtgv_publicaciones);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBox_nombre);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Frm_CircularClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_CircularClientes";
            this.Load += new System.EventHandler(this.Frm_CircularClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_publicaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Return)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_cartas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_nombre;
        private System.Windows.Forms.RichTextBox rchTxtBox_info;
        private System.Windows.Forms.DataGridView dtgv_publicaciones;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.PictureBox pic_Return;
        private System.Windows.Forms.PictureBox pic_Exit;
        private System.Windows.Forms.DataGridView dtgv_cartas;
    }
}