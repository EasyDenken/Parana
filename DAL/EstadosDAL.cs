using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using System.Data;

namespace RioParanaDAL
{
    public class EstadosDAL : DBAccessBase
    {
        public DataTable SeleccionaEstadoDeInmuebles()
        {
            this.OpenConnection();
            try
            {
                return this.ExecuteTable(@"SELECT 0 as IdEstado, 'Seleccione un Estado' as Estado
                                            UNION
                                            SELECT IdEstado, Estado from Estados", CommandType.Text, "");
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
