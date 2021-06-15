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

        private void mainHome_Load(object sender, EventArgs e)
        {

        }

        private void btn_mBarang_Click(object sender, EventArgs e)
        {
            this.Hide();
            masterBarang f = new masterBarang();
            f.Show();
        }

        private void btn_mPelanggan_Click(object sender, EventArgs e)
        {
            this.Hide();
            masterPelanggan f = new masterPelanggan();
            f.Show();
        }

        private void btn_mModel_Click(object sender, EventArgs e)
        {
            this.Hide();
            masterModel f = new masterModel();
            f.Show();
        }

        private void btn_mSupplier_Click(object sender, EventArgs e)
        {
            this.Hide();
            masterSupplier f = new masterSupplier();
            f.Show();
        }

        private void btn_mMerk_Click(object sender, EventArgs e)
        {
            this.Hide();
            masterMerk f = new masterMerk();
            f.Show();
        }

        private void btn_mKota_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_mGroupuser_Click(object sender, EventArgs e)
        {
            this.Hide();
            masterGroupUser f = new masterGroupUser();
            f.Show();
        }

        private void btn_mHakaksesgroupuser_Click(object sender, EventArgs e)
        {

        }

        private void btn_mUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            masterUsers f = new masterUsers();
            f.Show();
        }
    }
}
