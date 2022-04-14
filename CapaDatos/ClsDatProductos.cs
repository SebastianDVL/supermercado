using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
namespace CapaDatos
{
    public class ClsDatProductos
    {
        ClsConexion oConexion = new ClsConexion();
        SqlCommand cmd = new SqlCommand();  

        [Obsolete]
        public DataSet consultarProducto(ClsEntProductos oEntProductos)
        {
            try
            {
                cmd.Connection = oConexion.conectar("supermercado");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "consultar_producto";
                cmd.Parameters.Add("@pcod_producto", oEntProductos.CodProducto);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        [Obsolete]
        public bool guardar_producto(ClsEntProductos oEntProductos)
        {
            try
            {
                cmd.Connection = oConexion.conectar("supermercado");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "guardar_producto";
                cmd.Parameters.Add("@pcod_producto", oEntProductos.CodProducto);
                cmd.Parameters.Add("@pnombre_producto",oEntProductos.Nombre);
                cmd.Parameters.Add("@pmarca_producto",oEntProductos.Marca);
                cmd.Parameters.Add("@pprecio",oEntProductos.Precio);
                cmd.Parameters.Add("@pexistencias",oEntProductos.Existencias);
                cmd.Parameters.Add("@pdescuento",oEntProductos.Descuento);
                cmd.ExecuteNonQuery();
                return true;
            }catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        [Obsolete]
        public bool borrar_producto(ClsEntProductos oEntProductos)
        {
            try
            {
                cmd.Connection = oConexion.conectar("supermercado");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "borrar_producto";
                cmd.Parameters.Add("@pcod_producto", oEntProductos.CodProducto);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        [Obsolete]
        public bool actualizar_producto(ClsEntProductos oEntProductos)
        {
            try
            {
                cmd.Connection = oConexion.conectar("supermercado");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "actualizar_producto";
                cmd.Parameters.Add("@pcod_producto", oEntProductos.CodProducto);
                cmd.Parameters.Add("@pnom_producto", oEntProductos.Nombre);
                cmd.Parameters.Add("@pmarca", oEntProductos.Marca);
                cmd.Parameters.Add("@pexistencias", oEntProductos.Existencias);
                cmd.Parameters.Add("@pprecio", oEntProductos.Precio);
                cmd.Parameters.Add("@pdescuento", oEntProductos.Descuento);
                cmd.ExecuteNonQuery();
                return true;

            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
