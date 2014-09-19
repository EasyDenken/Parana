using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using RioParanaOBJ;

namespace RioParanaDAL
{
    public class UsuarioDAL : DBAccessBase
    {
        public DataTable SelectAll()
        {
            this.OpenConnection();
            try
            {
                return this.ExecuteTable(@"SELECT * FROM Usuarios"
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

        public DataTable TraeUsuario(string usuario, string password)
        {
            this.OpenConnection();
            try
            {
                return this.ExecuteTable(string.Format(@"SELECT * FROM Usuarios WHERE Usuario = '{0}' AND Password = '{1}'", usuario, password)
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

        public void InsertUsuario(Usuario usuario)
        {
            this.OpenConnection();
            this.BeginTransaction();
            try
            {
                this.ExecuteNonQuery(string.Format(@"INSERT INTO [Usuarios]
                                                           ([idUsuario]
                                                           ,[Nombre]
                                                           ,[Apellido]
                                                           ,[Dni]
                                                           ,[Telefono]
                                                           ,[Celular]
                                                           ,[IdInmobiliaria])
                                                     VALUES
                                                           ('{0}'
                                                           ,'{1}'
                                                           ,'{2}'
                                                           ,'{3}'
                                                           ,'{4}'
                                                           ,'{5}'
                                                           ,{6})
                                                ", usuario.IdUsuario, usuario.Nombre, usuario.Apellido, usuario.DNI, usuario.Telefono, usuario.Celular, usuario.IdInmobiliaria), CommandType.Text, "");
                this.CommitTransaction();
            }
            catch (Exception exe)
            {
                this.RollbackTransaction();
                throw exe;
            }
            finally
            {
                this.CloseConnection();
            }
        }
    }
}
