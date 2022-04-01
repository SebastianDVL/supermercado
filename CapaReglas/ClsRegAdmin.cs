using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
namespace CapaReglas
{
    public class ClsRegAdmin
    {   
        ClsDatAdmin oDatAdmin = new ClsDatAdmin();

        [Obsolete]
        public DataSet consultarAdmin(ClsEntAdmin oEntAdmin) => oDatAdmin.consultarAdmin(oEntAdmin);
    }
}
