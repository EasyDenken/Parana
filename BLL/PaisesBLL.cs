using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using RioParanaDAL;

namespace RioParanaBLL
{  
    public class PaisesBLL
    {
        PaisesDAL dataAccess;

        public PaisesBLL()
        {
            this.dataAccess = new PaisesDAL();
        }

        public DataTable SelectPaises()
        {
            return this.dataAccess.SelectPaises();
        }

        public DataTable SelectPaisesBusqueda()
        {
            return this.dataAccess.SelectPaisesBusqueda();
        }
    }
}
