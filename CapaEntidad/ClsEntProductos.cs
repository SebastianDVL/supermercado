using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ClsEntProductos
    {
        private String codProducto;
        private String nombre;
        private String marca;
        private int precio;
        private int existencias;
        private int descuento;
        private bool activo;

        public string CodProducto { get => codProducto; set => codProducto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Marca { get => marca; set => marca = value; }
        public int Precio { get => precio; set => precio = value; }
        public int Existencias { get => existencias; set => existencias = value; }
        public int Descuento { get => descuento; set => descuento = value; }
        public bool Activo { get => activo; set => activo = value; }
    }
}
