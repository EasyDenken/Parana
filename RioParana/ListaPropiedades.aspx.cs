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

    public partial class ListaPropiedades : System.Web.UI.Page
    {
        DataTable dt;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtAceptar.OnClientClick = String.Format("this.disabled=true; __doPostBack('{0}','');", txtAceptar.UniqueID);
                CargarGrillaFavoritos();
            }

        }

        protected void CargarFicha(object sender, CommandEventArgs e)
        {

            //guardo la coockie en cogeCoockie
            ////HttpCookie cogeCoockie = Request.Cookies.Get("datosUsuario");

            //pregunto si se guardo algo en cogeCoockie
            ////if (cogeCoockie == null)
            ////{
            ////    Session["IdInmueble"] = e.CommandArgument.ToString();
            ////    MPEDatosUsuario.Show();

            ////}
            ////else
            ////{
            string s = e.CommandArgument.ToString();
            Session["IdInmueble"] = e.CommandArgument.ToString();
            Response.Redirect("FichaPropiedad.Aspx");
            ////}
        }

        public void AceptarPopUp(object sender, EventArgs e)
        {
            //si la coockie no se guardo la creo
            HttpCookie addCoockie = new HttpCookie("datosUsuario", DateTime.Now.ToString());

            //Fecha de vencimiento de la coockie
            addCoockie.Expires = DateTime.Now.AddDays(10);

            //creo la coockie
            Response.Cookies.Add(addCoockie);


            //envio el mail
            System.Net.Mail.MailMessage correo = new System.Net.Mail.MailMessage();

            correo.From = new System.Net.Mail.MailAddress("vazquez.german@gmail.com");
            correo.To.Add("vazquez.german@gmail.com");
            correo.Subject = "asunto";
            correo.Body = txtEmailAddress.Text + txtFirstName.Text + txtLastName.Text + txtTelefono.Text + Session["IdInmueble"].ToString();
            correo.IsBodyHtml = false;
            correo.Priority = System.Net.Mail.MailPriority.Normal;


            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Credentials = new System.Net.NetworkCredential("vazquez.german@gmail.com", "pass");

            try
            {
                smtp.Send(correo);
                //LabelError.Text = "Mensaje enviado satisfactoriamente";
            }
            catch //(Exception ex)
            {
                //LabelError.Text = "ERROR: " + ex.Message;
            }

            //



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

        protected void CargarGrillaFavoritos()
        {
            try
            {
                DataGrid1.Visible = false;

                InmueblesBLL bllInmuebles = new InmueblesBLL();

                dt = bllInmuebles.SeleccionaInmueblesFavoritos();

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



        protected void CargarGrilla(object sender, CommandEventArgs e)
        {

            try
            {
                DataGrid1.Visible = false;

                InmueblesBLL bllInmuebles = new InmueblesBLL();

                ArrayList arlInmobiliarias = new ArrayList();

                DataTable dtTipos = bllInmuebles.SeleccionaTiposDeInmuebles();

                Inmueble objInmueble = new Inmueble();

                string[] tipoDeInmuebleEntero = e.CommandArgument.ToString().Split('(');

                int cant = 0;

                string tipo = "null";

                foreach (string tipo2 in tipoDeInmuebleEntero)
                {
                    if (cant == 0)
                    {
                        tipo = tipo2.Substring(0, tipo2.Length - 1);
                        cant = cant + 1;
                    }
                }

                dtTipos = bllInmuebles.SeleccionaTiposDeInmuebles();

                foreach (DataRow r in dtTipos.Rows)
                {


                    if (r.Field<string>("TipoPadre") + " " + r.Field<string>("NombreMenu") == tipo)
                    {
                        dt = bllInmuebles.SeleccionaInmueblesBusqueda(objInmueble, r.Field<int>("IdTipoDeInmueble"));
                    }
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





        public ArrayList FetchCasas()
        {
            InmueblesBLL bllInmuebles = new InmueblesBLL();
            Inmueble objInmueble = new Inmueble();
            ArrayList mailItems = new ArrayList();
            DataTable dt = bllInmuebles.SeleccionaTiposDeInmueblesPorPadre("CASA");



            foreach (DataRow r in dt.Rows)
            {
                string g = r.Field<String>("NombreMenu");
                // string h = r.Field<String>("IdTipoDeInmueble");
                mailItems.Add(new { Name = r.Field<String>("NombreMenu") + " (" + bllInmuebles.SeleccionaCantidadInmuebles(Convert.ToInt32(r.Field<int>("IdTipoDeInmueble"))) + ")", ImageUrl = "img/inbox.gif" });
            }

            //mailItems.Add(new { Name = "1 DORMITORIO (" + bllInmuebles.SeleccionaCantidadInmuebles(8) + ")", ImageUrl = "img/inbox.gif" });
            //mailItems.Add(new { Name = "2 DORMITORIOS (" + bllInmuebles.SeleccionaCantidadInmuebles(9) + ")", ImageUrl = "img/drafts.gif" });
            //mailItems.Add(new { Name = "3 DORMITORIOS (" + bllInmuebles.SeleccionaCantidadInmuebles(10) + ")", ImageUrl = "img/outbox.gif" });
            //mailItems.Add(new { Name = "4 DORMITORIOS O MAS (" + bllInmuebles.SeleccionaCantidadInmuebles(11) + ")", ImageUrl = "img/junk.gif" });

            return mailItems;
        }

        public ArrayList FetchDepartamentos()
        {
            InmueblesBLL bllInmuebles = new InmueblesBLL();
            Inmueble objInmueble = new Inmueble();
            ArrayList mailItems = new ArrayList();
            DataTable dt = bllInmuebles.SeleccionaTiposDeInmueblesPorPadre("DEPARTAMENTO");



            foreach (DataRow r in dt.Rows)
            {
                string g = r.Field<String>("NombreMenu");
                // string h = r.Field<String>("IdTipoDeInmueble");
                mailItems.Add(new { Name = r.Field<String>("NombreMenu") + " (" + bllInmuebles.SeleccionaCantidadInmuebles(Convert.ToInt32(r.Field<int>("IdTipoDeInmueble"))) + ")", ImageUrl = "img/inbox.gif" });
            }


            //mailItems.Add(new { Name = "DE PASILLO (" + bllInmuebles.SeleccionaCantidadInmuebles(1) + ")", ImageUrl = "img/mailbox.gif" });
            //mailItems.Add(new { Name = "AMUEBLADOS (" + bllInmuebles.SeleccionaCantidadInmuebles(2) + ")", ImageUrl = "img/mailbox.gif" });
            //mailItems.Add(new { Name = "1 AMBIENTE (" + bllInmuebles.SeleccionaCantidadInmuebles(3) + ")", ImageUrl = "img/mailbox.gif" });
            //mailItems.Add(new { Name = "1 DORMITORIO (" + bllInmuebles.SeleccionaCantidadInmuebles(4) + ")", ImageUrl = "img/inbox.gif" });
            //mailItems.Add(new { Name = "2 DORMITORIOS (" + bllInmuebles.SeleccionaCantidadInmuebles(5) + ")", ImageUrl = "img/drafts.gif" });
            //mailItems.Add(new { Name = "3 DORMITORIOS (" + bllInmuebles.SeleccionaCantidadInmuebles(6) + ")", ImageUrl = "img/outbox.gif" });
            //mailItems.Add(new { Name = "4 DORMITORIOS O MAS (" + bllInmuebles.SeleccionaCantidadInmuebles(7) + ")", ImageUrl = "img/junk.gif" });

            return mailItems;
        }


        public ArrayList FetchOtrosInmuebles()
        {
            ArrayList mailItems = new ArrayList();
            InmueblesBLL bllInmuebles = new InmueblesBLL();
            Inmueble objInmueble = new Inmueble();
            DataTable dt = bllInmuebles.SeleccionaTiposDeInmueblesPorPadre("OTRO");



            foreach (DataRow r in dt.Rows)
            {
                string g = r.Field<String>("NombreMenu");
                // string h = r.Field<String>("IdTipoDeInmueble");
                mailItems.Add(new { Name = r.Field<String>("NombreMenu") + " (" + bllInmuebles.SeleccionaCantidadInmuebles(Convert.ToInt32(r.Field<int>("IdTipoDeInmueble"))) + ")", ImageUrl = "img/inbox.gif" });
            }

            //mailItems.Add(new { Name = "COCHERAS (" + bllInmuebles.SeleccionaCantidadInmuebles(12) + ")", ImageUrl = "img/mailbox.gif" });
            //mailItems.Add(new { Name = "DEPOSITOS Y GALPONES (" + bllInmuebles.SeleccionaCantidadInmuebles(13) + ")", ImageUrl = "img/mailbox.gif" });
            //mailItems.Add(new { Name = "HOTELES, PENSIONES Y PIEZAS (" + bllInmuebles.SeleccionaCantidadInmuebles(14) + ")", ImageUrl = "img/mailbox.gif" });
            //mailItems.Add(new { Name = "LOCALES COMERCIALES,INDUSTRIALES Y OFICINAS (" + bllInmuebles.SeleccionaCantidadInmuebles(15) + ")", ImageUrl = "img/mailbox.gif" });
            //mailItems.Add(new { Name = "TERRENOS (" + bllInmuebles.SeleccionaCantidadInmuebles(16) + ")", ImageUrl = "img/mailbox.gif" });

            return mailItems;
        }
    }
}