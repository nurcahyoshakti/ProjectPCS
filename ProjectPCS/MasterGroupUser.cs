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
    public partial class masterGroupUser : Form
    {
        public masterGroupUser()
        {
            InitializeComponent();
        }

        private void btn_Prev_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainHome f = new mainHome();
            f.Show();
        }
    }
}
