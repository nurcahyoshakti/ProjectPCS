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
    public partial class masterMerk : Form
    {
        public masterMerk()
        {
            InitializeComponent();
        }

        private void m_merkBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.m_merkBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uASDataSet);

        }

        private void masterMerk_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uASDataSet.m_merk' table. You can move, or remove it, as needed.
            this.m_merkTableAdapter.Fill(this.uASDataSet.m_merk);

        }

        private void btn_Prev_Click(object sender, EventArgs e)
        {
            m_merkBindingSource.MovePrevious();
            this.Text = "Pos=" + m_merkBindingSource.Position;
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            m_merkBindingSource.MoveNext();
            this.Text = "Pos=" + m_merkBindingSource.Position;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainHome f = new mainHome();
            f.Show();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            this.m_merkBindingSource.AddNew();
        }
    }
}
