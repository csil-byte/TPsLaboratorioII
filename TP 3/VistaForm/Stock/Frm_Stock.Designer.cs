
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabPublicacion_dtgv = new System.Windows.Forms.DataGridView();
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
            this.CmboBxPublis_Barcos = new System.Windows.Forms.ComboBox();
            this.CmboBxPublis_Clientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Publicacion_lblBarcos = new System.Windows.Forms.Label();
            this.Publicacion_lblClientes = new System.Windows.Forms.Label();
            this.lstBoxPublicaciones_Tipo = new System.Windows.Forms.ListBox();
            this.publicaciones_lblTipo = new System.Windows.Forms.Label();
            this.Publicacion_textBox_Cantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage_Cartas = new System.Windows.Forms.TabPage();
            this.CmboBxCartas_Barcos = new System.Windows.Forms.ComboBox();
            this.CmboBxCartas_Clientes = new System.Windows.Forms.ComboBox();
            this.Cartas_lblBarcos = new System.Windows.Forms.Label();
            this.Cartas_lblClientes = new System.Windows.Forms.Label();
            this.Cartas_txtBoxFechaCorreccion = new System.Windows.Forms.DateTimePicker();
            this.Cartas_txtBoxCantidad = new System.Windows.Forms.TextBox();
            this.Cartas_lblCantidad = new System.Windows.Forms.Label();
            this.Cartas_lblFechaCorreccion = new System.Windows.Forms.Label();
            this.Cartas_btnBorrar = new System.Windows.Forms.Button();
            this.Cartas_btnAgregar = new System.Windows.Forms.Button();
            this.Cartas_txtBoxEdicion = new System.Windows.Forms.TextBox();
            this.tabCartas_dtgv = new System.Windows.Forms.DataGridView();
            this.Cartas_txtBoxCodigo = new System.Windows.Forms.TextBox();
            this.Cartas_txtBoxEditor = new System.Windows.Forms.TextBox();
            this.Cartas_lblEdicion = new System.Windows.Forms.Label();
            this.Cartas_lblEditor = new System.Windows.Forms.Label();
            this.Cartas_lblCodigo = new System.Windows.Forms.Label();
            this.Cartas_lblTitulo = new System.Windows.Forms.Label();
            this.Cartas_txtBoxTitulo = new System.Windows.Forms.TextBox();
            this.tabPage_Stock = new System.Windows.Forms.TabPage();
            this.tabStock_PublicacionDtgv = new System.Windows.Forms.DataGridView();
            this.tabStock_CartasDtgv = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tabPublicacion_dtgv)).BeginInit();
            this.tabsFrmStock.SuspendLayout();
            this.tabPage_Publicaciones.SuspendLayout();
            this.tabPage_Cartas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabCartas_dtgv)).BeginInit();
            this.tabPage_Stock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabStock_PublicacionDtgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabStock_CartasDtgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabPublicacion_dtgv
            // 
            this.tabPublicacion_dtgv.AllowUserToAddRows = false;
            this.tabPublicacion_dtgv.AllowUserToDeleteRows = false;
            this.tabPublicacion_dtgv.AllowUserToResizeColumns = false;
            this.tabPublicacion_dtgv.AllowUserToResizeRows = false;
            this.tabPublicacion_dtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tabPublicacion_dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabPublicacion_dtgv.Location = new System.Drawing.Point(6, 134);
            this.tabPublicacion_dtgv.Name = "tabPublicacion_dtgv";
            this.tabPublicacion_dtgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tabPublicacion_dtgv.Size = new System.Drawing.Size(937, 379);
            this.tabPublicacion_dtgv.TabIndex = 3;
            // 
            // Publicacion_lblCodigo
            // 
            this.Publicacion_lblCodigo.AutoSize = true;
            this.Publicacion_lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publicacion_lblCodigo.Location = new System.Drawing.Point(22, 30);
            this.Publicacion_lblCodigo.Name = "Publicacion_lblCodigo";
            this.Publicacion_lblCodigo.Size = new System.Drawing.Size(63, 20);
            this.Publicacion_lblCodigo.TabIndex = 0;
            this.Publicacion_lblCodigo.Text = "Código:";
            // 
            // Publicacion_lblTitulo
            // 
            this.Publicacion_lblTitulo.AutoSize = true;
            this.Publicacion_lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publicacion_lblTitulo.Location = new System.Drawing.Point(266, 32);
            this.Publicacion_lblTitulo.Name = "Publicacion_lblTitulo";
            this.Publicacion_lblTitulo.Size = new System.Drawing.Size(51, 20);
            this.Publicacion_lblTitulo.TabIndex = 6;
            this.Publicacion_lblTitulo.Text = "Titulo:";
            // 
            // Publicacion_lblEdicion
            // 
            this.Publicacion_lblEdicion.AutoSize = true;
            this.Publicacion_lblEdicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publicacion_lblEdicion.Location = new System.Drawing.Point(24, 66);
            this.Publicacion_lblEdicion.Name = "Publicacion_lblEdicion";
            this.Publicacion_lblEdicion.Size = new System.Drawing.Size(61, 20);
            this.Publicacion_lblEdicion.TabIndex = 2;
            this.Publicacion_lblEdicion.Text = "Edicion";
            // 
            // Publicacion_lblEditor
            // 
            this.Publicacion_lblEditor.AutoSize = true;
            this.Publicacion_lblEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publicacion_lblEditor.Location = new System.Drawing.Point(266, 63);
            this.Publicacion_lblEditor.Name = "Publicacion_lblEditor";
            this.Publicacion_lblEditor.Size = new System.Drawing.Size(51, 20);
            this.Publicacion_lblEditor.TabIndex = 8;
            this.Publicacion_lblEditor.Text = "Editor";
            // 
            // Publicacion_textBox_Codigo
            // 
            this.Publicacion_textBox_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publicacion_textBox_Codigo.Location = new System.Drawing.Point(91, 26);
            this.Publicacion_textBox_Codigo.Name = "Publicacion_textBox_Codigo";
            this.Publicacion_textBox_Codigo.Size = new System.Drawing.Size(162, 26);
            this.Publicacion_textBox_Codigo.TabIndex = 1;
            // 
            // Publicacion_textBox_Titulo
            // 
            this.Publicacion_textBox_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publicacion_textBox_Titulo.Location = new System.Drawing.Point(340, 27);
            this.Publicacion_textBox_Titulo.Name = "Publicacion_textBox_Titulo";
            this.Publicacion_textBox_Titulo.Size = new System.Drawing.Size(160, 26);
            this.Publicacion_textBox_Titulo.TabIndex = 7;
            // 
            // Publicacion_textBox_Edicion
            // 
            this.Publicacion_textBox_Edicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publicacion_textBox_Edicion.Location = new System.Drawing.Point(91, 63);
            this.Publicacion_textBox_Edicion.Name = "Publicacion_textBox_Edicion";
            this.Publicacion_textBox_Edicion.Size = new System.Drawing.Size(162, 26);
            this.Publicacion_textBox_Edicion.TabIndex = 3;
            // 
            // Publicacion_textBox_Editor
            // 
            this.Publicacion_textBox_Editor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publicacion_textBox_Editor.Location = new System.Drawing.Point(340, 63);
            this.Publicacion_textBox_Editor.Name = "Publicacion_textBox_Editor";
            this.Publicacion_textBox_Editor.Size = new System.Drawing.Size(160, 26);
            this.Publicacion_textBox_Editor.TabIndex = 9;
            // 
            // Publicacion_btnAgregar
            // 
            this.Publicacion_btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publicacion_btnAgregar.Location = new System.Drawing.Point(792, 32);
            this.Publicacion_btnAgregar.Name = "Publicacion_btnAgregar";
            this.Publicacion_btnAgregar.Size = new System.Drawing.Size(148, 30);
            this.Publicacion_btnAgregar.TabIndex = 14;
            this.Publicacion_btnAgregar.Text = "Agregar";
            this.Publicacion_btnAgregar.UseVisualStyleBackColor = true;
            this.Publicacion_btnAgregar.Click += new System.EventHandler(this.publicacion_btnAgregarClick);
            // 
            // Publicacion_btnBorrar
            // 
            this.Publicacion_btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publicacion_btnBorrar.Location = new System.Drawing.Point(792, 70);
            this.Publicacion_btnBorrar.Name = "Publicacion_btnBorrar";
            this.Publicacion_btnBorrar.Size = new System.Drawing.Size(148, 27);
            this.Publicacion_btnBorrar.TabIndex = 15;
            this.Publicacion_btnBorrar.Text = "Borrar";
            this.Publicacion_btnBorrar.UseVisualStyleBackColor = true;
            this.Publicacion_btnBorrar.Click += new System.EventHandler(this.publicacion_btnBorrarClick);
            // 
            // Publicacion_lblTomo
            // 
            this.Publicacion_lblTomo.AutoSize = true;
            this.Publicacion_lblTomo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publicacion_lblTomo.Location = new System.Drawing.Point(519, 60);
            this.Publicacion_lblTomo.Name = "Publicacion_lblTomo";
            this.Publicacion_lblTomo.Size = new System.Drawing.Size(49, 20);
            this.Publicacion_lblTomo.TabIndex = 12;
            this.Publicacion_lblTomo.Text = "Tomo";
            // 
            // Publicacion_textBox_Tomo
            // 
            this.Publicacion_textBox_Tomo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publicacion_textBox_Tomo.Location = new System.Drawing.Point(609, 60);
            this.Publicacion_textBox_Tomo.Name = "Publicacion_textBox_Tomo";
            this.Publicacion_textBox_Tomo.Size = new System.Drawing.Size(152, 26);
            this.Publicacion_textBox_Tomo.TabIndex = 13;
            // 
            // tabsFrmStock
            // 
            this.tabsFrmStock.Controls.Add(this.tabPage_Publicaciones);
            this.tabsFrmStock.Controls.Add(this.tabPage_Cartas);
            this.tabsFrmStock.Controls.Add(this.tabPage_Stock);
            this.tabsFrmStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabsFrmStock.Location = new System.Drawing.Point(0, 59);
            this.tabsFrmStock.Name = "tabsFrmStock";
            this.tabsFrmStock.SelectedIndex = 0;
            this.tabsFrmStock.Size = new System.Drawing.Size(956, 610);
            this.tabsFrmStock.TabIndex = 30;
            this.tabsFrmStock.Click += new System.EventHandler(this.tabStock_Click);
            // 
            // tabPage_Publicaciones
            // 
            this.tabPage_Publicaciones.Controls.Add(this.CmboBxPublis_Barcos);
            this.tabPage_Publicaciones.Controls.Add(this.CmboBxPublis_Clientes);
            this.tabPage_Publicaciones.Controls.Add(this.label1);
            this.tabPage_Publicaciones.Controls.Add(this.Publicacion_lblBarcos);
            this.tabPage_Publicaciones.Controls.Add(this.Publicacion_lblClientes);
            this.tabPage_Publicaciones.Controls.Add(this.lstBoxPublicaciones_Tipo);
            this.tabPage_Publicaciones.Controls.Add(this.publicaciones_lblTipo);
            this.tabPage_Publicaciones.Controls.Add(this.Publicacion_textBox_Cantidad);
            this.tabPage_Publicaciones.Controls.Add(this.label2);
            this.tabPage_Publicaciones.Controls.Add(this.Publicacion_btnBorrar);
            this.tabPage_Publicaciones.Controls.Add(this.Publicacion_textBox_Tomo);
            this.tabPage_Publicaciones.Controls.Add(this.Publicacion_lblTomo);
            this.tabPage_Publicaciones.Controls.Add(this.Publicacion_btnAgregar);
            this.tabPage_Publicaciones.Controls.Add(this.Publicacion_textBox_Edicion);
            this.tabPage_Publicaciones.Controls.Add(this.tabPublicacion_dtgv);
            this.tabPage_Publicaciones.Controls.Add(this.Publicacion_textBox_Codigo);
            this.tabPage_Publicaciones.Controls.Add(this.Publicacion_textBox_Editor);
            this.tabPage_Publicaciones.Controls.Add(this.Publicacion_lblEdicion);
            this.tabPage_Publicaciones.Controls.Add(this.Publicacion_lblEditor);
            this.tabPage_Publicaciones.Controls.Add(this.Publicacion_lblCodigo);
            this.tabPage_Publicaciones.Controls.Add(this.Publicacion_lblTitulo);
            this.tabPage_Publicaciones.Controls.Add(this.Publicacion_textBox_Titulo);
            this.tabPage_Publicaciones.Location = new System.Drawing.Point(4, 29);
            this.tabPage_Publicaciones.Name = "tabPage_Publicaciones";
            this.tabPage_Publicaciones.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Publicaciones.Size = new System.Drawing.Size(948, 577);
            this.tabPage_Publicaciones.TabIndex = 0;
            this.tabPage_Publicaciones.Text = "Publicaciones";
            this.tabPage_Publicaciones.UseVisualStyleBackColor = true;
            // 
            // CmboBxPublis_Barcos
            // 
            this.CmboBxPublis_Barcos.FormattingEnabled = true;
            this.CmboBxPublis_Barcos.Location = new System.Drawing.Point(609, 98);
            this.CmboBxPublis_Barcos.Name = "CmboBxPublis_Barcos";
            this.CmboBxPublis_Barcos.Size = new System.Drawing.Size(152, 28);
            this.CmboBxPublis_Barcos.TabIndex = 28;
            // 
            // CmboBxPublis_Clientes
            // 
            this.CmboBxPublis_Clientes.FormattingEnabled = true;
            this.CmboBxPublis_Clientes.Location = new System.Drawing.Point(340, 100);
            this.CmboBxPublis_Clientes.Name = "CmboBxPublis_Clientes";
            this.CmboBxPublis_Clientes.Size = new System.Drawing.Size(156, 28);
            this.CmboBxPublis_Clientes.TabIndex = 27;
            this.CmboBxPublis_Clientes.SelectedValueChanged += new System.EventHandler(this.CmboBoxPublicacionesClientes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(496, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 26;
            // 
            // Publicacion_lblBarcos
            // 
            this.Publicacion_lblBarcos.AutoSize = true;
            this.Publicacion_lblBarcos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publicacion_lblBarcos.Location = new System.Drawing.Point(519, 98);
            this.Publicacion_lblBarcos.Name = "Publicacion_lblBarcos";
            this.Publicacion_lblBarcos.Size = new System.Drawing.Size(59, 20);
            this.Publicacion_lblBarcos.TabIndex = 18;
            this.Publicacion_lblBarcos.Text = "Barcos";
            // 
            // Publicacion_lblClientes
            // 
            this.Publicacion_lblClientes.AutoSize = true;
            this.Publicacion_lblClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publicacion_lblClientes.Location = new System.Drawing.Point(266, 98);
            this.Publicacion_lblClientes.Name = "Publicacion_lblClientes";
            this.Publicacion_lblClientes.Size = new System.Drawing.Size(66, 20);
            this.Publicacion_lblClientes.TabIndex = 16;
            this.Publicacion_lblClientes.Text = "Clientes";
            // 
            // lstBoxPublicaciones_Tipo
            // 
            this.lstBoxPublicaciones_Tipo.FormattingEnabled = true;
            this.lstBoxPublicaciones_Tipo.ItemHeight = 20;
            this.lstBoxPublicaciones_Tipo.Location = new System.Drawing.Point(91, 98);
            this.lstBoxPublicaciones_Tipo.Name = "lstBoxPublicaciones_Tipo";
            this.lstBoxPublicaciones_Tipo.Size = new System.Drawing.Size(162, 24);
            this.lstBoxPublicaciones_Tipo.TabIndex = 5;
            // 
            // publicaciones_lblTipo
            // 
            this.publicaciones_lblTipo.AutoSize = true;
            this.publicaciones_lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publicaciones_lblTipo.Location = new System.Drawing.Point(24, 98);
            this.publicaciones_lblTipo.Name = "publicaciones_lblTipo";
            this.publicaciones_lblTipo.Size = new System.Drawing.Size(39, 20);
            this.publicaciones_lblTipo.TabIndex = 4;
            this.publicaciones_lblTipo.Text = "Tipo";
            // 
            // Publicacion_textBox_Cantidad
            // 
            this.Publicacion_textBox_Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Publicacion_textBox_Cantidad.Location = new System.Drawing.Point(609, 24);
            this.Publicacion_textBox_Cantidad.Name = "Publicacion_textBox_Cantidad";
            this.Publicacion_textBox_Cantidad.Size = new System.Drawing.Size(152, 26);
            this.Publicacion_textBox_Cantidad.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(519, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cantidad";
            // 
            // tabPage_Cartas
            // 
            this.tabPage_Cartas.Controls.Add(this.CmboBxCartas_Barcos);
            this.tabPage_Cartas.Controls.Add(this.CmboBxCartas_Clientes);
            this.tabPage_Cartas.Controls.Add(this.Cartas_lblBarcos);
            this.tabPage_Cartas.Controls.Add(this.Cartas_lblClientes);
            this.tabPage_Cartas.Controls.Add(this.Cartas_txtBoxFechaCorreccion);
            this.tabPage_Cartas.Controls.Add(this.Cartas_txtBoxCantidad);
            this.tabPage_Cartas.Controls.Add(this.Cartas_lblCantidad);
            this.tabPage_Cartas.Controls.Add(this.Cartas_lblFechaCorreccion);
            this.tabPage_Cartas.Controls.Add(this.Cartas_btnBorrar);
            this.tabPage_Cartas.Controls.Add(this.Cartas_btnAgregar);
            this.tabPage_Cartas.Controls.Add(this.Cartas_txtBoxEdicion);
            this.tabPage_Cartas.Controls.Add(this.tabCartas_dtgv);
            this.tabPage_Cartas.Controls.Add(this.Cartas_txtBoxCodigo);
            this.tabPage_Cartas.Controls.Add(this.Cartas_txtBoxEditor);
            this.tabPage_Cartas.Controls.Add(this.Cartas_lblEdicion);
            this.tabPage_Cartas.Controls.Add(this.Cartas_lblEditor);
            this.tabPage_Cartas.Controls.Add(this.Cartas_lblCodigo);
            this.tabPage_Cartas.Controls.Add(this.Cartas_lblTitulo);
            this.tabPage_Cartas.Controls.Add(this.Cartas_txtBoxTitulo);
            this.tabPage_Cartas.Location = new System.Drawing.Point(4, 29);
            this.tabPage_Cartas.Name = "tabPage_Cartas";
            this.tabPage_Cartas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Cartas.Size = new System.Drawing.Size(948, 577);
            this.tabPage_Cartas.TabIndex = 1;
            this.tabPage_Cartas.Text = "Cartas";
            this.tabPage_Cartas.UseVisualStyleBackColor = true;
            // 
            // CmboBxCartas_Barcos
            // 
            this.CmboBxCartas_Barcos.FormattingEnabled = true;
            this.CmboBxCartas_Barcos.Location = new System.Drawing.Point(576, 107);
            this.CmboBxCartas_Barcos.Name = "CmboBxCartas_Barcos";
            this.CmboBxCartas_Barcos.Size = new System.Drawing.Size(169, 28);
            this.CmboBxCartas_Barcos.TabIndex = 25;
            // 
            // CmboBxCartas_Clientes
            // 
            this.CmboBxCartas_Clientes.FormattingEnabled = true;
            this.CmboBxCartas_Clientes.Location = new System.Drawing.Point(324, 104);
            this.CmboBxCartas_Clientes.Name = "CmboBxCartas_Clientes";
            this.CmboBxCartas_Clientes.Size = new System.Drawing.Size(170, 28);
            this.CmboBxCartas_Clientes.TabIndex = 24;
            this.CmboBxCartas_Clientes.SelectedValueChanged += new System.EventHandler(this.CmboBxCartasClientes_Click);
            // 
            // Cartas_lblBarcos
            // 
            this.Cartas_lblBarcos.AutoSize = true;
            this.Cartas_lblBarcos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cartas_lblBarcos.Location = new System.Drawing.Point(511, 106);
            this.Cartas_lblBarcos.Name = "Cartas_lblBarcos";
            this.Cartas_lblBarcos.Size = new System.Drawing.Size(59, 20);
            this.Cartas_lblBarcos.TabIndex = 22;
            this.Cartas_lblBarcos.Text = "Barcos";
            // 
            // Cartas_lblClientes
            // 
            this.Cartas_lblClientes.AutoSize = true;
            this.Cartas_lblClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cartas_lblClientes.Location = new System.Drawing.Point(252, 106);
            this.Cartas_lblClientes.Name = "Cartas_lblClientes";
            this.Cartas_lblClientes.Size = new System.Drawing.Size(66, 20);
            this.Cartas_lblClientes.TabIndex = 20;
            this.Cartas_lblClientes.Text = "Clientes";
            // 
            // Cartas_txtBoxFechaCorreccion
            // 
            this.Cartas_txtBoxFechaCorreccion.Location = new System.Drawing.Point(526, 55);
            this.Cartas_txtBoxFechaCorreccion.Name = "Cartas_txtBoxFechaCorreccion";
            this.Cartas_txtBoxFechaCorreccion.Size = new System.Drawing.Size(219, 26);
            this.Cartas_txtBoxFechaCorreccion.TabIndex = 12;
            // 
            // Cartas_txtBoxCantidad
            // 
            this.Cartas_txtBoxCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cartas_txtBoxCantidad.Location = new System.Drawing.Point(89, 104);
            this.Cartas_txtBoxCantidad.Name = "Cartas_txtBoxCantidad";
            this.Cartas_txtBoxCantidad.Size = new System.Drawing.Size(142, 26);
            this.Cartas_txtBoxCantidad.TabIndex = 5;
            // 
            // Cartas_lblCantidad
            // 
            this.Cartas_lblCantidad.AutoSize = true;
            this.Cartas_lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cartas_lblCantidad.Location = new System.Drawing.Point(10, 107);
            this.Cartas_lblCantidad.Name = "Cartas_lblCantidad";
            this.Cartas_lblCantidad.Size = new System.Drawing.Size(73, 20);
            this.Cartas_lblCantidad.TabIndex = 4;
            this.Cartas_lblCantidad.Text = "Cantidad";
            // 
            // Cartas_lblFechaCorreccion
            // 
            this.Cartas_lblFechaCorreccion.AutoSize = true;
            this.Cartas_lblFechaCorreccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cartas_lblFechaCorreccion.Location = new System.Drawing.Point(522, 32);
            this.Cartas_lblFechaCorreccion.Name = "Cartas_lblFechaCorreccion";
            this.Cartas_lblFechaCorreccion.Size = new System.Drawing.Size(156, 20);
            this.Cartas_lblFechaCorreccion.TabIndex = 11;
            this.Cartas_lblFechaCorreccion.Text = "Fecha de Corrección";
            // 
            // Cartas_btnBorrar
            // 
            this.Cartas_btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cartas_btnBorrar.Location = new System.Drawing.Point(771, 62);
            this.Cartas_btnBorrar.Name = "Cartas_btnBorrar";
            this.Cartas_btnBorrar.Size = new System.Drawing.Size(148, 27);
            this.Cartas_btnBorrar.TabIndex = 14;
            this.Cartas_btnBorrar.Text = "Borrar";
            this.Cartas_btnBorrar.UseVisualStyleBackColor = true;
            this.Cartas_btnBorrar.Click += new System.EventHandler(this.cartas_btnBorrarClick);
            // 
            // Cartas_btnAgregar
            // 
            this.Cartas_btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cartas_btnAgregar.Location = new System.Drawing.Point(771, 23);
            this.Cartas_btnAgregar.Name = "Cartas_btnAgregar";
            this.Cartas_btnAgregar.Size = new System.Drawing.Size(148, 30);
            this.Cartas_btnAgregar.TabIndex = 13;
            this.Cartas_btnAgregar.Text = "Agregar";
            this.Cartas_btnAgregar.UseVisualStyleBackColor = true;
            this.Cartas_btnAgregar.Click += new System.EventHandler(this.cartas_btnAgregarClick);
            // 
            // Cartas_txtBoxEdicion
            // 
            this.Cartas_txtBoxEdicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cartas_txtBoxEdicion.Location = new System.Drawing.Point(91, 63);
            this.Cartas_txtBoxEdicion.Name = "Cartas_txtBoxEdicion";
            this.Cartas_txtBoxEdicion.Size = new System.Drawing.Size(142, 26);
            this.Cartas_txtBoxEdicion.TabIndex = 3;
            // 
            // tabCartas_dtgv
            // 
            this.tabCartas_dtgv.AllowUserToAddRows = false;
            this.tabCartas_dtgv.AllowUserToDeleteRows = false;
            this.tabCartas_dtgv.AllowUserToResizeColumns = false;
            this.tabCartas_dtgv.AllowUserToResizeRows = false;
            this.tabCartas_dtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tabCartas_dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabCartas_dtgv.Location = new System.Drawing.Point(9, 157);
            this.tabCartas_dtgv.Name = "tabCartas_dtgv";
            this.tabCartas_dtgv.Size = new System.Drawing.Size(931, 318);
            this.tabCartas_dtgv.TabIndex = 16;
            // 
            // Cartas_txtBoxCodigo
            // 
            this.Cartas_txtBoxCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cartas_txtBoxCodigo.Location = new System.Drawing.Point(91, 26);
            this.Cartas_txtBoxCodigo.Name = "Cartas_txtBoxCodigo";
            this.Cartas_txtBoxCodigo.Size = new System.Drawing.Size(140, 26);
            this.Cartas_txtBoxCodigo.TabIndex = 1;
            // 
            // Cartas_txtBoxEditor
            // 
            this.Cartas_txtBoxEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cartas_txtBoxEditor.Location = new System.Drawing.Point(309, 63);
            this.Cartas_txtBoxEditor.Name = "Cartas_txtBoxEditor";
            this.Cartas_txtBoxEditor.Size = new System.Drawing.Size(185, 26);
            this.Cartas_txtBoxEditor.TabIndex = 10;
            // 
            // Cartas_lblEdicion
            // 
            this.Cartas_lblEdicion.AutoSize = true;
            this.Cartas_lblEdicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cartas_lblEdicion.Location = new System.Drawing.Point(13, 63);
            this.Cartas_lblEdicion.Name = "Cartas_lblEdicion";
            this.Cartas_lblEdicion.Size = new System.Drawing.Size(61, 20);
            this.Cartas_lblEdicion.TabIndex = 2;
            this.Cartas_lblEdicion.Text = "Edicion";
            // 
            // Cartas_lblEditor
            // 
            this.Cartas_lblEditor.AutoSize = true;
            this.Cartas_lblEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cartas_lblEditor.Location = new System.Drawing.Point(252, 63);
            this.Cartas_lblEditor.Name = "Cartas_lblEditor";
            this.Cartas_lblEditor.Size = new System.Drawing.Size(51, 20);
            this.Cartas_lblEditor.TabIndex = 9;
            this.Cartas_lblEditor.Text = "Editor";
            // 
            // Cartas_lblCodigo
            // 
            this.Cartas_lblCodigo.AutoSize = true;
            this.Cartas_lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cartas_lblCodigo.Location = new System.Drawing.Point(11, 30);
            this.Cartas_lblCodigo.Name = "Cartas_lblCodigo";
            this.Cartas_lblCodigo.Size = new System.Drawing.Size(63, 20);
            this.Cartas_lblCodigo.TabIndex = 0;
            this.Cartas_lblCodigo.Text = "Código:";
            // 
            // Cartas_lblTitulo
            // 
            this.Cartas_lblTitulo.AutoSize = true;
            this.Cartas_lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cartas_lblTitulo.Location = new System.Drawing.Point(252, 29);
            this.Cartas_lblTitulo.Name = "Cartas_lblTitulo";
            this.Cartas_lblTitulo.Size = new System.Drawing.Size(51, 20);
            this.Cartas_lblTitulo.TabIndex = 7;
            this.Cartas_lblTitulo.Text = "Titulo:";
            // 
            // Cartas_txtBoxTitulo
            // 
            this.Cartas_txtBoxTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cartas_txtBoxTitulo.Location = new System.Drawing.Point(309, 26);
            this.Cartas_txtBoxTitulo.Name = "Cartas_txtBoxTitulo";
            this.Cartas_txtBoxTitulo.Size = new System.Drawing.Size(185, 26);
            this.Cartas_txtBoxTitulo.TabIndex = 8;
            // 
            // tabPage_Stock
            // 
            this.tabPage_Stock.Controls.Add(this.tabStock_PublicacionDtgv);
            this.tabPage_Stock.Controls.Add(this.tabStock_CartasDtgv);
            this.tabPage_Stock.Controls.Add(this.menuStrip1);
            this.tabPage_Stock.Location = new System.Drawing.Point(4, 29);
            this.tabPage_Stock.Name = "tabPage_Stock";
            this.tabPage_Stock.Size = new System.Drawing.Size(948, 577);
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
            this.tabStock_PublicacionDtgv.Size = new System.Drawing.Size(932, 234);
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
            this.tabStock_CartasDtgv.Location = new System.Drawing.Point(6, 325);
            this.tabStock_CartasDtgv.Name = "tabStock_CartasDtgv";
            this.tabStock_CartasDtgv.Size = new System.Drawing.Size(932, 236);
            this.tabStock_CartasDtgv.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(948, 4);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VistaForm.Properties.Resources.MSLTD__2_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(956, 62);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 607);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabsFrmStock);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.form_Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabPublicacion_dtgv)).EndInit();
            this.tabsFrmStock.ResumeLayout(false);
            this.tabPage_Publicaciones.ResumeLayout(false);
            this.tabPage_Publicaciones.PerformLayout();
            this.tabPage_Cartas.ResumeLayout(false);
            this.tabPage_Cartas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabCartas_dtgv)).EndInit();
            this.tabPage_Stock.ResumeLayout(false);
            this.tabPage_Stock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabStock_PublicacionDtgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabStock_CartasDtgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView tabPublicacion_dtgv;
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
    }
}

