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
using System.Xml.Linq;

namespace Sistema_Asistencia_Personal.Controlador
{
    internal class FuncionesPersonal : Interface<PersonalM>
    {
        public PersonalM actualizar(PersonalM objeto)
        {
            conection c = new conection();
            try
            {
                using (NpgsqlConnection connection = c.conect())
                {
                    connection.Close();
                    connection.Open();
                    string insertQuery = "UPDATE  personal set nombres=@nombre, pais=@pais, " +
                        "idcargo=@idcargo WHERE identificacion=@ident";
                    using (NpgsqlCommand comand = new NpgsqlCommand(insertQuery, connection))
                    {
                        comand.Parameters.AddWithValue("@nombre", objeto.Nombre);
                        comand.Parameters.AddWithValue("@ident", objeto.Identificacion);
                        comand.Parameters.AddWithValue("@pais", objeto.Pais);
                        comand.Parameters.AddWithValue("@idcargo", objeto.Cargo);
                        //comand.Parameters.AddWithValue("@estado", objeto.Estado);
                        comand.ExecuteNonQuery();

                    }
                    MessageBox.Show("Update Ok ", "System message");
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace + "\n" + ex.Message, "System Message");
            }
            return objeto;
        }

        public PersonalM agregar(PersonalM objeto)
        {

            //PersonalM personal = new PersonalM();
            conection c = new conection();
            try
            {
                using (NpgsqlConnection connection = c.conect())
                {
                    connection.Close();
                    connection.Open();
                    string insertQuery = "INSERT INTO personal (nombres, identificacion, pais, idcargo, estado) VALUES (@nombre, @ident, @country, @idcargo, @est);";
                    using (NpgsqlCommand comand = new NpgsqlCommand(insertQuery, connection))
                    {
                        comand.Parameters.AddWithValue("@nombre", objeto.Nombre);
                        comand.Parameters.AddWithValue("@ident", objeto.Identificacion);
                        comand.Parameters.AddWithValue("@country", objeto.Pais);
                        comand.Parameters.AddWithValue("@idcargo", objeto.Cargo);
                        comand.Parameters.AddWithValue("@est", "ACTIVO");
                        comand.ExecuteNonQuery();

                    }
                    MessageBox.Show("Registered product ", "System message");
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace+"\n" + ex.Message, "System Message");
            }
            return objeto;
        }

        public void buscar(int codigo)
        {
            throw new NotImplementedException();
        }

        public void eliminar(string identificacion)
        {
            conection c = new conection();
            try
            {
                using (NpgsqlConnection connection = c.conect())
                {
                    connection.Close();
                    connection.Open();
                    string insertQuery = "DELETE FROM  personal WHERE identificacion=@ident";
                    using (NpgsqlCommand comand = new NpgsqlCommand(insertQuery, connection))
                    {
                        comand.Parameters.AddWithValue("@ident", identificacion);
                        comand.ExecuteNonQuery();

                    }
                    MessageBox.Show("Delete Ok ", "System message");
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace + "\n" + ex.Message, "System Message");
            }
        }

        public List<PersonalM> obtenerTodo()
        {
            throw new NotImplementedException();
        }

        public void mostrarTodo(DataTable dt)
        {
            conection c = new conection();
            try
            {
                using (NpgsqlConnection connection = c.conect())
                {
                    connection.Close();
                    connection.Open();
                    //string insertQuery = "SELECT nombres, pais, idcargo, estado, codigo, identificacion  FROM personal";
                    string insertQuery = "SELECT personal.identificacion, personal.nombres, personal.pais, cargo.sueldohora, cargo.nombrecargo," +
                        " personal.estado FROM personal INNER JOIN cargo ON personal.idcargo = cargo.id;"; 
                    using (NpgsqlCommand comand = new NpgsqlCommand(insertQuery, connection))
                    {
                        NpgsqlDataReader dataReader = comand.ExecuteReader();
                        dt.Columns.Add("Identificación", typeof(string));
                        dt.Columns.Add("Nombres", typeof(string));
                        dt.Columns.Add("Pais", typeof(string));
                        dt.Columns.Add("Sueldo (H)", typeof(float));
                        dt.Columns.Add("Cargo", typeof(string));
                        dt.Columns.Add("Estado", typeof(string));



                        while (dataReader.Read())
                        {
                            string ident = dataReader.GetString(0);
                            string nombres = dataReader.GetString(1);
                            string pais = dataReader.GetString(2);
                            float sueldo = dataReader.GetFloat(3);
                            string nombrecargo = dataReader.GetString(4);
                            string estado = dataReader.GetString(5);

                            dt.Rows.Add(ident, nombres, pais, sueldo, nombrecargo, estado);
                        }

                        dataReader.Close();
                        connection.Close();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"\n"+ex.StackTrace);
            }
        }

        public void cambiarEstado(string identificacion, string estado)
        {
            conection c = new conection();
            try
            {
                using (NpgsqlConnection connection = c.conect())
                {
                    connection.Close();
                    connection.Open();
                    string insertQuery = "UPDATE  personal set estado=@estado WHERE identificacion=@ident";
                    using (NpgsqlCommand comand = new NpgsqlCommand(insertQuery, connection))
                    {
                        comand.Parameters.AddWithValue("@estado", estado);
                        comand.Parameters.AddWithValue("@ident", identificacion);
                        //comand.Parameters.AddWithValue("@estado", objeto.Estado);
                        comand.ExecuteNonQuery();

                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace + "\n" + ex.Message, "System Message");
            }
        }
    }
}
