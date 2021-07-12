using System;
using System.Windows.Forms;
using Entidades;
using VistaConsola;


namespace VistaForm {
    public partial class Frm_Stock : Form {
        public Stock stock;
        private Stock_Dtgv<Publicacion, Carta, Barco> stock_Dtgv;
        bool flag = false;

        public Frm_Stock() {
            InitializeComponent();

        }
        /// <summary>
        /// Al cargar el form, instanciara los objetos necesarios para el funcionamiento, cargará la listbox de tabPublicaciones con los valores del enum y agregará a los datagrid las listas de publicaciones y cartas respectivamente. Cargará el combo box con la lista de clientes y sus barcos según corresponda.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Stock_Load(object sender, EventArgs e) {
            stock = Stock.GetStock();
            stock_Dtgv = new Stock_Dtgv<Publicacion, Carta, Barco>();
            cboTipo.DataSource = Enum.GetValues(typeof(Publicacion.Formato));
            stock_Dtgv.Add(tabPublicacion_dtgv, Stock.Publicaciones);
            stock_Dtgv.Add(tabCartas_dtgv, Stock.Cartas);
            Cargar_CmBoxClientesBarcos();
        }
        /// <summary>
        /// Al ingresar los datos, se agregan a la lista de publicaciones si esta no está ya agregada y se muestra en datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Publicacion_btnAgregarClick(object sender, EventArgs e) {
            try {
                if (cboTipo.SelectedIndex != -1 && CmboBxPublis_Clientes.SelectedIndex != -1 && CmboBxPublis_Barcos.SelectedIndex != -1) {
                    Publicacion publicacion1 = new Publicacion(int.Parse(Publicacion_textBox_Tomo.Text),
                    (Publicacion.Formato)cboTipo.SelectedValue,
                    Publicacion_textBox_Titulo.Text,
                    int.Parse(Publicacion_textBox_Edicion.Text), Publicacion_textBox_Editor.Text, Publicacion_textBox_Codigo.Text, ((int)nudPublicacionCantidad.Value));

                    if (!(publicacion1 is null)) {
                        if (stock + publicacion1) {
                            stock_Dtgv.Add(tabPublicacion_dtgv, Stock.Publicaciones);
                            tabPublicacion_dtgv.Refresh();

                            ControllerDAO.GuardarPublicacion(publicacion1, Controller.BuscarBarcoPorId(CmboBxPublis_Barcos.Text), false);
                            Stock.AgregarMercaderia_alBarco(publicacion1, CmboBxPublis_Clientes.Text, CmboBxPublis_Barcos.Text);
                            MessageBox.Show("Publicación agregada con éxito", "Publicación agregada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        } else {
                            if (this.flag == true) {
                                DialogResult = MessageBox.Show("Esta publicación ya se encuentra en la base de datos, se agregará 1 unidad al barco seleccionado. Favor confirmar", "Agregar unidad", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                if (DialogResult == DialogResult.OK) {
                                    ControllerDAO.GuardarPublicacion(publicacion1, Controller.BuscarBarcoPorId(CmboBxPublis_Barcos.Text), true);
                                    Stock.AgregarMercaderia_alBarco(publicacion1, CmboBxPublis_Clientes.Text, CmboBxPublis_Barcos.Text);
                                    tabPublicacion_dtgv.Refresh();
                                    this.flag = false;
                                    MessageBox.Show("La cantidad fue actualizada con éxito", "Publicación agregada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            } else {
                                DialogResult = MessageBox.Show("Esta publicación ya se encuentra en la base de datos, se agregará 1 unidad. Favor confirmar", "Agregar unidad", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                if (DialogResult == DialogResult.OK) {
                                    MessageBox.Show("La cantidad fue actualizada con éxito", "Publicación duplicada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    tabPublicacion_dtgv.Refresh();
                                }
                            }
                        }
                    }
                } else {
                    MessageBox.Show("Deberá cargar información para poder agregar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            } catch (FormatException fexe) {
                MessageBox.Show($"Deberá cargar información para poder agregar\n{fexe.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } catch (Exception exe) {
                MessageBox.Show($"Deberá cargar información para poder agregar\n{exe.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        /// <summary>
        /// Al ingresar los datos, se agregan a la lista de cartas si esta no está ya agregada y se muestra en datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cartas_btnAgregarClick(object sender, EventArgs e) {
            try {
                DateTime fecha = DateTime.Parse(Cartas_txtBoxFechaCorreccion.Text);
                Carta carta1 = new Carta(Cartas_txtBoxTitulo.Text, int.Parse(Cartas_txtBoxEdicion.Text), Cartas_txtBoxEditor.Text, Cartas_txtBoxCodigo.Text, (int)nudCartaCantidad.Value, fecha);

                if (CmboBxCartas_Clientes.SelectedIndex != -1 && CmboBxCartas_Barcos.SelectedIndex != -1) {
                    {
                        if (!(carta1 is null)) {
                            if (stock + carta1) {
                                stock_Dtgv.Add(tabCartas_dtgv, Stock.Cartas);
                                tabCartas_dtgv.Refresh();
                                MessageBox.Show("Carta agregada con éxito", "Carta agregada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ControllerDAO.GuardarCarta(carta1, Controller.BuscarBarcoPorId(CmboBxCartas_Barcos.Text), false);
                                Stock.AgregarMercaderia_alBarco(carta1, CmboBxCartas_Clientes.Text, CmboBxCartas_Barcos.Text);
                            } else {
                                if (this.flag == true) {
                                    DialogResult = MessageBox.Show("Esta publicación ya se encuentra en la base de datos, se agregará 1 unidad al barco seleccionado. Favor confirmar", "Agregar unidad", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                    if (DialogResult == DialogResult.OK) {
                                        ControllerDAO.GuardarCarta(carta1, Controller.BuscarBarcoPorId(CmboBxCartas_Barcos.Text), true);
                                        Stock.AgregarMercaderia_alBarco(carta1, CmboBxCartas_Clientes.Text, CmboBxCartas_Barcos.Text);
                                        tabCartas_dtgv.Refresh();
                                        this.flag = false;
                                        MessageBox.Show("La cantidad fue actualizada con éxito", "Publicación agregada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                } else {
                                    DialogResult = MessageBox.Show("Esta carta ya se encuentra en la base de datos, se agregará 1 unidad. Favor confirmar", "Agregar unidad", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                                    if (DialogResult == DialogResult.OK) {

                                        ControllerDAO.GuardarCarta(carta1, Controller.BuscarBarcoPorId(CmboBxCartas_Barcos.Text), true);
                                        MessageBox.Show("La cantidad fue actualizada con éxito", "Carta duplicada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        tabCartas_dtgv.Refresh();
                                    }
                                }
                            }

                        }
                    }
                } else {
                    MessageBox.Show("Deberá cargar información para poder agregar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (FormatException fexe)
            {
                MessageBox.Show($"Deberá cargar información para poder agregar\n{fexe.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception exe)
            {
                MessageBox.Show($"Deberá cargar información para poder agregar\n{exe.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        /// <summary>
        /// Vacía los textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Publicacion_btnBorrarClick(object sender, EventArgs e) {
            Publicacion_textBox_Tomo.Text = string.Empty;
            Publicacion_textBox_Titulo.Text = string.Empty;
            Publicacion_textBox_Edicion.Text = string.Empty;
            Publicacion_textBox_Editor.Text = string.Empty;
            Publicacion_textBox_Codigo.Text = string.Empty;
            nudPublicacionCantidad.Value = 1;
        }
        /// <summary>
        /// Vacía los textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cartas_btnBorrarClick(object sender, EventArgs e) {
            Cartas_txtBoxTitulo.Text = string.Empty;
            Cartas_txtBoxEdicion.Text = string.Empty;
            Cartas_txtBoxEditor.Text = string.Empty;
            Cartas_txtBoxCodigo.Text = string.Empty;
            nudCartaCantidad.Value = 1;

        }
        /// <summary>
        /// Cargará el menuStrip con la lista de clientes llamando a Load_MenuStrip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabStock_Click(object sender, EventArgs e) {
            Load_MenuStrip();
        }
        /// <summary>
        /// Agregado cada cliente al toolstripmenu para mostrar los clientes dentro de mi lista y a su vez agrego cada barco que tiene dicho cliente a sub menu dentro de cada cliente.
        /// </summary>
        private void Load_MenuStrip() {
            menuStrip1.Items.Clear();

            foreach (Clientes clientes in Stock.Clientes) {
                ToolStripMenuItem clienteMenu = new ToolStripMenuItem(clientes.Nombre);
                menuStrip1.Items.Add(clienteMenu);

                foreach (Barco barquito in clientes.barcos) {
                    ToolStripMenuItem barquitosMenu = new ToolStripMenuItem(barquito.NombreBarco, null, SubMenuClick);
                    clienteMenu.DropDownItems.Add(barquitosMenu);
                }
            }
        }
        /// <summary>
        /// Al hacer click en un barco, muestra las publicaciones y cartas que tiene.
        /// Usa 2 foreach, uno para iterar dentro de clientes, una vez ahí, itera sobre los barcos para encontrar el seleccionado en el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SubMenuClick(object sender, System.EventArgs e) {
            foreach (Clientes clientesito in Stock.Clientes) {
                foreach (Barco barquito in clientesito.barcos) {
                    if (sender.ToString() == barquito.NombreBarco) {
                        stock_Dtgv.Add(tabStock_PublicacionDtgv, barquito.publicaciones);
                        stock_Dtgv.Add(tabStock_CartasDtgv, barquito.cartas);
                    }
                }
            }
        }
        /// <summary>
        /// Itera sobre cada cliente y los agrega al dtgv de clientes y publicaciones
        /// </summary>
        private void Cargar_CmBoxClientesBarcos() {
            foreach (Clientes clientesito in Stock.Clientes) {
                CmboBxPublis_Clientes.Items.Add(clientesito.Nombre);
                CmboBxCartas_Clientes.Items.Add(clientesito.Nombre);
            }
        }
        /// <summary>
        /// Al hacer click sobre el combobox, el evento limpiará cada control y lo seteara en empty para luego cargar las opciones nuevamente, esto ayudará a evitar repeticiones si el usuario hace click varias veces.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmboBxCartasClientes_Click(object sender, EventArgs e) {
            CmboBxCartas_Barcos.Items.Clear();
            CmboBxCartas_Barcos.Text = string.Empty;

            foreach (Clientes clientesito in Stock.Clientes) {
                if (CmboBxCartas_Clientes.Text == clientesito.Nombre) {
                    foreach (Barco barquito in clientesito.barcos) {
                        CmboBxCartas_Barcos.Items.Add(barquito.NombreBarco);
                    }
                    break;
                }
            }
        }
        /// <summary>
        /// Al hacer click sobre el combobox, el evento limpiará cada control y lo seteara en empty para luego cargar las opciones nuevamente, esto ayudará a evitar repeticiones si el usuario hace click varias veces.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmboBoxPublicacionesClientes_Click(object sender, EventArgs e) {
            CmboBxPublis_Barcos.Items.Clear();
            CmboBxPublis_Barcos.Text = string.Empty;

            foreach (Clientes clientesito in Stock.Clientes) {
                if (CmboBxPublis_Clientes.Text == clientesito.Nombre) {
                    foreach (Barco barquito in clientesito.barcos) {
                        CmboBxPublis_Barcos.Items.Add(barquito.NombreBarco);
                    }
                    break;
                }
            }
        }

        /// <summary>
        /// Establecerá flag como verdadero 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmboBxPublis_Barcos_SelectedValueChanged(object sender, EventArgs e) {
            this.flag = true;
        }

        /// <summary>
        /// Establecerá flag como verdadero 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmboBxCartas_Barcos_SelectedValueChanged(object sender, EventArgs e) {
            CmboBxPublis_Barcos_SelectedValueChanged(sender, e);
        }
    }
}