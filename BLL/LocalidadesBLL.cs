using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using RioParanaDAL;

namespace RioParanaBLL
{
    public class LocalidadesBLL
    {
        LocalidadesDAL dataAccess;

        public LocalidadesBLL()
        {
            this.dataAccess = new LocalidadesDAL();
        }

        public DataTable SelectLocalidades(int idProvincia)
        {
            return this.dataAccess.SelectLocalidadesPorProvincia(idProvincia);
        }

        public DataTable SelectLocalidadesBusqueda(int idProvincia)
        {
            return this.dataAccess.SelectLocalidadesBusqueda(idProvincia);
        }
    }
}
