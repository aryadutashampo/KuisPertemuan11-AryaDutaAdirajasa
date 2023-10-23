using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuisPertemuan11_AryaDutaAdirajasa.Model
{
    internal class Connection
    {
        public MySqlCommand cmd;
        public DataSet ds;
        public MySqlDataAdapter da;
        public MySqlConnection conn;

        public MySqlConnection GetConn()
        {
            conn = new MySqlConnection();
            conn.ConnectionString = "server=localhost;user=root;database=unaspasim";
            try
            {
                conn.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Koneksi Gagal" +  ex.Message);
            }
            return conn;
        }
    }
}
