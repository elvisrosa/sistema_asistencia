using Npgsql;
using Sistema_Asistencia_Personal.ConexiónBDPostgresql;
using Sistema_Asistencia_Personal.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Sistema_Asistencia_Personal.Controlador
{
    internal class FuncionesUsuarios
    {
        public bool iniciarSesion(Usuario p)
        {
            conection c = new conection();
            try
            {
                using (NpgsqlConnection connection = c.conect())
                {
                       string insertQuery = "SELECT u.tipo, p.nombres FROM usuario u INNER JOIN personal p" +
                        " ON p.identificacion = u.identificacionpersonal WHERE u.identificacionpersonal = @ident " +
                        "AND u.contrasena = @contrasena AND p.estado = 'ACTIVO'";
                    //tring insertQuery = "select * from us
                    using (NpgsqlCommand comand = new NpgsqlCommand(insertQuery, connection))
                    {
                        comand.Parameters.AddWithValue("@contrasena", p.Contrsenna);
                        comand.Parameters.AddWithValue("@ident", p.IdentificacionPersonal);
                        using (NpgsqlDataReader dataReader = comand.ExecuteReader())
                        {

                            while (dataReader.Read())
                            {        
                                
                                p.Tipo = dataReader.GetString(0);
                                p.Nombre = dataReader.GetString(1);
                                return true;

                            }
                                                   
                            dataReader.Close();
                        }
                        return false;
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                return false;
            }
        }

        public bool inicioSesionPersona(Usuario p)
        {
            conection c = new conection();
            try
            {
                using (NpgsqlConnection connection = c.conect())
                {
                    string insertQuery = "SELECT u.tipo, p.nombres FROM usuario u INNER JOIN personal p" +
                     " ON p.identificacion = u.identificacionpersonal WHERE u.identificacionpersonal = @ident " +
                     " AND p.estado = 'ACTIVO'";
                    //tring insertQuery = "select * from us
                    using (NpgsqlCommand comand = new NpgsqlCommand(insertQuery, connection))
                    {
                        //comand.Parameters.AddWithValue("@contrasena", p.Contrsenna);
                        comand.Parameters.AddWithValue("@ident", p.IdentificacionPersonal);
                        using (NpgsqlDataReader dataReader = comand.ExecuteReader())
                        {

                            while (dataReader.Read())
                            {
                                p.Tipo = dataReader.GetString(0);
                                p.Nombre = dataReader.GetString(1);
                                return true;
                            }

                            dataReader.Close();
                        }
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                return false;
            }
        }
    }
}

