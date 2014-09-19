using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace RioParanaDAL
{
    public class InmobiliariasDAL : DBAccessBase
    {
        public DataTable SelectAllInmobiliarias()
        {
            this.OpenConnection();
            try
            {
//                return this.ExecuteTable(@"SELECT 0 as idInmobiliaria, 'Seleccione una Inmobiliaria' as Nombre
//                                            UNION 
//                                           SELECT idInmobiliaria, Nombre FROM Inmobiliarias"
//                    , CommandType.Text, "");

                return this.ExecuteTable(@"SELECT idInmobiliaria, Nombre FROM Inmobiliarias order by Nombre", CommandType.Text, "");
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