using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using RioParanaBLL;
using RioParanaDAL;
using RioParanaOBJ;
using System.Data;

namespace RioParana
{

    public partial class WebForm1 : System.Web.UI.Page
    {
        DataTable dt;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CargarFicha(object sender, CommandEventArgs e)
        {
            string s = e.CommandArgument.ToString();
            Session["IdInmueble"] = e.CommandArgument.ToString();
            Response.Redirect("FichaPropiedad.Aspx");
        }

        public string Moneda(string moneda)
        {
            if (moneda == "P")
            {
                return "ARS$";
            }
            else if (moneda == "D")
            {
                return "US$";
            }
            else
            {
                return "";
            }
        }

        public string precio(string precio)
        {
            string p = string.Format("{0:#,##0.##}", Convert.ToDouble(precio));

            return p;
        }

        public string piso(string piso)
        {
            string p;
            if (piso != "")
            {
                p = "Piso: " + piso;
            }
            else
            {
                p = "";
            }

            return p;
        }

        protected string URLImagen(string IdInmueble)
        {
            ////if (System.IO.File.Exists("~\\Image_Upload\\" + IdInmueble + "-" + "1" + "_thumb.jpg"))
            ////{
            //    return "~\\Image_Upload\\" + IdInmueble + "-" + "1" + "_thumb.jpg";
            ////}
            ////else
            ////{
            ////    return "~\\Image_Upload\\corel-edificio.jpg";
            ////}

            Boolean strFoto;

            string strRutaFoto = Server.MapPath("~\\Image_Upload\\" + IdInmueble + "-" + "01" + "_thumb.jpg");

            strFoto = (System.IO.File.Exists(strRutaFoto));

            if (strFoto)
            {

                return "~\\Image_Upload\\" + IdInmueble + "-" + "01" + "_thumb.jpg";
            }
            else
            {

                return "~\\Image_Upload\\corel-edificio.jpg";
            }
        }

        protected void DataGrid1_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            DataGrid1.CurrentPageIndex = e.NewPageIndex;
            if (Session["grd_ItemList"] != null)
            {
                DataGrid1.DataSource = Session["grd_ItemList"];
                DataGrid1.DataBind();
            }
            //Session["grd_ItemList"] = null;//end the session
        }

        protected void CargarGrilla(object sender, CommandEventArgs e)
        {            
            
            try
            {
                DataGrid1.Visible = false;

                InmueblesBLL bllInmuebles = new InmueblesBLL();

                ArrayList arlInmobiliarias = new ArrayList();

                Inmueble objInmueble = new Inmueble();

                if (e.CommandArgument.ToString() == "1 AMBIENTE")
                {
                    dt = bllInmuebles.SeleccionaInmueblesBusqueda(objInmueble, 3);
                }
                else if (e.CommandArgument.ToString() == "1 DORMITORIO")
                {
                    dt = bllInmuebles.SeleccionaInmueblesBusqueda(objInmueble, 4);
                }
                else if (e.CommandArgument.ToString() == "2 DORMITORIOS")
                {
                    dt = bllInmuebles.SeleccionaInmueblesBusqueda(objInmueble, 5);
                }
                
                if (dt.Rows.Count != 0)
                {
                    DataGrid1.DataSource = null;
                    DataGrid1.DataSource = dt;
                    DataGrid1.CurrentPageIndex = 0;
                    DataGrid1.DataBind();
                    Session["grd_ItemList"] = dt;
                    DataGrid1.Visible = true;
                }
                else if (dt.Rows.Count == 0)
                {

                }
            }
            catch
            {

            }
        }

        public ArrayList FetchMailItems()
        {
            InmueblesBLL bllInmuebles = new InmueblesBLL();
            Inmueble objInmueble = new Inmueble();
            ArrayList mailItems = new ArrayList();


            mailItems.Add(new { Name = "1 AMBIENTE", ImageUrl = "img/mailbox.gif" });
            mailItems.Add(new { Name = "1 DORMITORIO", ImageUrl = "img/inbox.gif" });
            mailItems.Add(new { Name = "2 DORMITORIOS", ImageUrl = "img/drafts.gif" });
            mailItems.Add(new { Name = "3 DORMITORIOS", ImageUrl = "img/outbox.gif" });
            mailItems.Add(new { Name = "4 DORMITORIOS O MAS", ImageUrl = "img/junk.gif" });

            return mailItems;
        }

        public ArrayList FetchNoteItems()
        {
            InmueblesBLL bllInmuebles = new InmueblesBLL();
            Inmueble objInmueble = new Inmueble();
            ArrayList mailItems = new ArrayList();
            mailItems.Add(new { Name = "Icons", ImageUrl = "_assets/img/note_small.gif", url = "http://www.grupoinci.com.ar/" });
            mailItems.Add(new { Name = "Note List", ImageUrl = "_assets/img/note_small.gif", url = "http://www.grupoinci.com.ar/" });
            mailItems.Add(new { Name = "Last Seven Days", ImageUrl = "_assets/img/note_small.gif", url = "http://www.grupoinci.com.ar/" });
            mailItems.Add(new { Name = "By Category", ImageUrl = "_assets/img/note_small.gif", url = "http://www.grupoinci.com.ar/" });
            mailItems.Add(new { Name = "By Color", ImageUrl = "_assets/img/note_small.gif", url = "http://www.grupoinci.com.ar/" });

            return mailItems;
        }

        public ArrayList FetchContactItems()
        {
            ArrayList mailItems = new ArrayList();
            InmueblesBLL bllInmuebles = new InmueblesBLL();
            Inmueble objInmueble = new Inmueble();
            mailItems.Add(new { Name = "Address Cards", ImageUrl = "_assets/img/contact_small.gif", url = "http://www.grupoinci.com.ar/" });
            mailItems.Add(new { Name = "Detailed Address List", ImageUrl = "_assets/img/contact_small.gif", url = "http://www.grupoinci.com.ar/" });
            mailItems.Add(new { Name = "By Category", ImageUrl = "_assets/img/contact_small.gif", url = "http://www.grupoinci.com.ar/" });
            mailItems.Add(new { Name = "By Company", ImageUrl = "_assets/img/contact_small.gif", url = "http://www.grupoinci.com.ar/" });
            mailItems.Add(new { Name = "By Follow-up Flag", ImageUrl = "_assets/img/contact_small.gif", url = "http://www.grupoinci.com.ar/" });

            return mailItems;
        }
    }
}