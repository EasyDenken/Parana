using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using RioParanaDAL;

namespace RioParanaBLL
{
    public class DestacadasBLL
    {
        DestacadasDAL dataAccess;
        public DestacadasBLL()
        {
            this.dataAccess = new DestacadasDAL();
        }

        public DataTable SeleccionaInmueblesDestacados()
        {
            return this.dataAccess.SeleccionaInmueblesDestacados();
        }

        public void update(int idPropiedad, int id)
        {
            this.dataAccess.Update(idPropiedad, id);
        } 
    }
}
