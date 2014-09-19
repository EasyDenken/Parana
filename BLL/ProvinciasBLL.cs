using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using RioParanaDAL;

namespace RioParanaBLL
{
    public class ProvinciasBLL
    {
        ProvinciasDAL dataAccess;

        public ProvinciasBLL()
        {
            this.dataAccess = new ProvinciasDAL();
        }

        public DataTable SelectProvincias()
        {
            return this.dataAccess.SelectProvincias();
        }

        public DataTable SelectProvinciasPorPais(int idPais)
        {
            return this.dataAccess.SelectProvinciasPorPais(idPais);
        }

        public DataTable SelectProvinciasPorPaisBusqueda(int idPais)
        {
            return this.dataAccess.SelectProvinciasPorPaisBusqueda(idPais);
        }
    }
}
