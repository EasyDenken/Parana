using System.Text;
using System.Data;
using RioParanaDAL;

namespace RioParanaBLL
{
    public class OperacionesBLL
    {
        OperacionesDAL dataAccess;
        public OperacionesBLL()
        {
            this.dataAccess = new OperacionesDAL();
        }

        public DataTable SeleccionarOperacionDeInmuebles()
        {
            return this.dataAccess.SeleccionaOperacionDeInmuebles();
        }
    }
}
