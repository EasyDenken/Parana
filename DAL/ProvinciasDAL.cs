using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace RioParanaDAL
{
    public class ProvinciasDAL : DBAccessBase
    {
        public DataTable SelectProvincias()
        {
            this.OpenConnection();
            try
            {
                return this.ExecuteTable(@"SELECT 0 as idProvincia, 'Seleccione una Provincia' as Nombre
                                            UNION 
                                           SELECT idProvincia, Nombre FROM Provincias"
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

        public DataTable SelectProvinciasPorPais(int idPais)
        {
            this.OpenConnection();
            try
            {
                if (idPais == 1)
                {
                    return this.ExecuteTable(@"SELECT 20 as IdProvincia, 'SANTA FE' as Nombre
                                            UNION ALL
                                            SELECT IdProvincia, Nombre
                                            FROM Provincias 
                                            WHERE (IdPais = " + idPais + ") AND (Nombre <> N'SANTA FE')"
                                            , CommandType.Text, "");
                }

                else
                {
                    return this.ExecuteTable(@"SELECT IdProvincia, Nombre
                                            FROM Provincias 
                                            WHERE (IdPais = " + idPais + ")"
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

        public DataTable SelectProvinciasPorPaisBusqueda(int idPais)
        {
            this.OpenConnection();
            try
            {
                if (idPais == 1)
                {
                    return this.ExecuteTable(@"SELECT 20 as IdProvincia, 'SANTA FE' as Nombre
                                            UNION ALL
                                            SELECT IdProvincia, Nombre
                                            FROM Provincias 
                                            WHERE (IdPais = " + idPais + ") AND (Nombre <> N'SANTA FE')"
                                            , CommandType.Text, "");
                }

                else
                {
                    return this.ExecuteTable(@"SELECT 0 as IdProvincia, 'Seleccione una Provincia' as Nombre
                                            UNION ALL
                                            SELECT IdProvincia, Nombre
                                            FROM Provincias 
                                            WHERE (IdPais = " + idPais + ")"
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
