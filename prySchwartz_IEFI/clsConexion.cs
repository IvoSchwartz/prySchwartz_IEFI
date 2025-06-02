using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Globalization;



namespace prySchwartz_IEFI
{
    public class clsConexion
    {
        string cadenaConexion = @"Server=PC136;Database=Iefi;Trusted_Connection=True;";
        public bool VerificarLogin(string usuario, string contraseña)
        {
            bool correcto = false;
            string consulta = "SELECT COUNT(*) FROM Usuarios WHERE LOWER(Usuario) = @Usuario AND Contraseña = @Contraseña";

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("@Usuario", SqlDbType.VarChar) { Value = usuario.ToLower().Trim() });
                        comando.Parameters.Add(new SqlParameter("@Contraseña", SqlDbType.VarChar) { Value = contraseña.Trim() });

                        int cantidad = (int)comando.ExecuteScalar();
                        correcto = cantidad > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al verificar login: " + ex.Message);
            }

            return correcto;
        }


        public void auditarAcceso(string usuario, DateTime inicio, DateTime cierre, TimeSpan duracion)
        {
            string consulta = "INSERT INTO HistorialAccesos (Usuario, FechayHoraDeInicio, FechayHoraDeCierre, Duracion) " +
                              "VALUES (@Usuario, @Inicio, @Cierre, @Duracion)";

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Usuario", usuario);
                        comando.Parameters.AddWithValue("@Inicio", inicio);
                        comando.Parameters.AddWithValue("@Cierre", cierre);
                        comando.Parameters.AddWithValue("@Duracion", duracion.ToString(@"hh\:mm\:ss"));
                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la sesión: " + ex.Message);
            }
        }

        public DataTable ejecutarConsulta(string consulta)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(comando))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar consulta: " + ex.Message);
            }

            return dt;
        }

        public string ObtenerRol(string usuario)
        {
            string rol = string.Empty;
            string consulta = "SELECT Rol FROM Usuarios WHERE Usuario = @Usuario";

            try
            {
                using (SqlConnection conexion = new SqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@Usuario", usuario);
                        rol = comando.ExecuteScalar()?.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el rol: " + ex.Message);
            }

            return rol;
        }


    }
}
