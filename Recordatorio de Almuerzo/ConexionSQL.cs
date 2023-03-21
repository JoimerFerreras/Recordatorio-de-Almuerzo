using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recordatorio_de_Almuerzo
{
    public class ConexionSQL
    {
        #region Declaraciones

        //Conexion local Casa
        //private SqlConnection Conexion = new SqlConnection("Data Source=DESKTOP-3DD4AOQ\\SQLSERVER2022;Initial Catalog= Recordatorio_Almurezos; Integrated Security=False;User ID= sa; Password= JEfc2707");

        //Conexion server en el trabajo
        private SqlConnection Conexion = new SqlConnection("Data Source=PTC-ANALAISTA\\PTCSQL;Initial Catalog= Recordatorio_Almuerzos; Integrated Security=False;User ID= sa; Password= spn");

        #endregion


        #region Logica
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();

            return Conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();

            return Conexion;
        }
        #endregion
    }
}
