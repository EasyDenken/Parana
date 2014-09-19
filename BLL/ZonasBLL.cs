using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using RioParanaDAL;

namespace RioParanaBLL
{
    public class ZonasBLL
    {
        ZonasDAL dataAccess;

        public ZonasBLL()
        {
            this.dataAccess = new ZonasDAL();
        }

        public DataTable SelectLocalidadesPorProvincia(int IdLocalidad)
        {
            return this.dataAccess.SelectZonasPorLocalidad(IdLocalidad);
        }

        public DataTable SelectZonasPorLocalidad(int IdLocalidad)
        {
            DataTable dt;
            dt = this.dataAccess.SelectZonasPorLocalidad(IdLocalidad);
            if (dt.Rows.Count == 1)
            {
                dt.Rows[0]["IdZona"] = -1;
            }
            return dt;
            //return this.dataAccess.SelectZonasPorLocalidad(IdLocalidad);
        }
    }
}
