using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectPCS
{
    public partial class masterBarang : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        ConnectionDB db = new ConnectionDB();
        viewMasterBarang f;

        public masterBarang(viewMasterBarang f)
        {
            InitializeComponent();

            con = new SqlConnection(db.GetConnection());
            this.f = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewMasterBarang f = new viewMasterBarang();
            f.ShowDialog();
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
            
        }

        private void btn_Prev_Click(object sender, EventArgs e)
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
            tb_KodeBarang.Clear();
            tb_namaBarang.Clear();
            tb_partNumber.Clear();
            tb_unit.Clear();
            tb_PN1.Clear();
            tb_unitPrice.Clear();
            tb_stamping.Clear();
            tb_persamaan.Clear();
            tb_dataFisik.Clear();
            tb_Note.Clear();

            btn_Add.Enabled = true;
            btn_Edit.Enabled = false;
            tb_KodeBarang.Focus();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_KodeBarang.Text == "" || tb_namaBarang.Text == "" || tb_unitPrice.Text == "" || tb_unit.Text == "")
                {
                    MessageBox.Show("REQUIRED MISSING FIELD!", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                con.Open();
                cmd = new SqlCommand("INSERT INTO m_barang (KODE, PART_NO, DESCRIPTION, UNIT_PRICE, UNIT, STAMPING, DATA_FISIK, PERSAMAAN, PN1, MERK1, MERK2, MERK3, KETERANGAN) values (@kode, @part_no, @description, @unit_price, @unit, @stamping, @data_fisik, @persamaan, @pn1, @merk1, @merk2, @merk3, @keterangan)", con);
                cmd.Parameters.AddWithValue("@kode", tb_KodeBarang.Text);
                cmd.Parameters.AddWithValue("@part_no", tb_partNumber.Text);
                cmd.Parameters.AddWithValue("@description", tb_namaBarang.Text);
                cmd.Parameters.AddWithValue("@unit_price", tb_unitPrice.Text);
                cmd.Parameters.AddWithValue("@unit", tb_unit.Text);
                cmd.Parameters.AddWithValue("@stamping", tb_stamping.Text);
                cmd.Parameters.AddWithValue("@data_fisik", tb_dataFisik.Text);
                cmd.Parameters.AddWithValue("@persamaan", tb_persamaan.Text);
                cmd.Parameters.AddWithValue("@pn1", tb_PN1.Text);
                cmd.Parameters.AddWithValue("@merk1", tb_merk1.Text);
                cmd.Parameters.AddWithValue("@merk2", tb_merk2.Text);
                cmd.Parameters.AddWithValue("@merk3", tb_merk3.Text);
                cmd.Parameters.AddWithValue("@keterangan", tb_Note.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Barang Berhasil Disimpan", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (tb_KodeBarang.Text == "" || tb_namaBarang.Text == "" || tb_unitPrice.Text == "" || tb_unit.Text == "")
                {
                    MessageBox.Show("REQUIRED MISSING FIELD!", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (MessageBox.Show("Ingin Mengupdate Data ini ?", "MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("UPDATE m_barang SET PART_NO = @part_no, DESCRIPTION = @description, UNIT_PRICE = @unit_price, UNIT = @unit, STAMPING = @stamping, DATA_FISIK = @data_fisik, PERSAMAAN = @persamaan, PN1 = @pn1, MERK1 = @merk1, MERK2 = @merk2, MERK3 = @merk3, KETERANGAN = @keterangan WHERE KODE = @kode", con);
                    cmd.Parameters.AddWithValue("@kode", tb_KodeBarang.Text);
                    cmd.Parameters.AddWithValue("@part_no", tb_partNumber.Text);
                    cmd.Parameters.AddWithValue("@description", tb_namaBarang.Text);
                    cmd.Parameters.AddWithValue("@unit_price", tb_unitPrice.Text);
                    cmd.Parameters.AddWithValue("@unit", tb_unit.Text);
                    cmd.Parameters.AddWithValue("@stamping", tb_stamping.Text);
                    cmd.Parameters.AddWithValue("@data_fisik", tb_dataFisik.Text);
                    cmd.Parameters.AddWithValue("@persamaan", tb_persamaan.Text);
                    cmd.Parameters.AddWithValue("@pn1", tb_PN1.Text);
                    cmd.Parameters.AddWithValue("@merk1", tb_merk1.Text);
                    cmd.Parameters.AddWithValue("@merk2", tb_merk2.Text);
                    cmd.Parameters.AddWithValue("@merk3", tb_merk3.Text);
                    cmd.Parameters.AddWithValue("@keterangan", tb_Note.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Barang Berhasil Diupdate", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
