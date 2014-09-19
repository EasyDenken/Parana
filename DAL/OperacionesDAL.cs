using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using System.Data;

namespace RioParanaDAL
{
    public class OperacionesDAL : DBAccessBase
    {
        public DataTable SeleccionaOperacionDeInmuebles()
        {
            this.OpenConnection();
            try
            {
                return this.ExecuteTable(@"SELECT 0 as IdOperacion, 'Seleccione un Tipo De Operacion' as Operacion
                                            UNION
                                           SELECT IdOperacion, Operacion from Operaciones where IdOperacion<>3", CommandType.Text, "");
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
