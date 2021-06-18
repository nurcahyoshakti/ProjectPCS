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

        //CLEAR SCREEN
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

        private void masterPelanggan_Load(object sender, EventArgs e)
        {
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

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_kode.Text == "" || tb_nama.Text == "" || tb_kota.Text == "")
                {
                    MessageBox.Show("REQUIRED MISSING FIELD!", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                Variables_Pelanggan obj = new Variables_Pelanggan();
                obj.kodePelanggan = tb_kode.Text;
                obj.namaPelanggan = tb_nama.Text;
                obj.alamatPelanggan = tb_almt.Text;
                obj.kotaPelanggan = tb_kota.Text;
                obj.telpPelanggan = tb_telpn.Text;
                obj.npwpPelanggan = tb_npwp.Text;
                obj.nama_npwpPelanggan = tb_nmnpwp.Text;
                obj.alamat_npwpPelanggan = tb_almt.Text;
                obj.nama2Pelanggan = tb_nama2.Text;
                obj.alamat2Pelanggan = tb_almt2.Text;
                obj.kota2Pelanggan = tb_kota2.Text;
                obj.hpPelanggan = tb_hp.Text;
                obj.keteranganPelanggan = tb_note.Text;

                PelangganFunction pf = new PelangganFunction();
                pf.add(obj);

                MessageBox.Show("Data Pelanggan Berhasil Disimpan", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                if (tb_kode.Text == "" || tb_nama.Text == "" || tb_kota.Text == "")
                {
                    MessageBox.Show("REQUIRED MISSING FIELD!", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                Variables_Pelanggan obj = new Variables_Pelanggan();
                obj.kodePelanggan = tb_kode.Text;
                obj.namaPelanggan = tb_nama.Text;
                obj.alamatPelanggan = tb_almt.Text;
                obj.kotaPelanggan = tb_kota.Text;
                obj.telpPelanggan = tb_telpn.Text;
                obj.npwpPelanggan = tb_npwp.Text;
                obj.nama_npwpPelanggan = tb_nmnpwp.Text;
                obj.alamat_npwpPelanggan = tb_almt.Text;
                obj.nama2Pelanggan = tb_nama2.Text;
                obj.alamat2Pelanggan = tb_almt2.Text;
                obj.kota2Pelanggan = tb_kota2.Text;
                obj.hpPelanggan = tb_hp.Text;
                obj.keteranganPelanggan = tb_note.Text;

                PelangganFunction pf = new PelangganFunction();
                pf.editt(obj);

                MessageBox.Show("Data Pelanggan Berhasil Diupdate", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                f.LoadRecords();
                clear();
            }
            catch (Exception ex)
            {
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

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainHome f = new mainHome();
            f.Show();
        }
    }
}
