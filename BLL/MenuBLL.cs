using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using RioParanaDAL;

namespace RioParanaBLL
{
    public class MenuBLL
    {
        MenuDAL dataAccess;

        public MenuBLL()
        {
            dataAccess = new MenuDAL();
        }

        public DataTable MenuByRoleName(string RoleName)
        {
            return dataAccess.MenuByRoleName(RoleName);
        }

        public DataTable SubMenuByRoleName(string RoleName, Int32 ParentID)
        {
            return dataAccess.SubMenuByRoleName(RoleName, ParentID);
        }
    }
}
