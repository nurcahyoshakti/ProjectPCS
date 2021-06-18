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
    public partial class masterBarang : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        ConnectionDB db = new ConnectionDB();
        viewMasterBarang f;
        SqlDataAdapter da;

        BindingSource bss = new BindingSource();

        public masterBarang(viewMasterBarang f)
        {
            InitializeComponent();

            con = new SqlConnection(db.GetConnection());
            this.f = f;
        }

        //CLEAR SCREEN
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
            tb_merk1.Clear();
            tb_merk2.Clear();
            tb_merk3.Clear();
            tb_Note.Clear();

            btn_Add.Enabled = true;
            btn_Edit.Enabled = false;
            tb_KodeBarang.Focus();
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewMasterBarang f = new viewMasterBarang();
            f.ShowDialog();
        }

        private void masterBarang_Load(object sender, EventArgs e)
        {
            String sql = "Select * from m_barang";
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            bss.DataSource = dt;

            tb_KodeBarang.DataBindings.Add(new Binding("Text", bss, "KODE"));
            tb_partNumber.DataBindings.Add(new Binding("Text", bss, "PART_NO"));
            tb_namaBarang.DataBindings.Add(new Binding("Text", bss, "DESCRIPTION"));
            tb_unitPrice.DataBindings.Add(new Binding("Text", bss, "UNIT_PRICE"));
            tb_unit.DataBindings.Add(new Binding("Text", bss, "UNIT"));
            tb_stamping.DataBindings.Add(new Binding("Text", bss, "STAMPING"));
            tb_dataFisik.DataBindings.Add(new Binding("Text", bss, "DATA_FISIK"));
            tb_persamaan.DataBindings.Add(new Binding("Text", bss, "PERSAMAAN"));
            tb_PN1.DataBindings.Add(new Binding("Text", bss, "PN1"));
            tb_merk1.DataBindings.Add(new Binding("Text", bss, "MERK1"));
            tb_merk2.DataBindings.Add(new Binding("Text", bss, "MERK2"));
            tb_merk3.DataBindings.Add(new Binding("Text", bss, "MERK3"));
            tb_Note.DataBindings.Add(new Binding("Text", bss, "KETERANGAN"));
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
                Variables_Barang obj = new Variables_Barang();
                obj.kodeBarang = tb_KodeBarang.Text;
                obj.partNoBarang = tb_partNumber.Text;
                obj.namaBarang = tb_namaBarang.Text;
                obj.unitPriceBarang = tb_unitPrice.Text;
                obj.unitBarang = tb_unit.Text;
                obj.stampingBarang = tb_stamping.Text;
                obj.dataFisikBarang = tb_dataFisik.Text;
                obj.persamaanBarang = tb_persamaan.Text;
                obj.pn1Barang = tb_PN1.Text;
                obj.merkBarang1 = tb_merk1.Text;
                obj.merkBarang2 = tb_merk2.Text;
                obj.merkBarang3 = tb_merk3.Text;
                obj.keteranganBarang = tb_Note.Text;

                BarangFunction bf = new BarangFunction();
                bf.add(obj);

                MessageBox.Show("Data Barang Berhasil Disimpan", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                if (tb_KodeBarang.Text == "" || tb_namaBarang.Text == "" || tb_unitPrice.Text == "" || tb_unit.Text == "")
                {
                    MessageBox.Show("REQUIRED MISSING FIELD!", "MESSAGE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                Variables_Barang obj = new Variables_Barang();
                obj.kodeBarang = tb_KodeBarang.Text;
                obj.partNoBarang = tb_partNumber.Text;
                obj.namaBarang = tb_namaBarang.Text;
                obj.unitPriceBarang = tb_unitPrice.Text;
                obj.unitBarang = tb_unit.Text;
                obj.stampingBarang = tb_stamping.Text;
                obj.dataFisikBarang = tb_dataFisik.Text;
                obj.persamaanBarang = tb_persamaan.Text;
                obj.pn1Barang = tb_PN1.Text;
                obj.merkBarang1 = tb_merk1.Text;
                obj.merkBarang2 = tb_merk2.Text;
                obj.merkBarang3 = tb_merk3.Text;
                obj.keteranganBarang = tb_Note.Text;

                BarangFunction bf = new BarangFunction();
                bf.editt(obj);

                MessageBox.Show("Data Barang Berhasil Diupdate", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                f.LoadRecords();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
