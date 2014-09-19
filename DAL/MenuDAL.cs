using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;

namespace RioParanaDAL
{
    public class MenuDAL:DBAccessBase 
    {
        public MenuDAL()
            : base()
        { }

        public MenuDAL(DbConnection Connection, DbTransaction Transaction)
            : base(Connection, Transaction)
        {
        }

        public DataTable MenuByRoleName(string RoleName)
        {
            this.OpenConnection();
            try
            {
                return this.ExecuteTable(string.Format(@"SELECT DISTINCT Menu.* 
                                                           FROM MenuPermissions as PM, Menu, aspnet_Roles as R
                                                          WHERE Menu.MenuID = PM.MenuID AND Menu.ParentID IS NULL AND PM.RoleID = R.RoleId AND R.RoleName IN ({0})", RoleName)
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

        public DataTable SubMenuByRoleName(string RoleName, Int32 ParentID)
        {
            this.OpenConnection();
            try
            {
                return this.ExecuteTable(string.Format(@"SELECT DISTINCT Menu.* 
                                                           FROM MenuPermissions as PM, Menu, aspnet_Roles as R
                                                          WHERE Menu.MenuID = PM.MenuID AND Menu.ParentID IS NOT NULL AND PM.RoleID = R.RoleId AND R.RoleName IN ({0}) AND Menu.ParentID = {1}", RoleName, ParentID)
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
