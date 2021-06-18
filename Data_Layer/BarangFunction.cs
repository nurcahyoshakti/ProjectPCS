using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using Business_Layer;
using System.Data;

namespace Data_Layer
{
    public class BarangFunction
    {
        SqlConnection con = new SqlConnection(@"Data Source =.\SQLExpress;Initial Catalog = UAS; User ID = sa; Password=surabaya123321");
        public void add(Variables_Barang obj)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO m_barang (KODE, PART_NO, DESCRIPTION, UNIT_PRICE, UNIT, STAMPING, DATA_FISIK, PERSAMAAN, PN1, MERK1, MERK2, MERK3, KETERANGAN) values (@kode, @part_no, @description, @unit_price, @unit, @stamping, @data_fisik, @persamaan, @pn1, @merk1, @merk2, @merk3, @keterangan)", con);
            cmd.Parameters.AddWithValue("@kode", obj.kodeBarang);
            cmd.Parameters.AddWithValue("@part_no", obj.partNoBarang);
            cmd.Parameters.AddWithValue("@description", obj.namaBarang);
            cmd.Parameters.AddWithValue("@unit_price", obj.unitPriceBarang);
            cmd.Parameters.AddWithValue("@unit", obj.unitBarang);
            cmd.Parameters.AddWithValue("@stamping", obj.stampingBarang);
            cmd.Parameters.AddWithValue("@data_fisik", obj.dataFisikBarang);
            cmd.Parameters.AddWithValue("@persamaan", obj.persamaanBarang);
            cmd.Parameters.AddWithValue("@pn1", obj.pn1Barang);
            cmd.Parameters.AddWithValue("@merk1", obj.merkBarang1);
            cmd.Parameters.AddWithValue("@merk2", obj.merkBarang2);
            cmd.Parameters.AddWithValue("@merk3", obj.merkBarang3);
            cmd.Parameters.AddWithValue("@keterangan", obj.keteranganBarang);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void editt(Variables_Barang obj)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE m_barang SET PART_NO = @part_no, DESCRIPTION = @description, UNIT_PRICE = @unit_price, UNIT = @unit, STAMPING = @stamping, DATA_FISIK = @data_fisik, PERSAMAAN = @persamaan, PN1 = @pn1, MERK1 = @merk1, MERK2 = @merk2, MERK3 = @merk3, KETERANGAN = @keterangan WHERE KODE = @kode", con);
            cmd.Parameters.AddWithValue("@kode", obj.kodeBarang);
            cmd.Parameters.AddWithValue("@part_no", obj.partNoBarang);
            cmd.Parameters.AddWithValue("@description", obj.namaBarang);
            cmd.Parameters.AddWithValue("@unit_price", obj.unitPriceBarang);
            cmd.Parameters.AddWithValue("@unit", obj.unitBarang);
            cmd.Parameters.AddWithValue("@stamping", obj.stampingBarang);
            cmd.Parameters.AddWithValue("@data_fisik", obj.dataFisikBarang);
            cmd.Parameters.AddWithValue("@persamaan", obj.persamaanBarang);
            cmd.Parameters.AddWithValue("@pn1", obj.pn1Barang);
            cmd.Parameters.AddWithValue("@merk1", obj.merkBarang1);
            cmd.Parameters.AddWithValue("@merk2", obj.merkBarang2);
            cmd.Parameters.AddWithValue("@merk3", obj.merkBarang3);
            cmd.Parameters.AddWithValue("@keterangan", obj.keteranganBarang);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
