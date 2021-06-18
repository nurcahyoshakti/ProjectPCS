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
using Data_Layer;

namespace ProjectPCS
{
    public partial class viewMasterPelanggan : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        ConnectionDB db = new ConnectionDB();

        public viewMasterPelanggan()
        {
            InitializeComponent();

            con = new SqlConnection(db.GetConnection());
            LoadRecords();
        }

        public void LoadRecords()
        {
            dgv_masterPelanggan.Rows.Clear();
            int i = 0;
            con.Open();
            cmd = new SqlCommand("SELECT * FROM m_pelanggan", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgv_masterPelanggan.Rows.Add(i, dr["P_CODE"].ToString(), dr["NAMA"].ToString(), dr["ALAMAT"].ToString(), dr["KOTA"].ToString(), dr["TELP"].ToString(), dr["NPWP"].ToString(), dr["NAMA_NPWP"].ToString(), dr["ALAMAT_NPWP"].ToString(), dr["NAMA1"].ToString(), dr["ALAMAT1"].ToString(), dr["KOTA1"].ToString(), dr["HP"].ToString(), dr["KETERANGAN"].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void btn_addData_Click(object sender, EventArgs e)
        {
            this.Hide();
            masterPelanggan f = new masterPelanggan(this);
            f.btn_Add.Enabled = true;
            f.btn_Edit.Enabled = false;
            f.ShowDialog();
        }

        private void dgv_masterPelanggan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgv_masterPelanggan.Columns[e.ColumnIndex].Name;

            if (colName == "column_edited")
            {
                masterPelanggan f = new masterPelanggan(this);
                f.tb_kode.Text = dgv_masterPelanggan.Rows[e.RowIndex].Cells[1].Value.ToString();
                f.tb_nama.Text = dgv_masterPelanggan.Rows[e.RowIndex].Cells[2].Value.ToString();
                f.tb_almt.Text = dgv_masterPelanggan.Rows[e.RowIndex].Cells[3].Value.ToString();
                f.tb_kota.Text = dgv_masterPelanggan.Rows[e.RowIndex].Cells[4].Value.ToString();
                f.tb_telpn.Text = dgv_masterPelanggan.Rows[e.RowIndex].Cells[5].Value.ToString();
                f.tb_npwp.Text = dgv_masterPelanggan.Rows[e.RowIndex].Cells[6].Value.ToString();
                f.tb_nmnpwp.Text = dgv_masterPelanggan.Rows[e.RowIndex].Cells[7].Value.ToString();
                f.tb_almtnpwp.Text = dgv_masterPelanggan.Rows[e.RowIndex].Cells[8].Value.ToString();
                f.tb_nama2.Text = dgv_masterPelanggan.Rows[e.RowIndex].Cells[9].Value.ToString();
                f.tb_almt2.Text = dgv_masterPelanggan.Rows[e.RowIndex].Cells[10].Value.ToString();
                f.tb_kota2.Text = dgv_masterPelanggan.Rows[e.RowIndex].Cells[11].Value.ToString();
                f.tb_hp.Text = dgv_masterPelanggan.Rows[e.RowIndex].Cells[12].Value.ToString();
                f.tb_note.Text = dgv_masterPelanggan.Rows[e.RowIndex].Cells[13].Value.ToString();
                f.tb_kode.Enabled = false;
                f.btn_Add.Enabled = false;
                f.btn_Edit.Enabled = true;
                f.ShowDialog();
            }
            else if (colName == "column_deleted")
            {
                if (MessageBox.Show("Ingin Menghapus Data Pelanggan ini?", "MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM m_pelanggan WHERE P_CODE = '" + dgv_masterPelanggan.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data Pelanggan Berhasil Dihapus !", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRecords();
                }
            }
        }
    }
}
