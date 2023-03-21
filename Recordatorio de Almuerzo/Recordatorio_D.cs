using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recordatorio_de_Almuerzo
{
    public class Recordatorio_D
    {
        #region Declaraciones
        private ConexionSQL conexion = new ConexionSQL();
        SqlDataReader leer;
        SqlCommand comando = new SqlCommand();
        #endregion

        #region Consultas
        public DataTable ListadoRecordatorios(int Estado)
        {
            DataTable tabla = new DataTable();
            tabla.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.Text;
            comando.CommandText = $@"SELECT 
                                     Id_Rol, 
                                     Nombre_Rol, 
                                     Fecha_Registro, 
                                     REPLACE(REPLACE(Estado, '1', 'Activo'), '0', 'Inactivo') AS Estado FROM Roles ";

            if (Estado > 0)
            {
                comando.CommandText += $@"WHERE Estado = {Estado}";
            }
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }
        #endregion


        #region Mantenimientos

        public void Agregar(DateTime Fecha, int Recordatorio)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.Text;
            comando.CommandText = $@"INSERT INTO Recordatorios(Fecha, Recordatorio) VALUES ('{string.Format("{0:yyyy-MM-dd HH:mm:ss}", Fecha)}', {Recordatorio});";
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void Editar(int Id_Recordatorio, DateTime Fecha, int Recordatorio)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.Text;
            comando.CommandText = $@"UPDATE Recordatorios SET 
                                     Fecha = '{string.Format("{0:yyyy-MM-dd HH:mm:ss}", Fecha)}', 
                                     Recordatorio =  {Recordatorio} 
                                     WHERE Id_Recordatorio = {Id_Recordatorio};";
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        public void Eliminar(int Id_Registro)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.Text;
            comando.CommandText = $@"DELETE FROM Recordatorios WHERE Id_Rol = {Id_Registro}";
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        #endregion
       
    }
}
