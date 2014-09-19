using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace RioParanaDAL
{
    public class LocalidadesDAL : DBAccessBase
    {
        public DataTable SelectLocalidadesPorProvincia(int idProvincia)
        {
            this.OpenConnection();
            try
            {

                if (idProvincia == 20)
                {
                    return this.ExecuteTable(@"SELECT 16622 as idLocalidad, 'Rosario' as Nombre
                                            UNION ALL
                                            SELECT IdLocalidad, Nombre
                                            FROM Localidades 
                                            WHERE (IdProvincia = " + idProvincia + ") AND (Nombre <> N'Rosario')"
                                            , CommandType.Text, "");
                }

                else
                {
                    return this.ExecuteTable(@"SELECT 0 as idLocalidad, 'Seleccione una Localidad' as Nombre
                                            UNION ALL
                                            SELECT IdLocalidad, Nombre
                                            FROM Localidades 
                                            WHERE (IdProvincia = " + idProvincia + ")"
                                            , CommandType.Text, "");
                }
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

        public DataTable SelectLocalidadesBusqueda(int idProvincia)
        {
            this.OpenConnection();
            try
            {
                if (idProvincia == 20)
                {
                    return this.ExecuteTable(@"SELECT 16622 as idLocalidad, 'Rosario' as Nombre
                                            UNION ALL
                                            SELECT IdLocalidad, Nombre
                                            FROM Localidades 
                                            WHERE (IdProvincia = " + idProvincia + ") AND (Nombre <> N'Rosario')"
                                            , CommandType.Text, "");
                }

                else
                {
                    return this.ExecuteTable(@"SELECT 0 as idLocalidad, 'Selecione una Localidad' as Nombre
                                            UNION ALL
                                            SELECT IdLocalidad, Nombre
                                            FROM Localidades 
                                            WHERE (IdProvincia = " + idProvincia + ")"
                                            , CommandType.Text, "");
                }
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
