using Npgsql;
using Sistema_Asistencia_Personal.ConexiónBDPostgresql;
using Sistema_Asistencia_Personal.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Deployment.Application;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
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
            conection c = new conection();
            try
            {
                using (NpgsqlConnection connection = c.conect())
                {
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
                    MessageBox.Show("Usuario creado", "System message",
                        MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ya existem este usuario en la base de datos", "System message",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return objeto;
        }

        public void buscar(string identificacion)
        {

        }
       
        public bool buscarP(PersonalM per)
        {
            conection c = new conection();
            bool exit = false;
            try
            {
                using (NpgsqlConnection connection = c.conect())
                {
                    string q = "select identificacion, nombres, estado FROM personal WHERE identificacion = @ident";
                    //string query = "select personal.identificacion, personal.nombres, asistencia_diaria.estado FROM personal INNER JOIN asistencia_diaria ON personal.identificacion=asistencia_diaria.identi_persona " +
                      //  "WHERE identificacion = @ident";
                    using (NpgsqlCommand comand = new NpgsqlCommand(q, connection))
                    {
                        comand.Parameters.AddWithValue("@ident", per.Identificacion);
                        using (NpgsqlDataReader dataReader = comand.ExecuteReader())
                        {
                            while(dataReader.Read())
                            {
                                exit = true;
                                per.Identificacion = dataReader.GetString(0);
                                per.Nombre = dataReader.GetString(1);
                                per.Estado=dataReader.GetString(2);
                            }
                            dataReader.Close();
                        }
                    }
                }
            }
            
            catch(NpgsqlException ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
            return exit;
        }

        public void eliminar(string identificacion)
        {
            conection c = new conection();
            try
            {
                using (NpgsqlConnection connection = c.conect())
                {
                    string insertQuery = "DELETE FROM  personal WHERE identificacion=@ident";
                    using (NpgsqlCommand comand = new NpgsqlCommand(insertQuery, connection))
                    {
                        comand.Parameters.AddWithValue("@ident", identificacion);
                        comand.ExecuteNonQuery();
                    }
                    MessageBox.Show("Delete Ok ", "System message");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace + "\n" + ex.Message, "System Message");
            }
        }

        public void mostrarTodo(DataTable dt)
        {
            conection c = new conection();
            try
            {
                using (NpgsqlConnection connection = c.conect())
                {
                    //string insertQuery = "SELECT nombres, pais, idcargo, estado, codigo, identificacion  FROM personal";
                    string insertQuery = "SELECT personal.identificacion, personal.nombres, personal.pais, cargo.sueldohora, cargo.nombrecargo," +
                        " personal.estado, personal.idcargo FROM personal INNER JOIN cargo ON personal.idcargo = cargo.id;"; 
                    using (NpgsqlCommand comand = new NpgsqlCommand(insertQuery, connection))
                    {
                        NpgsqlDataReader dataReader = comand.ExecuteReader();
                        dt.Columns.Add("Identificación", typeof(string));
                        dt.Columns.Add("Nombres", typeof(string));
                        dt.Columns.Add("Pais", typeof(string));
                        dt.Columns.Add("Sueldo (H)", typeof(float));
                        dt.Columns.Add("Cargo", typeof(string));
                        dt.Columns.Add("Estado", typeof(string));
                        dt.Columns.Add("IdCargo", typeof(int));
                        while (dataReader.Read())
                        {
                            string ident = dataReader.GetString(0);
                            string nombres = dataReader.GetString(1);
                            string pais = dataReader.GetString(2);
                            float sueldo = dataReader.GetFloat(3);
                            string nombrecargo = dataReader.GetString(4);
                            string estado = dataReader.GetString(5);
                            int idcargo = dataReader.GetInt32(6);
                            dt.Rows.Add(ident, nombres, pais, sueldo, nombrecargo, estado, idcargo);
                        }
                        dataReader.Close();
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
                    string insertQuery = "UPDATE  personal set estado=@estado WHERE identificacion=@ident";
                    using (NpgsqlCommand comand = new NpgsqlCommand(insertQuery, connection))
                    {
                        comand.Parameters.AddWithValue("@estado", estado);
                        comand.Parameters.AddWithValue("@ident", identificacion);
                        //comand.Parameters.AddWithValue("@estado", objeto.Estado);
                        comand.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace + "\n" + ex.Message, "System Message");
            }
        }

        public void crearUsuarioInicioSesion(string identificaacion)
        {
            conection c = new conection();
            try
            {
                using (NpgsqlConnection connection = c.conect())
                {
                    string q = "INSERT INTO usuario (contrasena, tipo, identificacionpersonal) values (@contr, @tipo, @ident);";
                    using (NpgsqlCommand comand = new NpgsqlCommand(q, connection))
                    {
                        comand.Parameters.AddWithValue("@contr", identificaacion);
                        comand.Parameters.AddWithValue("@tipo", "EMPLEADO");
                        comand.Parameters.AddWithValue("@ident", identificaacion);
                        comand.ExecuteNonQuery();
                    }
                }
            }catch(Exception ex) {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
        }
    }
}
