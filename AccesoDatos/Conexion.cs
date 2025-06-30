using System;
using MySql.Data.MySqlClient;

namespace Semana5Tarea.AccesoDatos
{
    class Conexion
    {
        private readonly string cadenaConexion =
            "Server=localhost;Database=cuarto_maysep2025;Uid=root;Pwd=;";
        private MySqlConnection conexion;

        public MySqlConnection AbrirConexion() {
            conexion = new MySqlConnection(cadenaConexion);
            conexion.Open();
            return conexion;
        }

        public void CerrarConexion() {
            if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }

    }
}
