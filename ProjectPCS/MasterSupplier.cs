using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPCS
{
    public partial class masterSupplier : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        ConnectionDB db = new ConnectionDB();
        viewMasterSupplier f;
        public masterSupplier(viewMasterSupplier f)
        {
            InitializeComponent();
            con = new SqlConnection(db.GetConnection());
            this.f = f;
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

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_nama.Text == "" || tb_kota.Text == "")
                {
                    MessageBox.Show("REQUIRED MISSING FIELD!", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                con.Open();
                cmd = new SqlCommand("INSERT INTO m_supplier (P_ID, NAMA, ALAMAT, KOTA, TELP_HP, NPWP, NAMA_NPWP, ALAMAT_NPW, EMAIL, BANK, NOTE) values (@p_id, @nama, @alamat, @kota, @telp_hp, @npwp, @nama_npwp, @alamat_npwp, @email, @bank, @note)", con);
                cmd.Parameters.AddWithValue("@p_id", tb_supplier.Text);
                cmd.Parameters.AddWithValue("@nama", tb_nama.Text);
                cmd.Parameters.AddWithValue("@alamat", tb_alamat.Text);
                cmd.Parameters.AddWithValue("@kota", tb_kota.Text);
                cmd.Parameters.AddWithValue("@telp_hp", tb_hp.Text);
                cmd.Parameters.AddWithValue("@npwp", tb_nonpwp.Text);
                cmd.Parameters.AddWithValue("@nama_npwp", tb_namanpwp.Text);
                cmd.Parameters.AddWithValue("@alamat_npwp", tb_alamatnpwp.Text);
                cmd.Parameters.AddWithValue("@email", tb_email.Text);
                cmd.Parameters.AddWithValue("@bank", tb_bank.Text);
                cmd.Parameters.AddWithValue("@note", tb_note.Text);
   
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Pelanggan Berhasil Disimpan", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                f.LoadRecords();
                clear();
            }
            catch (Exception ex)
            {
                con.Close();
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

                if (MessageBox.Show("Ingin Mengupdate Data ini ?", "MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("UPDATE m_supplier SET NAMA = @nama, ALAMAT = @alamat, KOTA = @kota, TELP_HP = @telp_hp, NPWP = @npwp, NAMA_NPWP = @nama_npwp, ALAMAT_NPW = @alamat_npwp, EMAIL = @email, BANK = @bank, NOTE = @note WHERE P_ID = @p_id", con);
                    cmd.Parameters.AddWithValue("@p_id", tb_supplier.Text);
                    cmd.Parameters.AddWithValue("@nama", tb_nama.Text);
                    cmd.Parameters.AddWithValue("@alamat", tb_alamat.Text);
                    cmd.Parameters.AddWithValue("@kota", tb_kota.Text);
                    cmd.Parameters.AddWithValue("@telp_hp", tb_hp.Text);
                    cmd.Parameters.AddWithValue("@npwp", tb_nonpwp.Text);
                    cmd.Parameters.AddWithValue("@nama_npwp", tb_namanpwp.Text);
                    cmd.Parameters.AddWithValue("@alamat_npwp", tb_alamatnpwp.Text);
                    cmd.Parameters.AddWithValue("@email", tb_email.Text);
                    cmd.Parameters.AddWithValue("@bank", tb_bank.Text);
                    cmd.Parameters.AddWithValue("@note", tb_note.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data Pelanggan Berhasil Diupdate", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    f.LoadRecords();
                    clear();
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
