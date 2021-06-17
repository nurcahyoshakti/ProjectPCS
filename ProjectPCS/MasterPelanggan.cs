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
    public partial class masterPelanggan : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        ConnectionDB db = new ConnectionDB();
        viewMasterPelanggan f;
        SqlDataAdapter da;

        BindingSource bss = new BindingSource();

        public masterPelanggan(viewMasterPelanggan f)
        {
            InitializeComponent();

            con = new SqlConnection(db.GetConnection());
            this.f = f;

        }

        private void m_pelangganBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.m_pelangganBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.uASDataSet);

        }

        private void masterPelanggan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uASDataSet.m_pelanggan' table. You can move, or remove it, as needed.
            this.m_pelangganTableAdapter.Fill(this.uASDataSet.m_pelanggan);

            String sql = "Select * from m_pelanggan";
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            bss.DataSource = dt;

            tb_kode.DataBindings.Add(new Binding("Text", bss, "P_CODE"));
            tb_nama.DataBindings.Add(new Binding("Text", bss, "NAMA"));
            tb_almt.DataBindings.Add(new Binding("Text", bss, "ALAMAT"));
            tb_kota.DataBindings.Add(new Binding("Text", bss, "KOTA"));
            tb_telpn.DataBindings.Add(new Binding("Text", bss, "TELP"));
            tb_npwp.DataBindings.Add(new Binding("Text", bss, "NPWP"));
            tb_nmnpwp.DataBindings.Add(new Binding("Text", bss, "NAMA_NPWP"));
            tb_almtnpwp.DataBindings.Add(new Binding("Text", bss, "ALAMAT_NPWP"));
            tb_nama2.DataBindings.Add(new Binding("Text", bss, "NAMA1"));
            tb_almt2.DataBindings.Add(new Binding("Text", bss, "ALAMAT1"));
            tb_kota2.DataBindings.Add(new Binding("Text", bss, "KOTA1"));
            tb_hp.DataBindings.Add(new Binding("Text", bss, "HP"));
            tb_note.DataBindings.Add(new Binding("Text", bss, "KETERANGAN"));
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
            tb_kode.Clear();
            tb_nama.Clear();
            tb_almt.Clear();
            tb_nama2.Clear();
            tb_almt2.Clear();
            tb_nmnpwp.Clear();
            tb_almtnpwp.Clear();
            tb_npwp.Clear();
            tb_note.Clear();
            tb_telpn.Clear();
            tb_kota.Clear();
            tb_hp.Clear();
            tb_kota2.Clear();

            btn_Add.Enabled = true;
            btn_Edit.Enabled = false;
            tb_kode.Focus();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_kode.Text == "" || tb_nama.Text == "" || tb_kota.Text == "")
                {
                    MessageBox.Show("REQUIRED MISSING FIELD!", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                con.Open();
                cmd = new SqlCommand("INSERT INTO m_pelanggan (P_CODE, NAMA, ALAMAT, KOTA, TELP, NPWP, NAMA_NPWP, ALAMAT_NPWP, NAMA1, ALAMAT1, KOTA1, HP, KETERANGAN) values (@p_code, @nama, @alamat, @kota, @telp, @npwp, @nama_npwp, @alamat_npwp, @nama1, @alamat1, @kota1, @hp, @keterangan)", con);
                cmd.Parameters.AddWithValue("@p_code", tb_kode.Text);
                cmd.Parameters.AddWithValue("@nama", tb_nama.Text);
                cmd.Parameters.AddWithValue("@alamat", tb_almt.Text);
                cmd.Parameters.AddWithValue("@kota", tb_kota.Text);
                cmd.Parameters.AddWithValue("@telp", tb_telpn.Text);
                cmd.Parameters.AddWithValue("@npwp", tb_npwp.Text);
                cmd.Parameters.AddWithValue("@nama_npwp", tb_nmnpwp.Text);
                cmd.Parameters.AddWithValue("@alamat_npwp", tb_almtnpwp.Text);
                cmd.Parameters.AddWithValue("@nama1", tb_nama2.Text);
                cmd.Parameters.AddWithValue("@alamat1", tb_almt2.Text);
                cmd.Parameters.AddWithValue("@kota1", tb_kota2.Text);
                cmd.Parameters.AddWithValue("@hp", tb_hp.Text);
                cmd.Parameters.AddWithValue("@keterangan", tb_note.Text);
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

        private void tb_nama_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_nama2_TextChanged(object sender, EventArgs e)
        {

        }

        private void m_pelangganBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_kode.Text == "" || tb_nama.Text == "" || tb_kota.Text == "")
                {
                    MessageBox.Show("REQUIRED MISSING FIELD!", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (MessageBox.Show("Ingin Mengupdate Data ini ?", "MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new SqlCommand("UPDATE m_pelanggan SET NAMA = @nama, ALAMAT = @alamat, KOTA = @kota, TELP = @telp, NPWP = @npwp, NAMA_NPWP = @nama_npwp, ALAMAT_NPWP = @alamat_npwp, NAMA1 = @nama1, ALAMAT1 = @ALAMAT1, KOTA1 = @kota1, HP = @hp, KETERANGAN = @keterangan WHERE P_CODE = @p_code", con);
                    cmd.Parameters.AddWithValue("@p_code", tb_kode.Text);
                    cmd.Parameters.AddWithValue("@nama", tb_nama.Text);
                    cmd.Parameters.AddWithValue("@alamat", tb_almt.Text);
                    cmd.Parameters.AddWithValue("@kota", tb_kota.Text);
                    cmd.Parameters.AddWithValue("@telp", tb_telpn.Text);
                    cmd.Parameters.AddWithValue("@npwp", tb_npwp.Text);
                    cmd.Parameters.AddWithValue("@nama_npwp", tb_nmnpwp.Text);
                    cmd.Parameters.AddWithValue("@alamat_npwp", tb_almtnpwp.Text);
                    cmd.Parameters.AddWithValue("@nama1", tb_nama2.Text);
                    cmd.Parameters.AddWithValue("@alamat1", tb_almt2.Text);
                    cmd.Parameters.AddWithValue("@kota1", tb_kota2.Text);
                    cmd.Parameters.AddWithValue("@hp", tb_hp.Text);
                    cmd.Parameters.AddWithValue("@keterangan", tb_note.Text);
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

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewMasterPelanggan f = new viewMasterPelanggan();
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
