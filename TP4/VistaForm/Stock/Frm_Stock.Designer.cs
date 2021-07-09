
namespace VistaForm
{
    partial class Frm_Stock
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Stock));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Publicacion_lblCodigo = new System.Windows.Forms.Label();
            this.Publicacion_lblTitulo = new System.Windows.Forms.Label();
            this.Publicacion_lblEdicion = new System.Windows.Forms.Label();
            this.Publicacion_lblEditor = new System.Windows.Forms.Label();
            this.Publicacion_textBox_Codigo = new System.Windows.Forms.TextBox();
            this.Publicacion_textBox_Titulo = new System.Windows.Forms.TextBox();
            this.Publicacion_textBox_Edicion = new System.Windows.Forms.TextBox();
            this.Publicacion_textBox_Editor = new System.Windows.Forms.TextBox();
            this.Publicacion_btnAgregar = new System.Windows.Forms.Button();
            this.Publicacion_btnBorrar = new System.Windows.Forms.Button();
            this.Publicacion_lblTomo = new System.Windows.Forms.Label();
            this.Publicacion_textBox_Tomo = new System.Windows.Forms.TextBox();
            this.tabsFrmStock = new System.Windows.Forms.TabControl();
            this.tabPage_Publicaciones = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.CmboBxPublis_Barcos = new System.Windows.Forms.ComboBox();
            this.CmboBxPublis_Clientes = new System.Windows.Forms.ComboBox();
            this.Publicacion_lblBarcos = new System.Windows.Forms.Label();
            this.Publicacion_lblClientes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Publicacion_textBox_Cantidad = new System.Windows.Forms.TextBox();
            this.lstBoxPublicaciones_Tipo = new System.Windows.Forms.ListBox();
            this.publicaciones_lblTipo = new System.Windows.Forms.Label();
            this.tabPublicacion_dtgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage_Cartas = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.Cartas_btnBorrar = new System.Windows.Forms.Button();
            this.Cartas_lblFechaCorreccion = new System.Windows.Forms.Label();
            this.Cartas_btnAgregar = new System.Windows.Forms.Button();
            this.Cartas_txtBoxFechaCorreccion = new System.Windows.Forms.DateTimePicker();
            this.CmboBxCartas_Barcos = new System.Windows.Forms.ComboBox();
            this.Cartas_lblCodigo = new System.Windows.Forms.Label();
            this.Cartas_lblBarcos = new System.Windows.Forms.Label();
            this.CmboBxCartas_Clientes = new System.Windows.Forms.ComboBox();
            this.Cartas_lblEdicion = new System.Windows.Forms.Label();
            this.Cartas_txtBoxCodigo = new System.Windows.Forms.TextBox();
            this.Cartas_lblClientes = new System.Windows.Forms.Label();
            this.Cartas_txtBoxEdicion = new System.Windows.Forms.TextBox();
            this.Cartas_lblCantidad = new System.Windows.Forms.Label();
            this.Cartas_txtBoxCantidad = new System.Windows.Forms.TextBox();
            this.Cartas_txtBoxTitulo = new System.Windows.Forms.TextBox();
            this.Cartas_lblTitulo = new System.Windows.Forms.Label();
            this.Cartas_txtBoxEditor = new System.Windows.Forms.TextBox();
            this.Cartas_lblEditor = new System.Windows.Forms.Label();
            this.tabCartas_dtgv = new System.Windows.Forms.DataGridView();
            this.tabPage_Stock = new System.Windows.Forms.TabPage();
            this.tabStock_PublicacionDtgv = new System.Windows.Forms.DataGridView();
            this.tabStock_CartasDtgv = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabsFrmStock.SuspendLayout();
            this.tabPage_Publicaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPublicacion_dtgv)).BeginInit();
            this.tabPage_Cartas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabCartas_dtgv)).BeginInit();
            this.tabPage_Stock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabStock_PublicacionDtgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabStock_CartasDtgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Publicacion_lblCodigo
            // 
            this.Publicacion_lblCodigo.AutoSize = true;
            this.Publicacion_lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publicacion_lblCodigo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Publicacion_lblCodigo.Location = new System.Drawing.Point(12, 16);
            this.Publicacion_lblCodigo.Name = "Publicacion_lblCodigo";
            this.Publicacion_lblCodigo.Size = new System.Drawing.Size(63, 20);
            this.Publicacion_lblCodigo.TabIndex = 0;
            this.Publicacion_lblCodigo.Text = "Código:";
            // 
            // Publicacion_lblTitulo
            // 
            this.Publicacion_lblTitulo.AutoSize = true;
            this.Publicacion_lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publicacion_lblTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Publicacion_lblTitulo.Location = new System.Drawing.Point(12, 119);
            this.Publicacion_lblTitulo.Name = "Publicacion_lblTitulo";
            this.Publicacion_lblTitulo.Size = new System.Drawing.Size(51, 20);
            this.Publicacion_lblTitulo.TabIndex = 6;
            this.Publicacion_lblTitulo.Text = "Titulo:";
            // 
            // Publicacion_lblEdicion
            // 
            this.Publicacion_lblEdicion.AutoSize = true;
            this.Publicacion_lblEdicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publicacion_lblEdicion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Publicacion_lblEdicion.Location = new System.Drawing.Point(12, 51);
            this.Publicacion_lblEdicion.Name = "Publicacion_lblEdicion";
            this.Publicacion_lblEdicion.Size = new System.Drawing.Size(61, 20);
            this.Publicacion_lblEdicion.TabIndex = 2;
            this.Publicacion_lblEdicion.Text = "Edicion";
            // 
            // Publicacion_lblEditor
            // 
            this.Publicacion_lblEditor.AutoSize = true;
            this.Publicacion_lblEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publicacion_lblEditor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Publicacion_lblEditor.Location = new System.Drawing.Point(12, 152);
            this.Publicacion_lblEditor.Name = "Publicacion_lblEditor";
            this.Publicacion_lblEditor.Size = new System.Drawing.Size(51, 20);
            this.Publicacion_lblEditor.TabIndex = 8;
            this.Publicacion_lblEditor.Text = "Editor";
            // 
            // Publicacion_textBox_Codigo
            // 
            this.Publicacion_textBox_Codigo.BackColor = System.Drawing.SystemColors.WindowText;
            this.Publicacion_textBox_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publicacion_textBox_Codigo.ForeColor = System.Drawing.SystemColors.Control;
            this.Publicacion_textBox_Codigo.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.Publicacion_textBox_Codigo.Location = new System.Drawing.Point(92, 13);
            this.Publicacion_textBox_Codigo.Name = "Publicacion_textBox_Codigo";
            this.Publicacion_textBox_Codigo.Size = new System.Drawing.Size(253, 26);
            this.Publicacion_textBox_Codigo.TabIndex = 1;
            // 
            // Publicacion_textBox_Titulo
            // 
            this.Publicacion_textBox_Titulo.BackColor = System.Drawing.SystemColors.WindowText;
            this.Publicacion_textBox_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publicacion_textBox_Titulo.ForeColor = System.Drawing.SystemColors.Control;
            this.Publicacion_textBox_Titulo.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.Publicacion_textBox_Titulo.Location = new System.Drawing.Point(92, 113);
            this.Publicacion_textBox_Titulo.Name = "Publicacion_textBox_Titulo";
            this.Publicacion_textBox_Titulo.Size = new System.Drawing.Size(253, 26);
            this.Publicacion_textBox_Titulo.TabIndex = 7;
            // 
            // Publicacion_textBox_Edicion
            // 
            this.Publicacion_textBox_Edicion.BackColor = System.Drawing.SystemColors.WindowText;
            this.Publicacion_textBox_Edicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publicacion_textBox_Edicion.ForeColor = System.Drawing.SystemColors.Control;
            this.Publicacion_textBox_Edicion.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.Publicacion_textBox_Edicion.Location = new System.Drawing.Point(92, 48);
            this.Publicacion_textBox_Edicion.Name = "Publicacion_textBox_Edicion";
            this.Publicacion_textBox_Edicion.Size = new System.Drawing.Size(253, 26);
            this.Publicacion_textBox_Edicion.TabIndex = 3;
            // 
            // Publicacion_textBox_Editor
            // 
            this.Publicacion_textBox_Editor.BackColor = System.Drawing.SystemColors.WindowText;
            this.Publicacion_textBox_Editor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publicacion_textBox_Editor.ForeColor = System.Drawing.SystemColors.Control;
            this.Publicacion_textBox_Editor.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.Publicacion_textBox_Editor.Location = new System.Drawing.Point(92, 149);
            this.Publicacion_textBox_Editor.Name = "Publicacion_textBox_Editor";
            this.Publicacion_textBox_Editor.Size = new System.Drawing.Size(253, 26);
            this.Publicacion_textBox_Editor.TabIndex = 9;
            // 
            // Publicacion_btnAgregar
            // 
            this.Publicacion_btnAgregar.BackColor = System.Drawing.SystemColors.WindowText;
            this.Publicacion_btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publicacion_btnAgregar.ForeColor = System.Drawing.SystemColors.Window;
            this.Publicacion_btnAgregar.Location = new System.Drawing.Point(16, 359);
            this.Publicacion_btnAgregar.Name = "Publicacion_btnAgregar";
            this.Publicacion_btnAgregar.Size = new System.Drawing.Size(128, 38);
            this.Publicacion_btnAgregar.TabIndex = 14;
            this.Publicacion_btnAgregar.Text = "Agregar";
            this.Publicacion_btnAgregar.UseVisualStyleBackColor = false;
            this.Publicacion_btnAgregar.Click += new System.EventHandler(this.Publicacion_btnAgregarClick);
            // 
            // Publicacion_btnBorrar
            // 
            this.Publicacion_btnBorrar.BackColor = System.Drawing.SystemColors.WindowText;
            this.Publicacion_btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publicacion_btnBorrar.ForeColor = System.Drawing.SystemColors.Window;
            this.Publicacion_btnBorrar.Location = new System.Drawing.Point(206, 359);
            this.Publicacion_btnBorrar.Name = "Publicacion_btnBorrar";
            this.Publicacion_btnBorrar.Size = new System.Drawing.Size(128, 37);
            this.Publicacion_btnBorrar.TabIndex = 15;
            this.Publicacion_btnBorrar.Text = "Limpiar";
            this.Publicacion_btnBorrar.UseVisualStyleBackColor = false;
            this.Publicacion_btnBorrar.Click += new System.EventHandler(this.Publicacion_btnBorrarClick);
            // 
            // Publicacion_lblTomo
            // 
            this.Publicacion_lblTomo.AutoSize = true;
            this.Publicacion_lblTomo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publicacion_lblTomo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Publicacion_lblTomo.Location = new System.Drawing.Point(14, 223);
            this.Publicacion_lblTomo.Name = "Publicacion_lblTomo";
            this.Publicacion_lblTomo.Size = new System.Drawing.Size(49, 20);
            this.Publicacion_lblTomo.TabIndex = 12;
            this.Publicacion_lblTomo.Text = "Tomo";
            // 
            // Publicacion_textBox_Tomo
            // 
            this.Publicacion_textBox_Tomo.BackColor = System.Drawing.SystemColors.WindowText;
            this.Publicacion_textBox_Tomo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publicacion_textBox_Tomo.ForeColor = System.Drawing.SystemColors.Control;
            this.Publicacion_textBox_Tomo.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.Publicacion_textBox_Tomo.Location = new System.Drawing.Point(92, 225);
            this.Publicacion_textBox_Tomo.Name = "Publicacion_textBox_Tomo";
            this.Publicacion_textBox_Tomo.Size = new System.Drawing.Size(253, 26);
            this.Publicacion_textBox_Tomo.TabIndex = 13;
            // 
            // tabsFrmStock
            // 
            this.tabsFrmStock.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabsFrmStock.Controls.Add(this.tabPage_Publicaciones);
            this.tabsFrmStock.Controls.Add(this.tabPage_Cartas);
            this.tabsFrmStock.Controls.Add(this.tabPage_Stock);
            this.tabsFrmStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabsFrmStock.HotTrack = true;
            this.tabsFrmStock.Location = new System.Drawing.Point(0, 61);
            this.tabsFrmStock.Multiline = true;
            this.tabsFrmStock.Name = "tabsFrmStock";
            this.tabsFrmStock.SelectedIndex = 0;
            this.tabsFrmStock.Size = new System.Drawing.Size(1099, 609);
            this.tabsFrmStock.TabIndex = 30;
            this.tabsFrmStock.Click += new System.EventHandler(this.TabStock_Click);
            // 
            // tabPage_Publicaciones
            // 
            this.tabPage_Publicaciones.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage_Publicaciones.Controls.Add(this.splitContainer1);
            this.tabPage_Publicaciones.Controls.Add(this.label1);
            this.tabPage_Publicaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_Publicaciones.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tabPage_Publicaciones.Location = new System.Drawing.Point(4, 36);
            this.tabPage_Publicaciones.Name = "tabPage_Publicaciones";
            this.tabPage_Publicaciones.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Publicaciones.Size = new System.Drawing.Size(1091, 569);
            this.tabPage_Publicaciones.TabIndex = 0;
            this.tabPage_Publicaciones.Text = "Publicaciones";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.ForeColor = System.Drawing.SystemColors.Window;
            this.splitContainer1.Location = new System.Drawing.Point(1, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.splitContainer1.Panel1.Controls.Add(this.CmboBxPublis_Barcos);
            this.splitContainer1.Panel1.Controls.Add(this.Publicacion_btnBorrar);
            this.splitContainer1.Panel1.Controls.Add(this.Publicacion_textBox_Titulo);
            this.splitContainer1.Panel1.Controls.Add(this.Publicacion_btnAgregar);
            this.splitContainer1.Panel1.Controls.Add(this.CmboBxPublis_Clientes);
            this.splitContainer1.Panel1.Controls.Add(this.Publicacion_lblTitulo);
            this.splitContainer1.Panel1.Controls.Add(this.Publicacion_lblCodigo);
            this.splitContainer1.Panel1.Controls.Add(this.Publicacion_lblBarcos);
            this.splitContainer1.Panel1.Controls.Add(this.Publicacion_lblEditor);
            this.splitContainer1.Panel1.Controls.Add(this.Publicacion_lblClientes);
            this.splitContainer1.Panel1.Controls.Add(this.Publicacion_lblEdicion);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.Publicacion_lblTomo);
            this.splitContainer1.Panel1.Controls.Add(this.Publicacion_textBox_Cantidad);
            this.splitContainer1.Panel1.Controls.Add(this.Publicacion_textBox_Editor);
            this.splitContainer1.Panel1.Controls.Add(this.Publicacion_textBox_Tomo);
            this.splitContainer1.Panel1.Controls.Add(this.lstBoxPublicaciones_Tipo);
            this.splitContainer1.Panel1.Controls.Add(this.Publicacion_textBox_Codigo);
            this.splitContainer1.Panel1.Controls.Add(this.publicaciones_lblTipo);
            this.splitContainer1.Panel1.Controls.Add(this.Publicacion_textBox_Edicion);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox2);
            this.splitContainer1.Panel1.ForeColor = System.Drawing.SystemColors.WindowText;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.splitContainer1.Panel2.Controls.Add(this.tabPublicacion_dtgv);
            this.splitContainer1.Size = new System.Drawing.Size(1090, 428);
            this.splitContainer1.SplitterDistance = 358;
            this.splitContainer1.TabIndex = 30;
            // 
            // CmboBxPublis_Barcos
            // 
            this.CmboBxPublis_Barcos.BackColor = System.Drawing.SystemColors.WindowText;
            this.CmboBxPublis_Barcos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmboBxPublis_Barcos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmboBxPublis_Barcos.ForeColor = System.Drawing.SystemColors.Window;
            this.CmboBxPublis_Barcos.FormattingEnabled = true;
            this.CmboBxPublis_Barcos.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.CmboBxPublis_Barcos.Location = new System.Drawing.Point(92, 307);
            this.CmboBxPublis_Barcos.Name = "CmboBxPublis_Barcos";
            this.CmboBxPublis_Barcos.Size = new System.Drawing.Size(253, 28);
            this.CmboBxPublis_Barcos.TabIndex = 28;
            // 
            // CmboBxPublis_Clientes
            // 
            this.CmboBxPublis_Clientes.BackColor = System.Drawing.SystemColors.WindowText;
            this.CmboBxPublis_Clientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmboBxPublis_Clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmboBxPublis_Clientes.ForeColor = System.Drawing.SystemColors.Window;
            this.CmboBxPublis_Clientes.FormattingEnabled = true;
            this.CmboBxPublis_Clientes.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.CmboBxPublis_Clientes.Location = new System.Drawing.Point(92, 262);
            this.CmboBxPublis_Clientes.Name = "CmboBxPublis_Clientes";
            this.CmboBxPublis_Clientes.Size = new System.Drawing.Size(253, 28);
            this.CmboBxPublis_Clientes.TabIndex = 27;
            this.CmboBxPublis_Clientes.SelectedValueChanged += new System.EventHandler(this.CmboBoxPublicacionesClientes_Click);
            // 
            // Publicacion_lblBarcos
            // 
            this.Publicacion_lblBarcos.AutoSize = true;
            this.Publicacion_lblBarcos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publicacion_lblBarcos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Publicacion_lblBarcos.Location = new System.Drawing.Point(14, 307);
            this.Publicacion_lblBarcos.Name = "Publicacion_lblBarcos";
            this.Publicacion_lblBarcos.Size = new System.Drawing.Size(59, 20);
            this.Publicacion_lblBarcos.TabIndex = 18;
            this.Publicacion_lblBarcos.Text = "Barcos";
            // 
            // Publicacion_lblClientes
            // 
            this.Publicacion_lblClientes.AutoSize = true;
            this.Publicacion_lblClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publicacion_lblClientes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Publicacion_lblClientes.Location = new System.Drawing.Point(12, 262);
            this.Publicacion_lblClientes.Name = "Publicacion_lblClientes";
            this.Publicacion_lblClientes.Size = new System.Drawing.Size(66, 20);
            this.Publicacion_lblClientes.TabIndex = 16;
            this.Publicacion_lblClientes.Text = "Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cantidad";
            // 
            // Publicacion_textBox_Cantidad
            // 
            this.Publicacion_textBox_Cantidad.BackColor = System.Drawing.SystemColors.WindowText;
            this.Publicacion_textBox_Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publicacion_textBox_Cantidad.ForeColor = System.Drawing.SystemColors.Window;
            this.Publicacion_textBox_Cantidad.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.Publicacion_textBox_Cantidad.Location = new System.Drawing.Point(92, 191);
            this.Publicacion_textBox_Cantidad.Name = "Publicacion_textBox_Cantidad";
            this.Publicacion_textBox_Cantidad.Size = new System.Drawing.Size(253, 26);
            this.Publicacion_textBox_Cantidad.TabIndex = 11;
            // 
            // lstBoxPublicaciones_Tipo
            // 
            this.lstBoxPublicaciones_Tipo.BackColor = System.Drawing.SystemColors.WindowText;
            this.lstBoxPublicaciones_Tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxPublicaciones_Tipo.ForeColor = System.Drawing.SystemColors.Control;
            this.lstBoxPublicaciones_Tipo.FormattingEnabled = true;
            this.lstBoxPublicaciones_Tipo.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.lstBoxPublicaciones_Tipo.ItemHeight = 20;
            this.lstBoxPublicaciones_Tipo.Location = new System.Drawing.Point(92, 79);
            this.lstBoxPublicaciones_Tipo.Name = "lstBoxPublicaciones_Tipo";
            this.lstBoxPublicaciones_Tipo.Size = new System.Drawing.Size(253, 24);
            this.lstBoxPublicaciones_Tipo.TabIndex = 5;
            // 
            // publicaciones_lblTipo
            // 
            this.publicaciones_lblTipo.AutoSize = true;
            this.publicaciones_lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publicaciones_lblTipo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.publicaciones_lblTipo.Location = new System.Drawing.Point(12, 83);
            this.publicaciones_lblTipo.Name = "publicaciones_lblTipo";
            this.publicaciones_lblTipo.Size = new System.Drawing.Size(39, 20);
            this.publicaciones_lblTipo.TabIndex = 4;
            this.publicaciones_lblTipo.Text = "Tipo";
            // 
            // tabPublicacion_dtgv
            // 
            this.tabPublicacion_dtgv.AllowUserToAddRows = false;
            this.tabPublicacion_dtgv.AllowUserToDeleteRows = false;
            this.tabPublicacion_dtgv.AllowUserToResizeColumns = false;
            this.tabPublicacion_dtgv.AllowUserToResizeRows = false;
            this.tabPublicacion_dtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tabPublicacion_dtgv.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.tabPublicacion_dtgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPublicacion_dtgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.tabPublicacion_dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabPublicacion_dtgv.DefaultCellStyle = dataGridViewCellStyle1;
            this.tabPublicacion_dtgv.GridColor = System.Drawing.SystemColors.Window;
            this.tabPublicacion_dtgv.Location = new System.Drawing.Point(5, 6);
            this.tabPublicacion_dtgv.Name = "tabPublicacion_dtgv";
            this.tabPublicacion_dtgv.ReadOnly = true;
            this.tabPublicacion_dtgv.Size = new System.Drawing.Size(594, 398);
            this.tabPublicacion_dtgv.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(541, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 26;
            // 
            // tabPage_Cartas
            // 
            this.tabPage_Cartas.Controls.Add(this.splitContainer2);
            this.tabPage_Cartas.Location = new System.Drawing.Point(4, 36);
            this.tabPage_Cartas.Name = "tabPage_Cartas";
            this.tabPage_Cartas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Cartas.Size = new System.Drawing.Size(1091, 569);
            this.tabPage_Cartas.TabIndex = 1;
            this.tabPage_Cartas.Text = "Cartas";
            this.tabPage_Cartas.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.splitContainer2.ForeColor = System.Drawing.SystemColors.Window;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.MenuText;
            this.splitContainer2.Panel1.Controls.Add(this.Cartas_btnBorrar);
            this.splitContainer2.Panel1.Controls.Add(this.Cartas_lblFechaCorreccion);
            this.splitContainer2.Panel1.Controls.Add(this.Cartas_btnAgregar);
            this.splitContainer2.Panel1.Controls.Add(this.Cartas_txtBoxFechaCorreccion);
            this.splitContainer2.Panel1.Controls.Add(this.CmboBxCartas_Barcos);
            this.splitContainer2.Panel1.Controls.Add(this.Cartas_lblCodigo);
            this.splitContainer2.Panel1.Controls.Add(this.Cartas_lblBarcos);
            this.splitContainer2.Panel1.Controls.Add(this.CmboBxCartas_Clientes);
            this.splitContainer2.Panel1.Controls.Add(this.Cartas_lblEdicion);
            this.splitContainer2.Panel1.Controls.Add(this.Cartas_txtBoxCodigo);
            this.splitContainer2.Panel1.Controls.Add(this.Cartas_lblClientes);
            this.splitContainer2.Panel1.Controls.Add(this.Cartas_txtBoxEdicion);
            this.splitContainer2.Panel1.Controls.Add(this.Cartas_lblCantidad);
            this.splitContainer2.Panel1.Controls.Add(this.Cartas_txtBoxCantidad);
            this.splitContainer2.Panel1.Controls.Add(this.Cartas_txtBoxTitulo);
            this.splitContainer2.Panel1.Controls.Add(this.Cartas_lblTitulo);
            this.splitContainer2.Panel1.Controls.Add(this.Cartas_txtBoxEditor);
            this.splitContainer2.Panel1.Controls.Add(this.Cartas_lblEditor);
            this.splitContainer2.Panel1.Controls.Add(this.pictureBox3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.WindowText;
            this.splitContainer2.Panel2.Controls.Add(this.tabCartas_dtgv);
            this.splitContainer2.Size = new System.Drawing.Size(1095, 437);
            this.splitContainer2.SplitterDistance = 357;
            this.splitContainer2.TabIndex = 26;
            // 
            // Cartas_btnBorrar
            // 
            this.Cartas_btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cartas_btnBorrar.Location = new System.Drawing.Point(196, 372);
            this.Cartas_btnBorrar.Name = "Cartas_btnBorrar";
            this.Cartas_btnBorrar.Size = new System.Drawing.Size(148, 27);
            this.Cartas_btnBorrar.TabIndex = 14;
            this.Cartas_btnBorrar.Text = "Limpiar";
            this.Cartas_btnBorrar.UseVisualStyleBackColor = true;
            this.Cartas_btnBorrar.Click += new System.EventHandler(this.Cartas_btnBorrarClick);
            // 
            // Cartas_lblFechaCorreccion
            // 
            this.Cartas_lblFechaCorreccion.AutoSize = true;
            this.Cartas_lblFechaCorreccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cartas_lblFechaCorreccion.Location = new System.Drawing.Point(6, 298);
            this.Cartas_lblFechaCorreccion.Name = "Cartas_lblFechaCorreccion";
            this.Cartas_lblFechaCorreccion.Size = new System.Drawing.Size(156, 20);
            this.Cartas_lblFechaCorreccion.TabIndex = 11;
            this.Cartas_lblFechaCorreccion.Text = "Fecha de Corrección";
            // 
            // Cartas_btnAgregar
            // 
            this.Cartas_btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cartas_btnAgregar.Location = new System.Drawing.Point(14, 372);
            this.Cartas_btnAgregar.Name = "Cartas_btnAgregar";
            this.Cartas_btnAgregar.Size = new System.Drawing.Size(148, 30);
            this.Cartas_btnAgregar.TabIndex = 13;
            this.Cartas_btnAgregar.Text = "Agregar";
            this.Cartas_btnAgregar.UseVisualStyleBackColor = true;
            this.Cartas_btnAgregar.Click += new System.EventHandler(this.Cartas_btnAgregarClick);
            // 
            // Cartas_txtBoxFechaCorreccion
            // 
            this.Cartas_txtBoxFechaCorreccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cartas_txtBoxFechaCorreccion.Location = new System.Drawing.Point(12, 321);
            this.Cartas_txtBoxFechaCorreccion.Name = "Cartas_txtBoxFechaCorreccion";
            this.Cartas_txtBoxFechaCorreccion.Size = new System.Drawing.Size(331, 26);
            this.Cartas_txtBoxFechaCorreccion.TabIndex = 12;
            // 
            // CmboBxCartas_Barcos
            // 
            this.CmboBxCartas_Barcos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmboBxCartas_Barcos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmboBxCartas_Barcos.FormattingEnabled = true;
            this.CmboBxCartas_Barcos.Location = new System.Drawing.Point(89, 263);
            this.CmboBxCartas_Barcos.Name = "CmboBxCartas_Barcos";
            this.CmboBxCartas_Barcos.Size = new System.Drawing.Size(255, 28);
            this.CmboBxCartas_Barcos.TabIndex = 25;
            // 
            // Cartas_lblCodigo
            // 
            this.Cartas_lblCodigo.AutoSize = true;
            this.Cartas_lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cartas_lblCodigo.Location = new System.Drawing.Point(9, 17);
            this.Cartas_lblCodigo.Name = "Cartas_lblCodigo";
            this.Cartas_lblCodigo.Size = new System.Drawing.Size(63, 20);
            this.Cartas_lblCodigo.TabIndex = 0;
            this.Cartas_lblCodigo.Text = "Código:";
            // 
            // Cartas_lblBarcos
            // 
            this.Cartas_lblBarcos.AutoSize = true;
            this.Cartas_lblBarcos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cartas_lblBarcos.Location = new System.Drawing.Point(8, 263);
            this.Cartas_lblBarcos.Name = "Cartas_lblBarcos";
            this.Cartas_lblBarcos.Size = new System.Drawing.Size(59, 20);
            this.Cartas_lblBarcos.TabIndex = 22;
            this.Cartas_lblBarcos.Text = "Barcos";
            // 
            // CmboBxCartas_Clientes
            // 
            this.CmboBxCartas_Clientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmboBxCartas_Clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmboBxCartas_Clientes.FormattingEnabled = true;
            this.CmboBxCartas_Clientes.Location = new System.Drawing.Point(88, 218);
            this.CmboBxCartas_Clientes.Name = "CmboBxCartas_Clientes";
            this.CmboBxCartas_Clientes.Size = new System.Drawing.Size(256, 28);
            this.CmboBxCartas_Clientes.TabIndex = 24;
            this.CmboBxCartas_Clientes.SelectedValueChanged += new System.EventHandler(this.CmboBxCartasClientes_Click);
            // 
            // Cartas_lblEdicion
            // 
            this.Cartas_lblEdicion.AutoSize = true;
            this.Cartas_lblEdicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cartas_lblEdicion.Location = new System.Drawing.Point(8, 52);
            this.Cartas_lblEdicion.Name = "Cartas_lblEdicion";
            this.Cartas_lblEdicion.Size = new System.Drawing.Size(61, 20);
            this.Cartas_lblEdicion.TabIndex = 2;
            this.Cartas_lblEdicion.Text = "Edicion";
            // 
            // Cartas_txtBoxCodigo
            // 
            this.Cartas_txtBoxCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cartas_txtBoxCodigo.Location = new System.Drawing.Point(87, 11);
            this.Cartas_txtBoxCodigo.Name = "Cartas_txtBoxCodigo";
            this.Cartas_txtBoxCodigo.Size = new System.Drawing.Size(257, 26);
            this.Cartas_txtBoxCodigo.TabIndex = 1;
            // 
            // Cartas_lblClientes
            // 
            this.Cartas_lblClientes.AutoSize = true;
            this.Cartas_lblClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cartas_lblClientes.Location = new System.Drawing.Point(8, 218);
            this.Cartas_lblClientes.Name = "Cartas_lblClientes";
            this.Cartas_lblClientes.Size = new System.Drawing.Size(66, 20);
            this.Cartas_lblClientes.TabIndex = 20;
            this.Cartas_lblClientes.Text = "Clientes";
            // 
            // Cartas_txtBoxEdicion
            // 
            this.Cartas_txtBoxEdicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cartas_txtBoxEdicion.Location = new System.Drawing.Point(88, 49);
            this.Cartas_txtBoxEdicion.Name = "Cartas_txtBoxEdicion";
            this.Cartas_txtBoxEdicion.Size = new System.Drawing.Size(256, 26);
            this.Cartas_txtBoxEdicion.TabIndex = 3;
            // 
            // Cartas_lblCantidad
            // 
            this.Cartas_lblCantidad.AutoSize = true;
            this.Cartas_lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cartas_lblCantidad.Location = new System.Drawing.Point(9, 92);
            this.Cartas_lblCantidad.Name = "Cartas_lblCantidad";
            this.Cartas_lblCantidad.Size = new System.Drawing.Size(73, 20);
            this.Cartas_lblCantidad.TabIndex = 4;
            this.Cartas_lblCantidad.Text = "Cantidad";
            // 
            // Cartas_txtBoxCantidad
            // 
            this.Cartas_txtBoxCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cartas_txtBoxCantidad.Location = new System.Drawing.Point(87, 89);
            this.Cartas_txtBoxCantidad.Name = "Cartas_txtBoxCantidad";
            this.Cartas_txtBoxCantidad.Size = new System.Drawing.Size(257, 26);
            this.Cartas_txtBoxCantidad.TabIndex = 5;
            // 
            // Cartas_txtBoxTitulo
            // 
            this.Cartas_txtBoxTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cartas_txtBoxTitulo.Location = new System.Drawing.Point(87, 130);
            this.Cartas_txtBoxTitulo.Name = "Cartas_txtBoxTitulo";
            this.Cartas_txtBoxTitulo.Size = new System.Drawing.Size(257, 26);
            this.Cartas_txtBoxTitulo.TabIndex = 8;
            // 
            // Cartas_lblTitulo
            // 
            this.Cartas_lblTitulo.AutoSize = true;
            this.Cartas_lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cartas_lblTitulo.Location = new System.Drawing.Point(9, 130);
            this.Cartas_lblTitulo.Name = "Cartas_lblTitulo";
            this.Cartas_lblTitulo.Size = new System.Drawing.Size(51, 20);
            this.Cartas_lblTitulo.TabIndex = 7;
            this.Cartas_lblTitulo.Text = "Titulo:";
            // 
            // Cartas_txtBoxEditor
            // 
            this.Cartas_txtBoxEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cartas_txtBoxEditor.Location = new System.Drawing.Point(87, 171);
            this.Cartas_txtBoxEditor.Name = "Cartas_txtBoxEditor";
            this.Cartas_txtBoxEditor.Size = new System.Drawing.Size(257, 26);
            this.Cartas_txtBoxEditor.TabIndex = 10;
            // 
            // Cartas_lblEditor
            // 
            this.Cartas_lblEditor.AutoSize = true;
            this.Cartas_lblEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cartas_lblEditor.Location = new System.Drawing.Point(10, 174);
            this.Cartas_lblEditor.Name = "Cartas_lblEditor";
            this.Cartas_lblEditor.Size = new System.Drawing.Size(51, 20);
            this.Cartas_lblEditor.TabIndex = 9;
            this.Cartas_lblEditor.Text = "Editor";
            // 
            // tabCartas_dtgv
            // 
            this.tabCartas_dtgv.AllowUserToAddRows = false;
            this.tabCartas_dtgv.AllowUserToDeleteRows = false;
            this.tabCartas_dtgv.AllowUserToResizeColumns = false;
            this.tabCartas_dtgv.AllowUserToResizeRows = false;
            this.tabCartas_dtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tabCartas_dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabCartas_dtgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.tabCartas_dtgv.Location = new System.Drawing.Point(3, 5);
            this.tabCartas_dtgv.Name = "tabCartas_dtgv";
            this.tabCartas_dtgv.Size = new System.Drawing.Size(600, 399);
            this.tabCartas_dtgv.TabIndex = 16;
            // 
            // tabPage_Stock
            // 
            this.tabPage_Stock.Controls.Add(this.tabStock_PublicacionDtgv);
            this.tabPage_Stock.Controls.Add(this.tabStock_CartasDtgv);
            this.tabPage_Stock.Controls.Add(this.menuStrip1);
            this.tabPage_Stock.Location = new System.Drawing.Point(4, 36);
            this.tabPage_Stock.Name = "tabPage_Stock";
            this.tabPage_Stock.Size = new System.Drawing.Size(1091, 569);
            this.tabPage_Stock.TabIndex = 2;
            this.tabPage_Stock.Text = "Stock";
            this.tabPage_Stock.UseVisualStyleBackColor = true;
            // 
            // tabStock_PublicacionDtgv
            // 
            this.tabStock_PublicacionDtgv.AllowUserToAddRows = false;
            this.tabStock_PublicacionDtgv.AllowUserToDeleteRows = false;
            this.tabStock_PublicacionDtgv.AllowUserToResizeColumns = false;
            this.tabStock_PublicacionDtgv.AllowUserToResizeRows = false;
            this.tabStock_PublicacionDtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tabStock_PublicacionDtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabStock_PublicacionDtgv.Location = new System.Drawing.Point(6, 85);
            this.tabStock_PublicacionDtgv.Name = "tabStock_PublicacionDtgv";
            this.tabStock_PublicacionDtgv.Size = new System.Drawing.Size(957, 183);
            this.tabStock_PublicacionDtgv.TabIndex = 2;
            // 
            // tabStock_CartasDtgv
            // 
            this.tabStock_CartasDtgv.AllowUserToAddRows = false;
            this.tabStock_CartasDtgv.AllowUserToDeleteRows = false;
            this.tabStock_CartasDtgv.AllowUserToResizeColumns = false;
            this.tabStock_CartasDtgv.AllowUserToResizeRows = false;
            this.tabStock_CartasDtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tabStock_CartasDtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabStock_CartasDtgv.Location = new System.Drawing.Point(6, 274);
            this.tabStock_CartasDtgv.Name = "tabStock_CartasDtgv";
            this.tabStock_CartasDtgv.Size = new System.Drawing.Size(957, 183);
            this.tabStock_CartasDtgv.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1091, 4);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VistaForm.Properties.Resources.MSLTD__2_;
            this.pictureBox1.Location = new System.Drawing.Point(-43, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(999, 60);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(360, 405);
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::VistaForm.Properties.Resources._603_6036837_hero_overlay_green_and_blue_swirl_png_clipart;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(358, 414);
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // Frm_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(972, 506);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabsFrmStock);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Form_Stock_Load);
            this.tabsFrmStock.ResumeLayout(false);
            this.tabPage_Publicaciones.ResumeLayout(false);
            this.tabPage_Publicaciones.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPublicacion_dtgv)).EndInit();
            this.tabPage_Cartas.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabCartas_dtgv)).EndInit();
            this.tabPage_Stock.ResumeLayout(false);
            this.tabPage_Stock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabStock_PublicacionDtgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabStock_CartasDtgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label Publicacion_lblCodigo;
        private System.Windows.Forms.Label Publicacion_lblTitulo;
        private System.Windows.Forms.Label Publicacion_lblEdicion;
        private System.Windows.Forms.Label Publicacion_lblEditor;
        private System.Windows.Forms.TextBox Publicacion_textBox_Codigo;
        private System.Windows.Forms.TextBox Publicacion_textBox_Titulo;
        private System.Windows.Forms.TextBox Publicacion_textBox_Edicion;
        private System.Windows.Forms.TextBox Publicacion_textBox_Editor;
        private System.Windows.Forms.Button Publicacion_btnAgregar;
        private System.Windows.Forms.Button Publicacion_btnBorrar;
        private System.Windows.Forms.Label Publicacion_lblTomo;
        private System.Windows.Forms.TextBox Publicacion_textBox_Tomo;
        private System.Windows.Forms.TabControl tabsFrmStock;
        private System.Windows.Forms.TabPage tabPage_Publicaciones;
        private System.Windows.Forms.TabPage tabPage_Cartas;
        private System.Windows.Forms.TabPage tabPage_Stock;
        private System.Windows.Forms.Button Cartas_btnBorrar;
        private System.Windows.Forms.Button Cartas_btnAgregar;
        private System.Windows.Forms.TextBox Cartas_txtBoxEdicion;
        private System.Windows.Forms.DataGridView tabCartas_dtgv;
        private System.Windows.Forms.TextBox Cartas_txtBoxCodigo;
        private System.Windows.Forms.TextBox Cartas_txtBoxEditor;
        private System.Windows.Forms.Label Cartas_lblEdicion;
        private System.Windows.Forms.Label Cartas_lblEditor;
        private System.Windows.Forms.Label Cartas_lblCodigo;
        private System.Windows.Forms.Label Cartas_lblTitulo;
        private System.Windows.Forms.TextBox Cartas_txtBoxTitulo;
        private System.Windows.Forms.Label Cartas_lblFechaCorreccion;
        private System.Windows.Forms.TextBox Publicacion_textBox_Cantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Cartas_txtBoxCantidad;
        private System.Windows.Forms.Label Cartas_lblCantidad;
        private System.Windows.Forms.ListBox lstBoxPublicaciones_Tipo;
        private System.Windows.Forms.Label publicaciones_lblTipo;
        private System.Windows.Forms.DateTimePicker Cartas_txtBoxFechaCorreccion;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView tabStock_CartasDtgv;
        private System.Windows.Forms.DataGridView tabStock_PublicacionDtgv;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label Publicacion_lblBarcos;
        private System.Windows.Forms.Label Publicacion_lblClientes;
        private System.Windows.Forms.Label Cartas_lblBarcos;
        private System.Windows.Forms.Label Cartas_lblClientes;
        private System.Windows.Forms.ComboBox CmboBxCartas_Clientes;
        private System.Windows.Forms.ComboBox CmboBxCartas_Barcos;
        private System.Windows.Forms.ComboBox CmboBxPublis_Barcos;
        private System.Windows.Forms.ComboBox CmboBxPublis_Clientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tabPublicacion_dtgv;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

