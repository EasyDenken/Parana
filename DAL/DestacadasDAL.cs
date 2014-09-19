using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using System.Data;

namespace RioParanaDAL
{
    public class DestacadasDAL : DBAccessBase
    {
        public DataTable SeleccionaInmueblesDestacados()
        {
            this.OpenConnection();
            try
            {
                return this.ExecuteTable(@"SELECT IdDestacadas from Destacadas", CommandType.Text, "");
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

        public void Update(int idPropiedad, int id)
        {
            this.OpenConnection();
            this.BeginTransaction();
            try
            {
                this.ExecuteTable(@"UPDATE [Destacadas] set [IdDestacadas] = " + idPropiedad + " where [Id] = " + id , CommandType.Text, "");

                this.CommitTransaction();
            }
            catch (Exception ex)
            {
                this.RollbackTransaction();
                throw ex;
            }
            finally
            {
                this.CloseConnection();
            }
        }
    }
}
