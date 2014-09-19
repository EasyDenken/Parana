using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using  RioParanaBLL;

namespace RioParana.Publica
{
    public partial class PropiedadesDestacadas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CalcularSesion();
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


        protected void DataGrid1_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            CalcularSesion();
            dgDestacados.CurrentPageIndex = e.NewPageIndex;
            if (Session["grd_ItemList"] != null)
            {
                dgDestacados.DataSource = Session["grd_ItemList"];
                dgDestacados.DataBind();
            }
            //Session["grd_ItemList"] = null;//end the session
        }

        protected string URLImagen(string IdInmueble)
        {
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

        protected void CalcularSesion()
        {
            if (Session["UserID"] == null)
            {
                Response.Redirect("~/login.aspx");
            }
        }

        protected void dgDestacados_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            //FORMATEA ROWS
            if (e.Row.RowType == DataControlRowType.DataRow)
            {//ASIGNA EVENTOS
                e.Row.Attributes.Add("OnMouseOver", "Resaltar_On(this);");
                e.Row.Attributes.Add("OnMouseOut", "Resaltar_Off(this);");
                e.Row.Attributes["OnClick"] = Page.ClientScript.GetPostBackClientHyperlink(dgDestacados, "Select$" + e.Row.RowIndex.ToString());
            }
        }
    }
}