using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ClsEntAdmin
    {
        private string id;
        private string contraseña;

        public string Id { get => id; set => id = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
    }
}
