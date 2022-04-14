using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using System.Data;
namespace CapaReglas
{
    public class ClsRegProductos
    {
        ClsDatProductos oDatProduct = new ClsDatProductos();
        [Obsolete]
        public DataSet consultarProducto(ClsEntProductos oEntProduct) => oDatProduct.consultarProducto(oEntProduct);
        [Obsolete]
        public bool guardarProducto(ClsEntProductos oEntProduct)=>oDatProduct.guardar_producto(oEntProduct);

        [Obsolete]
        public bool borrarProducto(ClsEntProductos oEntProductos)=>oDatProduct.borrar_producto(oEntProductos);
        [Obsolete]
        public bool actualizarProducto(ClsEntProductos oEntProductos) => oDatProduct.actualizar_producto(oEntProductos);
    }
}
