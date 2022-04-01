using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace CapaDatos
{
    public class ClsConexion
    {
        [Obsolete]
        public SqlConnection conectar(String conexion)
        {
            try
            {
                SqlConnection oconectar = new SqlConnection(ConfigurationSettings.AppSettings[conexion].ToString());
                oconectar.Open();
                return oconectar;

            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
