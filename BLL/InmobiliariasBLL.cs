using System;
using System.Collections.Generic;
using System.Text;
using RioParanaDAL;
using System.Data;

namespace RioParanaBLL
{
    public class InmobiliariasBLL
    {
        InmobiliariasDAL dataAccess;

        public InmobiliariasBLL()
        {
            this.dataAccess = new InmobiliariasDAL();
        }

        public DataTable SelectAllInmobiliarias()
        {
            return this.dataAccess.SelectAllInmobiliarias();
        }
    }
}
