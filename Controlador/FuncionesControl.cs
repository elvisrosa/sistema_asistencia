using Npgsql;
using Sistema_Asistencia_Personal.ConexiónBDPostgresql;
using Sistema_Asistencia_Personal.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sistema_Asistencia_Personal.Controlador
{
    internal class FuncionesControl : Interface<Cargo>
    {
        public Cargo actualizar(Cargo objeto)
        {
            try
            {
                conection c = new conection();
                try
                {
                    using (NpgsqlConnection connection = c.conect())
                    {
                        string insertQuery = "UPDATE cargo set sueldohora=@sueldo, nombrecargo=@nombre WHERE id=@id";
                        using (NpgsqlCommand comand = new NpgsqlCommand(insertQuery, connection))
                        {
                            comand.Parameters.AddWithValue("@id", objeto.ID);
                            comand.Parameters.AddWithValue("@sueldo", objeto.SueldoHora);
                            comand.Parameters.AddWithValue("@nombre", objeto.Nombrecargo);
                            comand.ExecuteNonQuery();

                        }
                        MessageBox.Show("Update Exist", "System message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.StackTrace + "\n" + ex.Message, "System Message");
                }

            }
            catch(Exception ex)
            {

            }
            return objeto;

        }
        public Cargo agregar(Cargo objeto)
        {
            conection c = new conection();
            try
            {
                using (NpgsqlConnection connection = c.conect())
                {
                    string insertQuery = "INSERT INTO cargo (sueldohora, nombrecargo) VALUES (@sueldo, @nombre);";
                    using (NpgsqlCommand comand = new NpgsqlCommand(insertQuery, connection))
                    {
                        comand.Parameters.AddWithValue("@sueldo", objeto.SueldoHora);
                        comand.Parameters.AddWithValue("@nombre", objeto.Nombrecargo);
                        comand.ExecuteNonQuery();

                    }
                    MessageBox.Show("Registered Carg ", "System message");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace + "\n" + ex.Message, "System Message");
            }
            return objeto;
        }
        public void buscar(string codigo)
        {
            throw new NotImplementedException();
        }
        public void eliminar(string id)
        {
            throw new NotImplementedException();
        }
        public void mostrar(DataTable dt)
        {
            conection c = new conection();
            try
            {
                using (NpgsqlConnection connection = c.conect())
                {
                    //connection.Close();
                    //connection.Open();
                    string insertQuery = "SELECT id, sueldohora, nombrecargo  FROM cargo";
                    using (NpgsqlCommand comand = new NpgsqlCommand(insertQuery, connection))
                    {
                        NpgsqlDataReader dataReader = comand.ExecuteReader();
                        dt.Columns.Add("ID", typeof(int));
                        dt.Columns.Add("Cargo", typeof(string));
                        dt.Columns.Add("Sueldo", typeof(int));
                        while (dataReader.Read())
                        {
                            int id = dataReader.GetInt32(0);
                            float sueldohora = dataReader.GetFloat(1);
                            string cargo = dataReader.GetString(2);
                            dt.Rows.Add(id, cargo, sueldohora);
                        }

                        dataReader.Close();
                        //connection.Close();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

