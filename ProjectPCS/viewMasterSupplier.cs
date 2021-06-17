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
    public partial class viewMasterSupplier : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        ConnectionDB db = new ConnectionDB();
        public viewMasterSupplier()
        {
            InitializeComponent();
            con = new SqlConnection(db.GetConnection());
            LoadRecords();
        }

        public void LoadRecords()
        {
            dgv_masterSupplier.Rows.Clear();
            int i = 0;
            con.Open();
            cmd = new SqlCommand("SELECT * FROM m_supplier", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgv_masterSupplier.Rows.Add(i, dr["P_ID"].ToString(), dr["NAMA"].ToString(), dr["ALAMAT"].ToString(), dr["KOTA"].ToString(), dr["TELP_HP"].ToString(), dr["NPWP"].ToString(), dr["NAMA_NPWP"].ToString(), dr["ALAMAT_NPW"].ToString(), dr["EMAIL"].ToString(), dr["BANK"].ToString(), dr["NOTE"].ToString());
            }
            dr.Close();
            con.Close();
        }
        private void viewMasterSupplier_Load(object sender, EventArgs e)
        {

        }

        private void btn_addData_Click(object sender, EventArgs e)
        {
            this.Hide();
            masterSupplier f = new masterSupplier(this);
            f.btn_Add.Enabled = true;
            f.btn_Edit.Enabled = false;
            f.ShowDialog();
        }

        private void dgv_masterSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgv_masterSupplier.Columns[e.ColumnIndex].Name;

            if (colName == "column_edited")
            {
                masterSupplier f = new masterSupplier(this);
                f.tb_supplier.Text = dgv_masterSupplier.Rows[e.RowIndex].Cells[1].Value.ToString();
                f.tb_nama.Text = dgv_masterSupplier.Rows[e.RowIndex].Cells[2].Value.ToString();
                f.tb_alamat.Text = dgv_masterSupplier.Rows[e.RowIndex].Cells[3].Value.ToString();
                f.tb_kota.Text = dgv_masterSupplier.Rows[e.RowIndex].Cells[4].Value.ToString();
                f.tb_hp.Text = dgv_masterSupplier.Rows[e.RowIndex].Cells[5].Value.ToString();
                f.tb_nonpwp.Text = dgv_masterSupplier.Rows[e.RowIndex].Cells[6].Value.ToString();
                f.tb_namanpwp.Text = dgv_masterSupplier.Rows[e.RowIndex].Cells[7].Value.ToString();
                f.tb_alamatnpwp.Text = dgv_masterSupplier.Rows[e.RowIndex].Cells[8].Value.ToString();
                f.tb_email.Text = dgv_masterSupplier.Rows[e.RowIndex].Cells[9].Value.ToString();
                f.tb_bank.Text = dgv_masterSupplier.Rows[e.RowIndex].Cells[10].Value.ToString();
                f.tb_note.Text = dgv_masterSupplier.Rows[e.RowIndex].Cells[11].Value.ToString();
                f.tb_supplier.Enabled = false;
                f.btn_Add.Enabled = false;
                f.btn_Edit.Enabled = true;
                f.ShowDialog();
            }
            else if (colName == "column_deleted")
            {
                if (MessageBox.Show("Ingin Menghapus Data Pelanggan ini?", "MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM m_supplier WHERE P_ID = '" + dgv_masterSupplier.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data Pelanggan Berhasil Dihapus !", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRecords();
                }
            }
        }
    }
}
