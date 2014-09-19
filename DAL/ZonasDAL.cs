using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace RioParanaDAL
{
    public class ZonasDAL : DBAccessBase
    {
        public DataTable SelectZonasPorLocalidad(int idLocalidad)
        {
            this.OpenConnection();
            try
            {

                return this.ExecuteTable(@"SELECT 0 as IdZona, 'Seleccione una Zona' as Nombre
                                            UNION ALL
                                            SELECT IdZona, Nombre
                                            FROM Zonas 
                                            WHERE IdLocalidad = " + idLocalidad
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
