using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer;
using Data_Layer;
using System.Data.SqlClient;

namespace ProjectPCS
{
    public partial class masterSupplier : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        ConnectionDB db = new ConnectionDB();
        viewMasterSupplier f;
        SqlDataAdapter da;

        BindingSource bss = new BindingSource();

        public masterSupplier(viewMasterSupplier f)
        {
            InitializeComponent();

            con = new SqlConnection(db.GetConnection());
            this.f = f;
        }

        //CLEAR SCREEN
        private void clear()
        {
            tb_supplier.Clear();
            tb_nama.Clear();
            tb_alamat.Clear();
            tb_hp.Clear();
            tb_kota.Clear();
            tb_bank.Clear();
            tb_namanpwp.Clear();
            tb_alamatnpwp.Clear();
            tb_nonpwp.Clear();
            tb_email.Clear();
            tb_note.Clear();


            btn_Add.Enabled = true;
            btn_Edit.Enabled = false;
            tb_supplier.Focus();
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewMasterSupplier f = new viewMasterSupplier();
            f.ShowDialog();
        }

        private void masterSupplier_Load(object sender, EventArgs e)
        {
            String sql = "Select * from m_supplier";
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            bss.DataSource = dt;

            tb_supplier.DataBindings.Add(new Binding("Text", bss, "P_ID"));
            tb_nama.DataBindings.Add(new Binding("Text", bss, "NAMA"));
            tb_alamat.DataBindings.Add(new Binding("Text", bss, "ALAMAT"));
            tb_kota.DataBindings.Add(new Binding("Text", bss, "KOTA"));
            tb_hp.DataBindings.Add(new Binding("Text", bss, "TELP_HP"));
            tb_nonpwp.DataBindings.Add(new Binding("Text", bss, "NPWP"));
            tb_namanpwp.DataBindings.Add(new Binding("Text", bss, "NAMA_NPWP"));
            tb_alamatnpwp.DataBindings.Add(new Binding("Text", bss, "ALAMAT_NPW"));
            tb_email.DataBindings.Add(new Binding("Text", bss, "EMAIL"));
            tb_bank.DataBindings.Add(new Binding("Text", bss, "BANK"));
            tb_note.DataBindings.Add(new Binding("Text", bss, "NOTE"));
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_nama.Text == "" || tb_kota.Text == "")
                {
                    MessageBox.Show("REQUIRED MISSING FIELD!", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                Variables_Supplier obj = new Variables_Supplier();
                obj.idSupplier = tb_supplier.Text;
                obj.namaSupplier = tb_nama.Text;
                obj.alamatSupplier = tb_alamat.Text;
                obj.kotaSupplier = tb_kota.Text;
                obj.TelpHP_Supplier = tb_hp.Text;
                obj.npwpSupplier = tb_nonpwp.Text;
                obj.namanpwpSupplier = tb_namanpwp.Text;
                obj.alamatnpwpSupplier = tb_alamatnpwp.Text;
                obj.emailSupplier = tb_email.Text;
                obj.bankSupplier = tb_bank.Text;
                obj.noteSupplier = tb_note.Text;

                SupplierFunction sf = new SupplierFunction();
                sf.add(obj);

                MessageBox.Show("Data Supplier Berhasil Disimpan", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                f.LoadRecords();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_nama.Text == "" || tb_kota.Text == "")
                {
                    MessageBox.Show("REQUIRED MISSING FIELD!", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                Variables_Supplier obj = new Variables_Supplier();
                obj.idSupplier = tb_supplier.Text;
                obj.namaSupplier = tb_nama.Text;
                obj.alamatSupplier = tb_alamat.Text;
                obj.kotaSupplier = tb_kota.Text;
                obj.TelpHP_Supplier = tb_hp.Text;
                obj.npwpSupplier = tb_nonpwp.Text;
                obj.namanpwpSupplier = tb_namanpwp.Text;
                obj.alamatnpwpSupplier = tb_alamatnpwp.Text;
                obj.emailSupplier = tb_email.Text;
                obj.bankSupplier = tb_bank.Text;
                obj.noteSupplier = tb_note.Text;

                SupplierFunction sf = new SupplierFunction();
                sf.add(obj);

                MessageBox.Show("Data Supplier Berhasil Diupdate", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                f.LoadRecords();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainHome f = new mainHome();
            f.Show();
        }

        private void btn_Top_Click(object sender, EventArgs e)
        {
            bss.MoveFirst();
        }

        private void btn_Prev_Click(object sender, EventArgs e)
        {
            bss.MovePrevious();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            bss.MoveNext();
        }

        private void btn_Bottom_Click(object sender, EventArgs e)
        {
            bss.MoveLast();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {

        }
    }
}
