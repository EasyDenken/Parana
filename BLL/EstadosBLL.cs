using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using RioParanaDAL;

namespace RioParanaBLL
{
    public class EstadosBLL
    {
        EstadosDAL dataAccess;
        public EstadosBLL()
        {
            this.dataAccess = new EstadosDAL();
        }

        public DataTable SeleccionarEstadosDeInmuebles()
        {
            return this.dataAccess.SeleccionaEstadoDeInmuebles();
        }
    }
}
