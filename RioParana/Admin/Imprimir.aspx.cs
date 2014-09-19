using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using Artem.Web.UI.Controls;
using GoogleGeocoder;
using System.Globalization;
using AjaxControlToolkit;
using System.Data;
using ProyectoInmoBLL;
using ProyectoInmoOBJ;
using System.Web.Security;

public partial class Members_Imprimir : System.Web.UI.Page
{
    DataTable dt;
    protected void Page_Load(object sender, EventArgs e)
    {
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
                DetailsView2.DataSource = dt;
                DetailsView2.DataBind();

                GoogleMarker marker = new GoogleMarker(dt.Rows[0]["Calle"].ToString() + " " + dt.Rows[0]["Numero"].ToString() + "," + dt.Rows[0]["NombreLocalidad"].ToString() + "," + dt.Rows[0]["NombreProvincia"].ToString());


                GoogleMap1.Markers.Add(marker);

                Coordinate coordinate = Geocode.GetCoordinates(dt.Rows[0]["Calle"].ToString() + " " + dt.Rows[0]["Numero"].ToString() + "," + dt.Rows[0]["NombreLocalidad"].ToString() + "," + dt.Rows[0]["NombreProvincia"].ToString());
                decimal latitude = coordinate.Latitude;
                decimal longitude = coordinate.Longitude;

                GoogleMap1.Latitude = convert(latitude);//-32.9400639;

                GoogleMap1.Longitude = convert(longitude);//-60.6600255;

                marker.Text = dt.Rows[0]["Calle"].ToString() + " " + dt.Rows[0]["Numero"].ToString() + "," + dt.Rows[0]["NombreLocalidad"].ToString() + "," + dt.Rows[0]["NombreProvincia"].ToString();

                string g = marker.ToJsonString();




                string strRutaFoto = Server.MapPath("~\\Image_Upload\\" + Session["IdInmueble"].ToString() + "-" + "01" + "_thumb.jpg");

                Boolean strFoto = (System.IO.File.Exists(strRutaFoto));

                if (strFoto)
                {
                    Image1.Visible = true;

                    Image1.ImageUrl = this.Page.ResolveClientUrl("~\\Image_Upload\\" + Session["IdInmueble"].ToString() + "-" + "01" + "_thumb.jpg");
                }
                else
                {
                    Image1.Visible = false;
                }

                

                //Googleimagen.ImageUrl = this.Page.ResolveUrl("http://maps.google.com/staticmap?zoom=15&size=320x342&markers=" + longitude + "," + latitude + "&key=ABQIAAAApU_iFCnQtFqCJz_RVHKf6hSIMON3V3yf7e-rtPXBV5YPjpYuCRQqSKQQMFkEFT-8V8ujIAr2-XcoIQ");

                Googleimagen.ImageUrl = "http://maps.google.com/staticmap?zoom=15&size=259x250&markers=" + GoogleMap1.Latitude.ToString().Replace(",", ".") + "," + GoogleMap1.Longitude.ToString().Replace(",", ".") + "&key=ABQIAAAApU_iFCnQtFqCJz_RVHKf6hSIMON3V3yf7e-rtPXBV5YPjpYuCRQqSKQQMFkEFT-8V8ujIAr2-XcoIQ";
                
                  
            
            }
            else if (dt.Rows.Count == 0)
            {
            }

            HiddenFielddireccion.Value = dt.Rows[0]["Calle"].ToString() + " " + dt.Rows[0]["Numero"].ToString();
            HiddenFieldzona.Value = dt.Rows[0]["Zona"].ToString();
            HiddenFieldtipoinmueble.Value = dt.Rows[0]["TipoDeInmueble"].ToString();
            HiddenFieldestadoinmueble.Value = dt.Rows[0]["Estado"].ToString();
            HiddenFieldprovincia.Value = dt.Rows[0]["NombreProvincia"].ToString();
            HiddenFieldlocalidad.Value = dt.Rows[0]["NombreLocalidad"].ToString();
            HiddenFieldpiso.Value = dt.Rows[0]["Piso"].ToString();
            HiddenFielddepartamento.Value = dt.Rows[0]["Departamento"].ToString();
            HiddenFieldentrecalle.Value = dt.Rows[0]["Calle1"].ToString();
            HiddenFieldycalle.Value = dt.Rows[0]["Calle2"].ToString();
            HiddenFieldmetroscuadcubiertos.Value = dt.Rows[0]["MetroCuadrados"].ToString();
            HiddenFieldmetroscuadsemicubiertos.Value = dt.Rows[0]["MetrosCuadradosSemiCub"].ToString();
            HiddenFieldposicion.Value = dt.Rows[0]["Frente"].ToString();
            HiddenFieldcochera.Value = dt.Rows[0]["Fondo"].ToString();
            HiddenFieldposicion.Value = dt.Rows[0]["Posicion"].ToString();
            HiddenFieldcochera.Value = dt.Rows[0]["Cocheras"].ToString();
            HiddenFieldAntiguedad.Value = dt.Rows[0]["Antiguedad"].ToString();
            HiddenFieldAntiguedadA.Value = dt.Rows[0]["AntiguedadA"].ToString();
            HiddenFieldOperacion.Value = dt.Rows[0]["Operacion"].ToString();
            HiddenFieldPrecioVenta.Value = dt.Rows[0]["PrecioVenta"].ToString();
            HiddenFieldPrecioAlquiler.Value = dt.Rows[0]["PrecioAlquiler"].ToString();
            HiddenFieldComision.Value = dt.Rows[0]["Comision"].ToString();
            HiddenFieldFechaAlta.Value = dt.Rows[0]["FechaAlta"].ToString();
            HiddenFieldFechaActualiza.Value = dt.Rows[0]["FechaActualiza"].ToString();
            HiddenFieldMailUsuario.Value = dt.Rows[0]["MailUsuario"].ToString();
            HiddenFieldObservaciones.Value = dt.Rows[0]["Observaciones"].ToString();
            HiddenFieldimagen.Value = this.Page.ResolveClientUrl(Session["IdInmueble"].ToString() + "-" + "01" + "_thumb.jpg");
            HiddenFieldgooglemapsimage.Value = "http://maps.googleapis.com/maps/api/staticmap?markers=" + GoogleMap1.Latitude.ToString().Replace(",", ".") + "," + GoogleMap1.Longitude.ToString().Replace(",", ".") + "&amp;zoom=15&amp;size=260x194&amp;sensor=false";
        
        }
        catch
        {

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
        //bound("Calle", "Calle:");
        //bound("Numero", "Altura:");
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
        //bound("Publica", "Visible para todos los usuarios:");        
        bound("NombreInmobiliaria", "Nombre de Inmobiliaria:");
        bound("NombreUsuario", "Nombre del Usuario:");
        bound("ApellidoUsuario", "Apellido del Usuario:");
        bound("TelefonoUsuario", "Telefono del Usuario:");
        bound("CelularUsuario", "Celular del Usuario:");
        bound("MailUsuario", "Mail del Usuario:");
        //bound("Observaciones", "Observaciones:");
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
    protected void DetailsView1_ItemCommand(object sender, DetailsViewCommandEventArgs e)
    {
        //CalcularSesion();

        if (e.CommandName == "Editar")
        {

            dt = (DataTable)Session["grd_ItemList2"];

            if (dt.Rows[0]["IdUsuario"].ToString() == Membership.GetUser().ProviderUserKey.ToString())
            {
                Session["IdInmueble"] = dt.Rows[0]["IdInmueble"].ToString();

                Response.Redirect("ModificarPropiedad.aspx");
            }
        }

        else if (e.CommandName == "Eliminar")
        {

            dt = (DataTable)Session["grd_ItemList2"];

            if (dt.Rows[0]["IdUsuario"].ToString() == Membership.GetUser().ProviderUserKey.ToString())
            {
                //Response.Write("<script>window.alert('Hola');</script>");
                //Response.Redirect("ModificarPropiedad.aspx?id="
                //   + dt.Rows[0]["IdInmueble"].ToString());

                //CalcularSesion();

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

    //protected void CalcularSesion()
    //{
    //    if (Session["UserID"] == null)
    //    {
    //        Response.Redirect("~/login.aspx");
    //    }
    //}


}
