using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RioParanaBLL;
using System.Collections;
using RioParanaOBJ;
using System.Data;

namespace RioParana
{
    public partial class Busquedas : System.Web.UI.Page
    {
        DataTable dt;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CascadingDropDown1.SelectedValue = "1";

                //ddlPaises.SelectedValue = "1";

                //ddlProvincias.SelectedValue = "0";
            }
        }

        protected void CargarFicha(object sender, CommandEventArgs e)
        {
            string s = e.CommandArgument.ToString();
            Session["IdInmueble"] = e.CommandArgument.ToString();
            Response.Redirect("FichaPropiedad.Aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //System.Threading.Thread.Sleep(5000);

            try
            {

                DataGrid1.Visible = false;

                InmueblesBLL bllInmuebles = new InmueblesBLL();

                Inmueble objInmueble = new Inmueble();
                //objInmueble.IDUsuario = Session["UserID"].ToString();
                objInmueble.IDTipoDeInmueble = int.Parse(ddlTipoDeInmueble.SelectedValue.ToString());
                objInmueble.IDOperacion = int.Parse(ddlOperacion.SelectedValue.ToString());
                objInmueble.IDLocalidad = int.Parse(ddlLocalidades.SelectedValue.ToString());
                objInmueble.IDProvincia = int.Parse(ddlProvincias.SelectedValue.ToString());
                objInmueble.IDZona = int.Parse(ddlZonas.SelectedValue.ToString());

                dt = bllInmuebles.SeleccionaInmueblesBusqueda(objInmueble, objInmueble.IDTipoDeInmueble);
                //dt = bllInmuebles.SeleccionaInmueblesBusqueda2(objInmueble.IDTipoDeInmueble, objInmueble.IDOperacion, "IdInmueble");

                if (dt.Rows.Count != 0)
                {
                    DataGrid1.DataSource = null;
                    DataGrid1.DataSource = dt;
                    DataGrid1.CurrentPageIndex = 0;
                    DataGrid1.DataBind();
                    Session["grd_ItemList"] = dt;
                    DataGrid1.Visible = true;

                    //Oculta la busqueda
                    //CollapsiblePanelExtenderBusqueda.Collapsed = true;
                    //CollapsiblePanelExtenderBusqueda.ClientState = "true";

                }
                else if (dt.Rows.Count == 0)
                {




                }
            }
            catch
            {

            }

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
    }
}