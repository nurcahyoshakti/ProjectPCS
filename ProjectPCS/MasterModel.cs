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
    public partial class masterModel : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        ConnectionDB db = new ConnectionDB();
        viewMasterModel f;
        SqlDataAdapter da;

        BindingSource bss = new BindingSource();

        public masterModel(viewMasterModel f)
        {
            InitializeComponent();
            con = new SqlConnection(db.GetConnection());
            this.f = f;
        }

        private void m_modelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.m_modelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uASDataSet);

        }

        private void m_modelBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.m_modelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uASDataSet);

        }

        private void masterModel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uASDataSet.m_model' table. You can move, or remove it, as needed.
            this.m_modelTableAdapter.Fill(this.uASDataSet.m_model);

            String sql = "Select * from m_model";
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            bss.DataSource = dt;

            tb_modelid.DataBindings.Add(new Binding("Text", bss, "MODEL_ID"));
            tb_desc.DataBindings.Add(new Binding("Text", bss, "DESCRIPTION"));

        }

        private void btn_Prev_Click(object sender, EventArgs e)
        {
            bss.MovePrevious();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            bss.MoveNext();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainHome f = new mainHome();
            f.Show();
        }

        private void clear()
        {
            tb_modelid.Clear();
            tb_desc.Clear();

            btn_Add.Enabled = true;
            btn_Edit.Enabled = false;
            tb_modelid.Focus();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_desc.Text == "")
                {
                    MessageBox.Show("REQUIRED MISSING FIELD!", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                con.Open();
                cmd = new SqlCommand("INSERT INTO m_model (DESCRIPTION) values (@description)", con);
               
                cmd.Parameters.AddWithValue("@description", tb_desc.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Model Berhasil Disimpan", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (tb_modelid.Text == "")
                {
                    MessageBox.Show("REQUIRED MISSING FIELD!", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (MessageBox.Show("Ingin Mengupdate Data ini ?", "MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("UPDATE m_model SET DESCRIPTION = @description WHERE MODEL_ID = @model_id", con);
                    cmd.Parameters.AddWithValue("@model_id", tb_modelid.Text);
                    cmd.Parameters.AddWithValue("@description", tb_desc.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data Model Berhasil Diupdate", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewMasterModel f = new viewMasterModel();
            f.ShowDialog();
        }

        private void btn_Top_Click(object sender, EventArgs e)
        {
            bss.MoveFirst();
        }

        private void btn_Bottom_Click(object sender, EventArgs e)
        {
            bss.MoveLast();
        }
    }
}
