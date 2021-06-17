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
    public partial class viewMasterModel : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        ConnectionDB db = new ConnectionDB();

        public viewMasterModel()
        {
            InitializeComponent();
            con = new SqlConnection(db.GetConnection());
            LoadRecords();
        }

        public void LoadRecords()
        {
            dgv_masterModel.Rows.Clear();
            int i = 0;
            con.Open();
            cmd = new SqlCommand("SELECT * FROM m_model", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgv_masterModel.Rows.Add(i, dr["MODEL_ID"].ToString(), dr["DESCRIPTION"].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void btn_addData_Click(object sender, EventArgs e)
        {
            this.Hide();
            masterModel f = new masterModel(this);
            f.btn_Add.Enabled = true;
            f.btn_Edit.Enabled = false;
            f.ShowDialog();
        }

        private void dgv_masterModel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgv_masterModel.Columns[e.ColumnIndex].Name;

            if (colName == "column_edited")
            {
                masterModel f = new masterModel(this);
                f.tb_modelid.Text = dgv_masterModel.Rows[e.RowIndex].Cells[1].Value.ToString();
                f.tb_desc.Text = dgv_masterModel.Rows[e.RowIndex].Cells[2].Value.ToString();
                f.tb_modelid.Enabled = false;
                f.btn_Add.Enabled = false;
                f.btn_Edit.Enabled = true;
                f.ShowDialog();
            }
            else if (colName == "column_deleted")
            {
                if (MessageBox.Show("Ingin Menghapus Data Model ini?", "MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("DELETE FROM m_model WHERE MODEL_ID = '" + dgv_masterModel.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data Model Berhasil Dihapus !", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRecords();
                }
            }
        }
    }
}
