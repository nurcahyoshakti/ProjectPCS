using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPCS
{
    public partial class masterSupplier : Form
    {
        public masterSupplier()
        {
            InitializeComponent();
        }

        private void m_supplierBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.m_supplierBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uASDataSet);

        }

        private void masterSupplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uASDataSet.m_supplier' table. You can move, or remove it, as needed.
            this.m_supplierTableAdapter.Fill(this.uASDataSet.m_supplier);

        }

        private void nAMALabel_Click(object sender, EventArgs e)
        {

        }

        private void btn_Prev_Click(object sender, EventArgs e)
        {
            m_supplierBindingSource.MovePrevious();
            this.Text = "Pos=" + m_supplierBindingSource.Position;
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            m_supplierBindingSource.MoveNext();
            this.Text = "Pos=" + m_supplierBindingSource.Position;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainHome f = new mainHome();
            f.Show();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            this.m_supplierBindingSource.AddNew();
        }
    }
}
