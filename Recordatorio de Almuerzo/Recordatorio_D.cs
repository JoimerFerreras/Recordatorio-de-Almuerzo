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
        public DataTable ListadoRecordatorios(bool RangoFecha, DateTime FechaInicial, DateTime FechaFinal)
        {
            DataTable tabla = new DataTable();
            tabla.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.Text;
            comando.CommandText = $@"SELECT
                                    Id_Recordatorio,
                                    Fecha AS Fecha_Order, 
                                    FORMAT(Fecha, 'dd/MM/yyyy') AS Fecha,
                                    FORMAT(Fecha, 'hh:mm tt') AS Hora,
                                    CASE DATEPART(dw, Fecha)
	                                    WHEN 1 THEN 'Domingo'
	                                    WHEN 2 THEN 'Lunes'
	                                    WHEN 3 THEN 'Martes'
	                                    WHEN 4 THEN 'Miércoles'
	                                    WHEN 5 THEN 'Jueves'
	                                    WHEN 6 THEN 'Viernes'
	                                    WHEN 7 THEN 'Sábado'
                                    END AS Dia,
                                    REPLACE(REPLACE(Recordatorio , '1','SI'), '0','NO') AS Recordatorio
                                    FROM Recordatorios ";

            if (RangoFecha == true)
            {
                comando.CommandText += $@"WHERE Fecha BETWEEN '{string.Format("{0:yyyy-MM-dd}", FechaInicial)} 00:00:00' AND '{string.Format("{0:yyyy-MM-dd}", FechaFinal)} 23:59:59' ";
            }

            comando.CommandText += $@"ORDER BY Fecha_Order ASC";

            leer = comando.ExecuteReader();
            tabla.Load(leer);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable ListadoRecordatoriosPendientes()
        {
            DataTable tabla = new DataTable();
            tabla.Clear();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.Text;
            comando.CommandText = $@"SELECT * FROM Recordatorios WHERE (Fecha BETWEEN '{string.Format("{0:yyyy-MM-dd}", DateTime.Now)} 00:00:00' AND '{string.Format("{0:yyyy-MM-dd}", DateTime.Now)} 23:59:59') AND Confirmacion = 0 AND Recordatorio = 1";
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
            comando.CommandText = $@"DELETE FROM Recordatorios WHERE Id_Recordatorio = {Id_Registro}";
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        
        public void ConfirmarRecordatorio(int Id_Recordatorio)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandType = CommandType.Text;
            comando.CommandText = $@"UPDATE Recordatorios SET Confirmacion = 1 WHERE Id_Recordatorio = {Id_Recordatorio};";
            leer = comando.ExecuteReader();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        #endregion

    }
}
