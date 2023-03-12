using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Sistema_Asistencia_Personal.ConexiónBDPostgresql;
using System.Windows.Forms;
using Sistema_Asistencia_Personal.Modelo;
using System.Diagnostics;
using System.Data;

namespace Sistema_Asistencia_Personal.Controlador
{
    internal class FuncionAsistencia
    {


        public bool agregarAsistencia(Asistencia objeto)
        {
            bool entrada = false;
            conection c = new conection();
            using (NpgsqlConnection connection = c.conect())
            {
                using (NpgsqlTransaction trans = connection.BeginTransaction())
                {
                    string queryselect = "SELECT horaentrada FROM asistencia_diaria WHERE identi_persona=@cedula and fecha=@fecha";
                    try
                    {
                        using (NpgsqlCommand comand = new NpgsqlCommand(queryselect, connection))
                        {
                            comand.Transaction = trans;
                            comand.Parameters.AddWithValue("@cedula", objeto.Identificacion_persona);
                            comand.Parameters.AddWithValue("@fecha", objeto.Fecha);
                                DateTime? horaEntrada = (DateTime?)comand.ExecuteScalar();
                                if (horaEntrada == null)
                                {
                                    entrada = true;
                                    try
                                    {
                                        string insertQueryEntrada = "INSERT INTO asistencia_diaria (horaentrada, horasalida, fecha, identi_persona, observacion, horas, estado)" +
                                        "VALUES (@hentrada, @hsalida, @fecha, @idcedulapersona, @obsservacion, @horas, @estado);";
                                        using (NpgsqlCommand cmd = new NpgsqlCommand(insertQueryEntrada, connection))
                                        {
                                            cmd.Parameters.AddWithValue("@hentrada", objeto.Hora_entrada);
                                            cmd.Parameters.AddWithValue("@hsalida", DBNull.Value);
                                            cmd.Parameters.AddWithValue("@fecha", objeto.Fecha);
                                            cmd.Parameters.AddWithValue("@idcedulapersona", objeto.Identificacion_persona);
                                            cmd.Parameters.AddWithValue("@obsservacion", objeto.Observacion);
                                            cmd.Parameters.AddWithValue("@horas", objeto.Hora);
                                            cmd.Parameters.AddWithValue("@estado", "ENTRADA");

                                            if (cmd.ExecuteNonQuery() >= 1)
                                            {
                                                MessageBox.Show("Se registro tu entrada", "System message");
                                            }
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.StackTrace + "\n" + ex.Message);
                                        MessageBox.Show("No existe el usuario");
                                    }
                                }

                                else
                                {
                                    try
                                    {
                                        string insertQuerySalida = "UPDATE asistencia_diaria SET horasalida = @hora_salida, fecha=@fecha, estado=@estado WHERE identi_persona = @cedula and estado='ENTRADA'";
                                        using (NpgsqlCommand commmand = new NpgsqlCommand(insertQuerySalida, connection))
                                        {
                                            commmand.Parameters.AddWithValue("@hora_salida", objeto.Hora_salida);
                                            commmand.Parameters.AddWithValue("@fecha", objeto.Fecha);
                                            commmand.Parameters.AddWithValue("@cedula", objeto.Identificacion_persona);
                                            commmand.Parameters.AddWithValue("@horas", objeto.Hora);
                                            commmand.Parameters.AddWithValue("@estado", "SALIDA");
                                            if (commmand.ExecuteNonQuery() >= 1)
                                            {
                                                MessageBox.Show("Se registro tu salida", "System message");

                                            }
                                            else
                                            {
                                                MessageBox.Show("Ya tienes registrada una salida", "System message");

                                            }
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }
                                }
                            }                     
                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                    }
                }
            }
            return entrada;
        }

        public void mostrarTodo(DataTable dt)
        {
            conection c = new conection();
            try
            {
                using (NpgsqlConnection connection = c.conect())
                {
                    string insertQuery = "SELECT identi_persona, observacion, horas, estado, fecha, horaentrada, COALESCE(horasalida::text, 'SIN SALIDA') as horasalida FROM asistencia_diaria ORDER BY idasistencia ASC";
                    using (NpgsqlCommand comand = new NpgsqlCommand(insertQuery, connection))
                    {
                        NpgsqlDataReader dataReader = comand.ExecuteReader();
                        dt.Columns.Add("Identificación", typeof(string));
                        dt.Columns.Add("Observacion", typeof(string));
                        dt.Columns.Add("Horas", typeof(int));
                        dt.Columns.Add("Estado", typeof(string));
                        dt.Columns.Add("Fecha", typeof(DateTime));
                        dt.Columns.Add("Hora entrada", typeof(DateTime));
                        dt.Columns.Add("Hora salida", typeof(string));
                        while (dataReader.Read())
                        {
                            string ident = dataReader.GetString(0);
                            string obs = dataReader.GetString(1);
                            int horas = dataReader.GetInt32(2);
                            string estado = dataReader.GetString(3);
                            DateTime fecha = dataReader.GetDateTime(4);
                            DateTime entrada = dataReader.GetDateTime(5);
                            string salida = dataReader.GetString(6);
                            dt.Rows.Add(ident,obs, horas, estado, fecha, entrada, salida.ToString());
                        }
                        dataReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
        }


        public void mostrarPorFecha(DateTime desde, DateTime hasta, DataTable dt)
        {
            conection c = new conection();

            try
            {
                using (NpgsqlConnection connection = c.conect())
                {
                    string insertQuery = "SELECT identi_persona, observacion, horas, estado, fecha, horaentrada, COALESCE(horasalida::text, 'SIN SALIDA') as horasalida FROM asistencia_diaria" +
                        " WHERE fecha BETWEEN @desde AND @hasta";
                    using (NpgsqlCommand comand = new NpgsqlCommand(insertQuery, connection))
                    {
                        comand.Parameters.AddWithValue("@desde", desde);
                        comand.Parameters.AddWithValue("@hasta", hasta);

                        NpgsqlDataReader dataReader = comand.ExecuteReader();

                        dt.Columns.Add("Identificación", typeof(string));
                        dt.Columns.Add("Observacion", typeof(string));
                        dt.Columns.Add("Horas", typeof(int));
                        dt.Columns.Add("Estado", typeof(string));
                        dt.Columns.Add("Fecha", typeof(DateTime));
                        dt.Columns.Add("Hora entrada", typeof(DateTime));
                        dt.Columns.Add("Hora salida", typeof(string));

                        while (dataReader.Read())
                        {
                            string ident = dataReader.GetString(0);
                            string obs = dataReader.GetString(1);
                            int horas = dataReader.GetInt32(2);
                            string estado = dataReader.GetString(3);
                            DateTime fecha = dataReader.GetDateTime(4);
                            DateTime entrada = dataReader.GetDateTime(5);
                            string salida = dataReader.GetString(6);
                            dt.Rows.Add(ident, obs, horas, estado, fecha, entrada, salida.ToString());
                        }
                        dataReader.Close();
                        //connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
        }


        public void mostrarPorIdentificacion(string identificacion, DataTable dt)
        {
            conection c = new conection();

            try
            {
                using (NpgsqlConnection connection = c.conect())
                {
                    string insertQuery = "SELECT identi_persona, observacion, horas, estado, fecha, horaentrada, COALESCE(horasalida::text, 'SIN SALIDA') as horasalida FROM asistencia_diaria" +
                        " WHERE identi_persona=@identi";
                    using (NpgsqlCommand comand = new NpgsqlCommand(insertQuery, connection))
                    {
                        comand.Parameters.AddWithValue("@identi", identificacion);

                        NpgsqlDataReader dataReader = comand.ExecuteReader();

                        dt.Columns.Add("Identificación", typeof(string));
                        dt.Columns.Add("Observacion", typeof(string));
                        dt.Columns.Add("Horas", typeof(int));
                        dt.Columns.Add("Estado", typeof(string));
                        dt.Columns.Add("Fecha", typeof(DateTime));
                        dt.Columns.Add("Hora entrada", typeof(DateTime));
                        dt.Columns.Add("Hora salida", typeof(string));

                        while (dataReader.Read())
                        {
                            string ident = dataReader.GetString(0);
                            string obs = dataReader.GetString(1);
                            int horas = dataReader.GetInt32(2);
                            string estado = dataReader.GetString(3);
                            DateTime fecha = dataReader.GetDateTime(4);
                            DateTime entrada = dataReader.GetDateTime(5);
                            string salida = dataReader.GetString(6);
                            dt.Rows.Add(ident, obs, horas, estado, fecha, entrada, salida.ToString());
                        }
                        dataReader.Close();
                        //connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
        }






    }

}
