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
    public class SupplierFunction
    {
        SqlConnection con = new SqlConnection(@"Data Source =.\SQLExpress;Initial Catalog = UAS; User ID = sa; Password=surabaya123321");
        public void add(Variables_Supplier obj)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO m_supplier (P_ID, NAMA, ALAMAT, KOTA, TELP_HP, NPWP, NAMA_NPWP, ALAMAT_NPW, EMAIL, BANK, NOTE) values (@p_id, @nama, @alamat, @kota, @telp_hp, @npwp, @nama_npwp, @alamat_npw, @email, @bank, @note)", con);
            cmd.Parameters.AddWithValue("@p_id", obj.idSupplier);
            cmd.Parameters.AddWithValue("@nama", obj.namaSupplier);
            cmd.Parameters.AddWithValue("@alamat", obj.alamatSupplier);
            cmd.Parameters.AddWithValue("@kota", obj.kotaSupplier);
            cmd.Parameters.AddWithValue("@telp_hp", obj.TelpHP_Supplier);
            cmd.Parameters.AddWithValue("@npwp", obj.npwpSupplier);
            cmd.Parameters.AddWithValue("@nama_npwp", obj.namanpwpSupplier);
            cmd.Parameters.AddWithValue("@alamat_npw", obj.alamatnpwpSupplier);
            cmd.Parameters.AddWithValue("@email", obj.emailSupplier);
            cmd.Parameters.AddWithValue("@bank", obj.bankSupplier);
            cmd.Parameters.AddWithValue("@note", obj.noteSupplier);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void editt(Variables_Supplier obj)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE m_supplier SET NAMA = @nama, ALAMAT = @alamat, KOTA = @kota, TELP_HP = @telp_hp, NPWP = @npwp, NAMA_NPWP = @nama_npwp, ALAMAT_NPW = @alamat_npwp, EMAIL = @email, BANK = @bank, NOTE = @note WHERE P_ID = @p_id", con);
            cmd.Parameters.AddWithValue("@p_id", obj.idSupplier);
            cmd.Parameters.AddWithValue("@nama", obj.namaSupplier);
            cmd.Parameters.AddWithValue("@alamat", obj.alamatSupplier);
            cmd.Parameters.AddWithValue("@kota", obj.kotaSupplier);
            cmd.Parameters.AddWithValue("@telp_hp", obj.TelpHP_Supplier);
            cmd.Parameters.AddWithValue("@npwp", obj.npwpSupplier);
            cmd.Parameters.AddWithValue("@nama_npwp", obj.namanpwpSupplier);
            cmd.Parameters.AddWithValue("@alamat_npw", obj.alamatnpwpSupplier);
            cmd.Parameters.AddWithValue("@email", obj.emailSupplier);
            cmd.Parameters.AddWithValue("@bank", obj.bankSupplier);
            cmd.Parameters.AddWithValue("@note", obj.noteSupplier);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
