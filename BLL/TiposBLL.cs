using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using RioParanaDAL;
using RioParanaOBJ;

namespace RioParanaBLL
{
    public class TiposBLL
    {
        TiposDAL dataAccess;
        public TiposBLL()
        {
            this.dataAccess = new TiposDAL();
        }

        public DataTable SeleccionarTiposInmuebles()
        {
            return this.dataAccess.SeleccionaTipoDeInmuebles();
        }

        public DataTable TraerTipoDeInmuebles()
        {
            return this.dataAccess.TraerTipoDeInmuebles();
        }

        public void EliminaTipoDeInmuebles(string idTipoInmueble)
        {
            try
            {
                this.dataAccess.EliminaTipoDeInmuebles(idTipoInmueble);
            }
            catch{}
        }

        public void UpdateTipoDeInmuebles(Tipos TipoInmueble)
        {
            try
            {
                this.dataAccess.UpdateTipoDeInmuebles(TipoInmueble);
            }
            catch { }
        }

        public void InsertTipoDeInmuebles(Tipos TipoInmueble)
        {
            try
            {
                this.dataAccess.InsertTipoDeInmuebles(TipoInmueble);
            }
            catch { }
        }

        public Tipos TraerTipoDeInmuebles(string idTipoInmueble)
        {
            try
            {
                Tipos objTipos = new Tipos();
                DataTable dt = new DataTable();
                dt = this.dataAccess.TraerTipoDeInmueblesxID(idTipoInmueble);
                if (dt.Rows.Count > 0)
                {
                    objTipos.Tipo = dt.Rows[0]["Tipo"].ToString();
                    objTipos.Menu = dt.Rows[0]["NombreMenu"].ToString();
                    objTipos.Padre = dt.Rows[0]["TipoPadre"].ToString();
                    objTipos.Mostrar = dt.Rows[0]["Mostrar"].ToString();
                }
                return objTipos;
            }
            catch { throw new Exception("Ocurrio un error"); }
        }
    }
}
