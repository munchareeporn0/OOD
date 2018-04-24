using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookstore
{
    class Function
    {
        public string ConString
        {
            get
            {
                string server = "localhost";
                string database = "bookstoredb";
                string uid = "root";
                string password = "";
                string charset = "tis620";

                string connectionString;

                connectionString = "SERVER=" + server + ";"
                                 + "DATABASE=" + database + ";"
                                 + "UID=" + uid + ";"
                                 + "PASSWORD=" + password + ";"
                                 + "CHARSET=" + charset + ";";

                return connectionString;
            }
        }
        

        public void Update(string sql)
        {
            MySqlConnection con = new MySqlConnection(ConString);
            MySqlCommand cmd = new MySqlCommand(sql, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
        
        public DataTable Select(string sql)
        {
            MySqlConnection con = new MySqlConnection(ConString);
            MySqlCommand cmd = new MySqlCommand(sql, con);
            DataTable dt = new DataTable();

            try
            {
                con.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

            return dt;
        }
    }
}