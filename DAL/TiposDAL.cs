using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using System.Data;
using RioParanaOBJ;

namespace RioParanaDAL
{
    public class TiposDAL : DBAccessBase
    {
        public DataTable SeleccionaTipoDeInmuebles()
        {
            this.OpenConnection();
            try
            {
                return this.ExecuteTable(@"SELECT 0 as IdTipoDeInmueble, 'Seleccione un Tipo De Inmueble' as Tipo
                                            UNION
                                        SELECT IdTipoDeInmueble, Tipo from TiposDeInmuebles", CommandType.Text, "");
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

        public DataTable TraerTipoDeInmuebles()
        {
            this.OpenConnection();
            try
            {
                return this.ExecuteTable(@"SELECT * FROM TiposDeInmuebles ORDER BY TipoPadre", CommandType.Text, "");
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

        public DataTable TraerTipoDeInmueblesxID(string idTipoInmueble)
        {
            this.OpenConnection();
            try
            {
                return this.ExecuteTable(@"SELECT * FROM TiposDeInmuebles WHERE idTipoDeInmueble = " + idTipoInmueble, CommandType.Text, ""); ;
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

        public void UpdateTipoDeInmuebles(Tipos TipoInmueble)
        {
            this.OpenConnection();
            try
            {
                string tipo = string.Format(@"UPDATE TiposDeInmuebles SET Tipo = '{0}', TipoPadre = '{1}', NombreMenu = '{2}', Mostrar = '{3}' WHERE IdTipoDeInmueble = {4}", TipoInmueble.Tipo, TipoInmueble.Padre, TipoInmueble.Menu, TipoInmueble.Mostrar, TipoInmueble.IDTipoInmueble);
                this.ExecuteNonQuery(tipo, CommandType.Text, "");
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

        public void EliminaTipoDeInmuebles(string idTipoInmueble)
        {
            this.OpenConnection();
            try
            {
                this.ExecuteTable(@"DELETE FROM TiposDeInmuebles WHERE IdTipoDeInmueble = " + idTipoInmueble, CommandType.Text, "");
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

        public void InsertTipoDeInmuebles(Tipos TipoInmueble)
        {
            this.OpenConnection();
            try
            {
                string tipo = string.Format(@"INSERT INTO TiposDeInmuebles (Tipo, TipoPadre, NombreMenu, Mostrar) VALUES ('{0}','{1}', '{2}',{3})", TipoInmueble.Tipo, TipoInmueble.Padre, TipoInmueble.Menu, TipoInmueble.Mostrar, TipoInmueble.IDTipoInmueble);
                this.ExecuteNonQuery(tipo, CommandType.Text, "");
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
