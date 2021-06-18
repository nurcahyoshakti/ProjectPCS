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
    public partial class mainHome : Form
    {
        public mainHome()
        {
            InitializeComponent();
        }

        private void btn_mBarang_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewMasterBarang f = new viewMasterBarang();
            f.Show();
        }

        private void btn_mPelanggan_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewMasterPelanggan f = new viewMasterPelanggan();
            f.Show();
        }

        private void btn_mSupplier_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewMasterSupplier f = new viewMasterSupplier();
            f.Show();
        }

        private void btn_mModel_Click(object sender, EventArgs e)
        {
            this.Hide();
            masterModel f = new masterModel();
            f.Show();
        }
    }
}
