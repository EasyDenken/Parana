using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace RioParanaDAL
{
    public class ImagenesDAL : DBAccessBase
    {
        public DataTable SelectCantidadImagenesPorInmueble(string IdInmueble)
        {
            this.OpenConnection();
            try
            {
                return this.ExecuteTable(@"SELECT count(IdImagen) as cant from Imagenes WHERE IdInmueble  = '" + IdInmueble + "'"
                    , CommandType.Text, "");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.CloseConnection();
            }
        }
    }
}
