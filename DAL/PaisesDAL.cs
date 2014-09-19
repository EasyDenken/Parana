using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace RioParanaDAL
{
    public class PaisesDAL : DBAccessBase
    {
        public DataTable SelectPaises()
        {
            this.OpenConnection();
            try
            {
                return this.ExecuteTable(@"SELECT IdPais, Nombre FROM Paises"
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



        public DataTable SelectPaisesBusqueda()
        {
            this.OpenConnection();
            try
            {
                return this.ExecuteTable(@"SELECT 0 as IdPais, 'Seleccione un Pais' as Nombre
                                            UNION ALL
                                            SELECT IdPais, Nombre FROM Paises"
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
