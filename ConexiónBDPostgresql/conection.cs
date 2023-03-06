using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Sistema_Asistencia_Personal.ConexiónBDPostgresql
{
    internal class conection
    {
        NpgsqlConnection con = new NpgsqlConnection();

        string user = "postgres";
        string password = "123456";
        string server = "localhost";
        string port = "5432";
        string database = "MARCASIS_ASISTENCIA";

        public NpgsqlConnection conect()
        {
            try
            {
                con.ConnectionString = "server="+server+ ";"  + "port=" + port + ";" + "user id=" + user + ";" + "password=" + password + ";" + "database=" + database + ";";
                con.Open();
            }
            catch(NpgsqlException ex)
            {
                MessageBox.Show(ex.Message, "System error");
                //con.Close();
            }
            return con;
        }
    }
}
