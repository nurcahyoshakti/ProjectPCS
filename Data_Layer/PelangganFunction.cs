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
    public class PelangganFunction
    {
        SqlConnection con = new SqlConnection(@"Data Source =.\SQLExpress;Initial Catalog = UAS; User ID = sa; Password=surabaya123321");
        public void add(Variables_Pelanggan obj)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO m_pelanggan (P_CODE, NAMA, ALAMAT, KOTA, TELP, NPWP, NAMA_NPWP, ALAMAT_NPWP, NAMA1, ALAMAT1, KOTA1, HP, KETERANGAN) values (@p_code, @nama, @alamat, @kota, @telp, @npwp, @nama_npwp, @alamat_npwp, @nama1, @alamat1, @kota1, @hp, @keterangan)", con);
            cmd.Parameters.AddWithValue("@p_code", obj.kodePelanggan);
            cmd.Parameters.AddWithValue("@nama", obj.namaPelanggan);
            cmd.Parameters.AddWithValue("@alamat", obj.alamatPelanggan);
            cmd.Parameters.AddWithValue("@kota", obj.kotaPelanggan);
            cmd.Parameters.AddWithValue("@telp", obj.telpPelanggan);
            cmd.Parameters.AddWithValue("@npwp", obj.npwpPelanggan);
            cmd.Parameters.AddWithValue("@nama_npwp", obj.nama_npwpPelanggan);
            cmd.Parameters.AddWithValue("@alamat_npwp", obj.alamat_npwpPelanggan);
            cmd.Parameters.AddWithValue("@nama1", obj.nama2Pelanggan);
            cmd.Parameters.AddWithValue("@alamat1", obj.alamat2Pelanggan);
            cmd.Parameters.AddWithValue("@kota1", obj.kota2Pelanggan);
            cmd.Parameters.AddWithValue("@hp", obj.hpPelanggan);
            cmd.Parameters.AddWithValue("@keterangan", obj.keteranganPelanggan);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void editt(Variables_Pelanggan obj)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE m_pelanggan SET NAMA = @nama, ALAMAT = @alamat, KOTA = @kota, TELP = @telp, NPWP = @npwp, NAMA_NPWP = @nama_npwp, ALAMAT_NPWP = @alamat_npwp, NAMA1 = @nama1, ALAMAT1 = @ALAMAT1, KOTA1 = @kota1, HP = @hp, KETERANGAN = @keterangan WHERE P_CODE = @p_code", con);
            cmd.Parameters.AddWithValue("@p_code", obj.kodePelanggan);
            cmd.Parameters.AddWithValue("@nama", obj.namaPelanggan);
            cmd.Parameters.AddWithValue("@alamat", obj.alamatPelanggan);
            cmd.Parameters.AddWithValue("@kota", obj.kotaPelanggan);
            cmd.Parameters.AddWithValue("@telp", obj.telpPelanggan);
            cmd.Parameters.AddWithValue("@npwp", obj.npwpPelanggan);
            cmd.Parameters.AddWithValue("@nama_npwp", obj.nama_npwpPelanggan);
            cmd.Parameters.AddWithValue("@alamat_npwp", obj.alamat_npwpPelanggan);
            cmd.Parameters.AddWithValue("@nama1", obj.nama2Pelanggan);
            cmd.Parameters.AddWithValue("@alamat1", obj.alamat2Pelanggan);
            cmd.Parameters.AddWithValue("@kota1", obj.kota2Pelanggan);
            cmd.Parameters.AddWithValue("@hp", obj.hpPelanggan);
            cmd.Parameters.AddWithValue("@keterangan", obj.keteranganPelanggan);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
