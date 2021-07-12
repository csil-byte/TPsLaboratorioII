using System.Collections.Generic;
using System.Windows.Forms;
using Entidades;


namespace VistaConsola {
    public class Stock_Dtgv<T, T2, T3> where T : Publicacion where T2 : Carta where T3 : Barco {
        public void Add(DataGridView dataGridView, List<T> lista) {
            var bindingSource1 = new BindingSource { DataSource = lista };
            dataGridView.DataSource = bindingSource1;
        }

        public void Add(DataGridView dataGridView, List<T2> lista) {
            var bindingSource1 = new BindingSource { DataSource = lista };
            dataGridView.DataSource = bindingSource1;
            dataGridView.Refresh();
        }

        public void Add(DataGridView dataGridView, List<T3> lista) {
            var bindingSource1 = new BindingSource { DataSource = lista };
            dataGridView.DataSource = bindingSource1;
        }
    }
}
