using KuisPertemuan11_AryaDutaAdirajasa.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuisPertemuan11_AryaDutaAdirajasa.Controller
{
    internal class MahasiswaController : Model.Connection
    {
        public DataTable tampilMahasiswa()
        {
            DataTable dataMHS = new DataTable();
            try
            {
                string tampil = "SELECT * FROM mahasiswa";
                da = new MySqlConnector.MySqlDataAdapter(tampil, GetConn());
                da.Fill(dataMHS);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dataMHS;
        }

        public void tambahMahasiswa(string nim, string nama, string alamat, string prodi, string hobi)
        {
            string tambah = "insert into mahasiswa values(" + "@Nim,@Nama,@Alamat,@Prodi,@Hobi)";
            try
            {
                cmd = new MySqlConnector.MySqlCommand(tambah, GetConn());
                cmd.Parameters.Add("@Nim", MySqlConnector.MySqlDbType.VarChar).Value = nim;
                cmd.Parameters.Add("@Nama", MySqlConnector.MySqlDbType.VarChar).Value = nama;
                cmd.Parameters.Add("@Alamat", MySqlConnector.MySqlDbType.VarChar).Value = alamat;
                cmd.Parameters.Add("@Prodi", MySqlConnector.MySqlDbType.VarChar).Value = prodi;
                cmd.Parameters.Add("@Hobi", MySqlConnector.MySqlDbType.VarChar).Value = hobi;
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Tambah data gagal " + ex.Message);
            }
        }
    }
}
