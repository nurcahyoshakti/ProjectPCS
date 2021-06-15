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
    public partial class masterModel : Form
    {
        public masterModel()
        {
            InitializeComponent();
        }

        private void m_modelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.m_modelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uASDataSet);

        }

        private void m_modelBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.m_modelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uASDataSet);

        }

        private void masterModel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uASDataSet.m_model' table. You can move, or remove it, as needed.
            this.m_modelTableAdapter.Fill(this.uASDataSet.m_model);

        }

        private void btn_Prev_Click(object sender, EventArgs e)
        {
            m_modelBindingSource.MovePrevious();
            this.Text = "Pos=" + m_modelBindingSource.Position;
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            m_modelBindingSource.MoveNext();
            this.Text = "Pos=" + m_modelBindingSource.Position;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainHome f = new mainHome();
            f.Show();
        }
    }
}
