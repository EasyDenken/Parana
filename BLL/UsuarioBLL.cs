using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using RioParanaDAL;
using RioParanaOBJ;

namespace RioParanaBLL
{
    public class UsuarioBLL
    {
        UsuarioDAL dataAccess;
        public UsuarioBLL()
        {
            this.dataAccess = new UsuarioDAL();
        }

        public DataTable TraeUsuario(string usuario, string password)
        {
            try
            {
                return dataAccess.TraeUsuario(usuario, password);
            }
            catch (Exception exe)
            {
                throw exe;
            }
        }

        public DataTable SelectAll()
        {
            return this.dataAccess.SelectAll();
        }

        public void InsertUsuario(Usuario usuario)
        {
            this.dataAccess.InsertUsuario(usuario);
        }
    }
}