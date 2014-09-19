using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RioParanaBLL;
using RioParanaOBJ;
using System.Data;
using System.Drawing;
using System.IO;
using Artem.Web.UI.Controls;
using GoogleGeocoder;
using System.Globalization;
using AjaxControlToolkit;

namespace RioParana
{
    public partial class FichaPropiedad : System.Web.UI.Page
    {
        DataTable dt;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["IdInmueble"] == null || Session["IdInmueble"].ToString() == "")
                    Response.Redirect("Propiedades.aspx");
                try
                {
                    InmueblesBLL bllInmuebles = new InmueblesBLL();

                    dt = bllInmuebles.SeleccionaInmueblesPorID(Convert.ToInt32(Session["IdInmueble"].ToString()));


                    if (dt.Rows.Count != 0)
                    {
                        Session["grd_ItemList2"] = dt;

                        LlenarDetailsView();

                        DetailsView1.DataSource = dt;
                        DetailsView1.DataBind();

                        bindData();

                        GoogleMarker marker = new GoogleMarker(dt.Rows[0]["Calle"].ToString() + " " + dt.Rows[0]["Numero"].ToString() + "," + dt.Rows[0]["NombreLocalidad"].ToString() + "," + dt.Rows[0]["NombreProvincia"].ToString());

                        GoogleMap1.Markers.Add(marker);

                        Coordinate coordinate = Geocode.GetCoordinates(dt.Rows[0]["Calle"].ToString() + " " + dt.Rows[0]["Numero"].ToString() + "," + dt.Rows[0]["NombreLocalidad"].ToString() + "," + dt.Rows[0]["NombreProvincia"].ToString());
                        decimal latitude = coordinate.Latitude;
                        decimal longitude = coordinate.Longitude;





                        GoogleMap1.Latitude = convert(latitude);//-32.9400639;

                        GoogleMap1.Longitude = convert(longitude);//-60.6600255;

                        marker.Text = dt.Rows[0]["Calle"].ToString() + " " + dt.Rows[0]["Numero"].ToString() + "," + dt.Rows[0]["NombreLocalidad"].ToString() + "," + dt.Rows[0]["NombreProvincia"].ToString();

                        string g = marker.ToJsonString();

                    }
                    else if (dt.Rows.Count == 0)
                    {
                    }
                }
                catch
                {

                }
            }


        }

        protected double convert(decimal numero)
        {
            string db;
            string numeros = numero.ToString();
            string inicio = numeros.Substring(0, 1);
            if (inicio == "-")
            {
                db = numeros.Substring(0, 3) + "," + numeros.Substring(3);
            }
            else
            {
                db = numeros.Substring(0, 2) + "," + numeros.Substring(3);

            }

            decimal d = Convert.ToDecimal(db);

            return (double)d;
        }

        protected void LlenarDetailsView()
        {

            bound("TipoDeInmueble", "Tipo de Inmueble:");
            bound("Estado", "Estado del Inmueble:");
            bound("NombreProvincia", "Provincia:");
            bound("NombreLocalidad", "Localidad:");
            bound("Zona", "Zona:");
            bound("Piso", "Piso:");
            bound("Departamento", "Departamento:");
            bound("Calle1", "Entre Calle:");
            bound("Calle2", "Y Calle:");
            bound("MetroCuadrados", "Metros cuadrados Cubiertos:");
            bound("MetrosCuadradosSemiCub", "Metros cuadrados Semicubiertos:");
            bound("Frente", "Frente:");
            bound("Fondo", "Fondo:");
            bound("Posicion", "Posición:");
            bound("Cocheras", "Cochera:");
            bound("Antiguedad", "Antigüedad:");
            bound("AntiguedadA", "Años de Antigüedad:");
            bound("Operacion", "Operación del Inmueble:");
            bound("PrecioVenta", "Precio de Venta:");
            bound("PrecioAlquiler", "Precio de Alquiler:");
            bound("Comision", "Comisión (%):");
            bound("FechaAlta", "Fecha de Alta en el Sistema:");
            bound("FechaActualiza", "Fecha de Última Actualización:");
        }

        protected void bound(string nombreCampo, string nombreLabel)
        {
            if (dt.Rows[0][nombreCampo].ToString() != "0" && dt.Rows[0][nombreCampo] != null && dt.Rows[0][nombreCampo].ToString() != "")
            {
                BoundField bound = new BoundField();


                if (nombreCampo == "PrecioVenta")
                {
                    if (dt.Rows[0]["MonedaVenta"].ToString() == "P")
                    {
                        bound.HeaderText = nombreLabel + " (ARS$)";
                    }
                    else if (dt.Rows[0]["MonedaVenta"].ToString() == "D")
                    {
                        bound.HeaderText = nombreLabel + " (US$)";
                    }
                }
                else if (nombreCampo == "PrecioAlquiler")
                {
                    if (dt.Rows[0]["MonedaAlquiler"].ToString() == "P")
                    {
                        bound.HeaderText = nombreLabel + " (ARS$)";
                    }
                    else if (dt.Rows[0]["MonedaAlquiler"].ToString() == "D")
                    {
                        bound.HeaderText = nombreLabel + " (US$)";
                    }
                }
                else
                {
                    bound.HeaderText = nombreLabel;
                }

                bound.DataField = nombreCampo;

                bound.HeaderStyle.HorizontalAlign = HorizontalAlign.Right;
                bound.ItemStyle.HorizontalAlign = HorizontalAlign.Left;
                DetailsView1.Fields.Add(bound);
            }

        }

        protected void Linkbutton1_Click1(object sender, EventArgs e)
        {
            if (Session["grd_ItemList2"] != null)
            {
                dt = (DataTable)Session["grd_ItemList2"];


                string direccion = dt.Rows[0]["Calle"].ToString() + " " + dt.Rows[0]["Numero"].ToString();
                string localidad = dt.Rows[0]["NombreLocalidad"].ToString();
                string provincia = dt.Rows[0]["NombreProvincia"].ToString();


                string popupScript = "<script language='JavaScript'>" +
                                     "window.open('Maps.aspx?&direccion=" +
                                     direccion +
                                     "&ciudad=" +
                                     localidad +
                                     "&provincia=" +
                                     provincia + "'" +
                                     ", 'CustomPopUp', " +
                                     "'width=510, height=360, menubar=yes, resizable=no')" +
                                     "</script>";

                Page.RegisterStartupScript("PopupScript", popupScript);
            }
        }

        protected void DetailsView1_ItemCommand(object sender, DetailsViewCommandEventArgs e)
        {
            if (e.CommandName == "Editar")
            {

                dt = (DataTable)Session["grd_ItemList2"];

                if (dt.Rows[0]["IdUsuario"].ToString() == Session["UserID"].ToString())
                {
                    Session["IdInmueble"] = dt.Rows[0]["IdInmueble"].ToString();

                    Response.Redirect("ModificarPropiedad.aspx");
                }
            }

            else if (e.CommandName == "Eliminar")
            {

                dt = (DataTable)Session["grd_ItemList2"];

                if (dt.Rows[0]["IdUsuario"].ToString() == Session["UserID"].ToString())
                {
                    Session["IdInmueble"] = dt.Rows[0]["IdInmueble"].ToString();

                    InmueblesBLL bllInmuebles = new InmueblesBLL();
                    bllInmuebles.Delete(Session["IdInmueble"].ToString());


                    for (int i = 1; i <= 10; i++)
                    {
                        try
                        {
                            File.Delete(Server.MapPath("~\\Image_Upload\\" + Session["IdInmueble"].ToString() + "-" + i + ".jpg"));
                            File.Delete(Server.MapPath("~\\Image_Upload\\" + Session["IdInmueble"].ToString() + "-" + i + "_thumb.jpg"));
                        }
                        catch
                        {
                        }
                    }

                    Response.Redirect("MisPropiedades.aspx");
                }
            }

        }

        public string precio(string precio)
        {
            string p = string.Format("{0:#,##0.##}", Convert.ToDouble(precio));
            return p;
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

        private void bindData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("grdImage", typeof(string));

            dt.Columns.Add("grdImage1", typeof(string));

            DataRow dr;
            string[] files = Directory.GetFiles(Server.MapPath("~\\Image_Upload\\"), Session["IdInmueble"].ToString() + "-" + "*_thumb.jpg");
            Array.Sort(files);
            foreach (string file in files)
            {
                dr = dt.NewRow();
                dr[0] = ResolveUrl("ThumbnailCreator.aspx?ImageId=" + file);
                string file2 = file.Substring(0, file.Length - 10);
                dr[1] = ResolveUrl("ThumbnailCreator.aspx?ImageId=" + file2 + ".jpg");
                dt.Rows.Add(dr);
            }

            grdImageViewer.DataSource = dt;
            Session["grd_Image"] = dt;
            grdImageViewer.DataBind();
        }
        protected void grdImageViewer_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdImageViewer.PageIndex = e.NewPageIndex;
            if (Session["grd_Image"] != null)
            {
                grdImageViewer.DataSource = Session["grd_Image"];
                grdImageViewer.DataBind();
            }
        }
        protected void grdImageViewer_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes.Add("OnMouseOver", "On(this);");
                e.Row.Attributes.Add("OnMouseOut", "Off(this);");
                e.Row.Attributes["OnClick"] = Page.ClientScript.GetPostBackClientHyperlink(grdImageViewer, "Select$" + e.Row.RowIndex.ToString());
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ModalPopupExtender modal = DetailsView1.FindControl("ModalPopupExtender1") as ModalPopupExtender;
            Panel pnlObs = DetailsView1.FindControl("Panel2") as Panel;
            pnlObs.Style["dislplay"] = "none";
            modal.Hide();
        }
        protected void Button1_Click1(object sender, EventArgs e)
        {
            ModalPopupExtender modal = DetailsView1.FindControl("ModalPopupExtender1") as ModalPopupExtender;
            Panel pnlObs = DetailsView1.FindControl("Panel2") as Panel;
            pnlObs.Style["dislplay"] = "block";
            modal.Show();
        }
        protected void btnOpcion_Click(object sender, EventArgs e)
        {
            if (ddlOpciones.SelectedIndex == 0)
            {

            }
            else if (ddlOpciones.SelectedIndex == 1)
            {
                dt = (DataTable)Session["grd_ItemList2"];

                if (dt.Rows[0]["IdUsuario"].ToString() == Session["UserID"].ToString())
                {
                    Session["IdInmueble"] = dt.Rows[0]["IdInmueble"].ToString();

                    Response.Redirect("ModificarPropiedad.aspx");
                }
            }
            else if (ddlOpciones.SelectedIndex == 2)
            {
                dt = (DataTable)Session["grd_ItemList2"];

                if (dt.Rows[0]["IdUsuario"].ToString() == Session["UserID"].ToString())
                {
                    Session["IdInmueble"] = dt.Rows[0]["IdInmueble"].ToString();

                    Response.Redirect("AltaImagen.aspx");
                }
            }
            else if (ddlOpciones.SelectedIndex == 3)
            {
                dt = (DataTable)Session["grd_ItemList2"];

                if (dt.Rows[0]["IdUsuario"].ToString() == Session["UserID"].ToString())
                {
                    Session["IdInmueble"] = dt.Rows[0]["IdInmueble"].ToString();

                    InmueblesBLL bllInmuebles = new InmueblesBLL();
                    bllInmuebles.Delete(Session["IdInmueble"].ToString());


                    for (int i = 1; i <= 10; i++)
                    {
                        try
                        {
                            File.Delete(Server.MapPath("~\\Image_Upload\\" + Session["IdInmueble"].ToString() + "-" + i + ".jpg"));
                            File.Delete(Server.MapPath("~\\Image_Upload\\" + Session["IdInmueble"].ToString() + "-" + i + "_thumb.jpg"));

                        }
                        catch
                        {
                        }
                    }

                    Response.Redirect("MisPropiedades.aspx");
                }
            }
        }
    }
}