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
    public partial class masterPelanggan : Form
    {
        public masterPelanggan()
        {
            InitializeComponent();
        }

        private void m_pelangganBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.m_pelangganBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uASDataSet);

        }

        private void masterPelanggan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uASDataSet.m_pelanggan' table. You can move, or remove it, as needed.
            this.m_pelangganTableAdapter.Fill(this.uASDataSet.m_pelanggan);

        }

        private void aLAMAT_NPWPTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Prev_Click(object sender, EventArgs e)
        {
            m_pelangganBindingSource.MovePrevious();
            this.Text = "Pos=" + m_pelangganBindingSource.Position;
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            m_pelangganBindingSource.MoveNext();
            this.Text = "Pos=" + m_pelangganBindingSource.Position;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainHome f = new mainHome();
            f.Show();
        }
    }
}
