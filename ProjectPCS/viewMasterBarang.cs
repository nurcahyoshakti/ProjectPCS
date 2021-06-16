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
    public partial class viewMasterBarang : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        ConnectionDB db = new ConnectionDB();

        public viewMasterBarang()
        {
            InitializeComponent();

            con = new SqlConnection(db.GetConnection());
            LoadRecords();
        }

        public void LoadRecords()
        {
            dgv_masterBarang.Rows.Clear();
            int i = 0;
            con.Open();
            cmd = new SqlCommand("SELECT * FROM m_barang", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgv_masterBarang.Rows.Add(i, dr["KODE"].ToString(), dr["PART_NO"].ToString(), dr["DESCRIPTION"].ToString(), dr["UNIT_PRICE"].ToString(), dr["UNIT"].ToString(), dr["STAMPING"].ToString(), dr["DATA_FISIK"].ToString(), dr["PERSAMAAN"].ToString(), dr["PN1"].ToString(), dr["MERK1"].ToString(), dr["MERK2"].ToString(), dr["MERK3"].ToString(), dr["KETERANGAN"].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void btn_addData_Click(object sender, EventArgs e)
        {
            masterBarang f = new masterBarang(this);
            f.btn_Add.Enabled = true;
            f.btn_Edit.Enabled = false;
            f.ShowDialog();
        }

        private void viewMasterBarang_Load(object sender, EventArgs e)
        {
            
        }

        private void dgv_masterBarang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgv_masterBarang.Columns[e.ColumnIndex].Name;

            if (colName == "column_edited")
            {
                masterBarang f = new masterBarang(this);
                f.tb_KodeBarang.Text = dgv_masterBarang.Rows[e.RowIndex].Cells[1].Value.ToString();
                f.tb_partNumber.Text = dgv_masterBarang.Rows[e.RowIndex].Cells[2].Value.ToString();
                f.tb_namaBarang.Text = dgv_masterBarang.Rows[e.RowIndex].Cells[3].Value.ToString();
                f.tb_unitPrice.Text = dgv_masterBarang.Rows[e.RowIndex].Cells[4].Value.ToString();
                f.tb_unit.Text = dgv_masterBarang.Rows[e.RowIndex].Cells[5].Value.ToString();
                f.tb_stamping.Text = dgv_masterBarang.Rows[e.RowIndex].Cells[6].Value.ToString();
                f.tb_dataFisik.Text = dgv_masterBarang.Rows[e.RowIndex].Cells[7].Value.ToString();
                f.tb_persamaan.Text = dgv_masterBarang.Rows[e.RowIndex].Cells[8].Value.ToString();
                f.tb_PN1.Text = dgv_masterBarang.Rows[e.RowIndex].Cells[9].Value.ToString();
                f.tb_merk1.Text = dgv_masterBarang.Rows[e.RowIndex].Cells[10].Value.ToString();
                f.tb_merk2.Text = dgv_masterBarang.Rows[e.RowIndex].Cells[11].Value.ToString();
                f.tb_merk3.Text = dgv_masterBarang.Rows[e.RowIndex].Cells[12].Value.ToString();
                f.tb_Note.Text = dgv_masterBarang.Rows[e.RowIndex].Cells[13].Value.ToString();
                f.tb_KodeBarang.Enabled = false;
                f.btn_Add.Enabled = false;
                f.btn_Edit.Enabled = true;
                f.ShowDialog();
            }
            else if (colName == "column_deleted")
            {
                if (MessageBox.Show("Ingin Menghapus Barang ini?", "MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM m_barang WHERE KODE = '" + dgv_masterBarang.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Barang Berhasil Dihapus !", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRecords();
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
