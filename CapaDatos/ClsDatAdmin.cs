using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class ClsDatAdmin
    {   
        ClsConexion oConexcion = new ClsConexion();
        SqlCommand cmd = new SqlCommand();

        [Obsolete]
        public DataSet consultarAdmin(ClsEntAdmin oEntAdmin)
        {
            try
            {
                cmd.Connection = oConexcion.conectar("supermercado");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "consultar_admin";
                cmd.Parameters.Add("@pid_admin", oEntAdmin.Id);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }   
        }
    }
}
