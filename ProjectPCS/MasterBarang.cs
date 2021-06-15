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
    public partial class masterBarang : Form
    {
        public masterBarang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void m_barangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.m_barangBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uASDataSet);

        }

        private void masterBarang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uASDataSet.m_barang' table. You can move, or remove it, as needed.
            this.m_barangTableAdapter.Fill(this.uASDataSet.m_barang);

        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            m_barangBindingSource.MoveNext();
            this.Text = "Pos=" + m_barangBindingSource.Position;
        }

        private void btn_Prev_Click(object sender, EventArgs e)
        {
            m_barangBindingSource.MovePrevious();
            this.Text = "Pos=" + m_barangBindingSource.Position;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainHome f = new mainHome();
            f.Show();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            this.m_barangBindingSource.AddNew();
            //this.Validate();
            //this.m_barangBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.uASDataSet);
        }
    }
}
