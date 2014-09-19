using System;
using System.Collections.Generic;
using System.Text;
using RioParanaDAL;
using System.Data;

namespace RioParanaBLL
{
    public class ImagenesBLL
    {
        ImagenesDAL dataAccess;

        public ImagenesBLL()
        {
            this.dataAccess = new ImagenesDAL();
        }

        public string SelectCantidadImagenesPorInmueble(string IdInmueble)
        {            
            DataTable dt = this.dataAccess.SelectCantidadImagenesPorInmueble(IdInmueble);
            return dt.Rows[0]["cant"].ToString();
        }
    }
}
