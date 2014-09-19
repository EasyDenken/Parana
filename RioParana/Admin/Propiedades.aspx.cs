using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Drawing;
using System.IO;
using RioParanaBLL;
using RioParanaOBJ;

namespace RioParana.Admin
{
    public partial class Propiedades : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                iniciargrilla();
            }
        }
        protected void btnEditar_Click(object sender, EventArgs e)
        {
            if (gvInmuebles.SelectedIndex != -1)
            {
                Session["IdInmueble"] = gvInmuebles.SelectedValue.ToString();
                Response.Redirect("ModificarPropiedad.aspx");
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("AltaPropiedad.aspx");
            
        }

        public string Moneda(string moneda)
        {
            if (moneda == "P")
                return "ARS$";
            else if (moneda == "D")
                return "US$";
            else
                return "";
        }
        protected void ddlTipoDeInmueble_SelectedIndexChanged(object sender, EventArgs e)
        {
            iniciargrilla();
        }
        protected void iniciargrilla()
        {
            IniciaGridView();

            if (rdOperacion.SelectedValue == "1")
            {
                gvInmuebles.Columns[5].Visible = false;
                gvInmuebles.Columns[4].Visible = true;

                ddlOrdenar.Items[2].Enabled = true;
                ddlOrdenar.Items[3].Enabled = false;
            }
            else if (rdOperacion.SelectedValue == "2")
            {
                gvInmuebles.Columns[5].Visible = true;
                gvInmuebles.Columns[4].Visible = false;

                ddlOrdenar.Items[2].Enabled = false;
                ddlOrdenar.Items[3].Enabled = true;
            }
            else
            {
                gvInmuebles.Columns[5].Visible = true;
                gvInmuebles.Columns[4].Visible = true;

                ddlOrdenar.Items[2].Enabled = true;
                ddlOrdenar.Items[3].Enabled = true;
            }
        }
        protected void IniciaGridView()
        {

            if (ddlTipoDeInmueble.SelectedValue == null || ddlTipoDeInmueble.SelectedValue == "")
            {
                InmueblesBLL bllInmuebles = new InmueblesBLL();
                DataTable dt = bllInmuebles.SeleccionaInmuebles(0, Convert.ToInt32(rdOperacion.SelectedValue), ddlOrdenar.SelectedValue.ToString());
                gvInmuebles.DataSource = dt;
                Session["grd_ItemList2"] = dt;

                if (dt.Rows.Count == 0)
                {
                    btnEditar.Visible = false;
                    btnEliminar.Visible = false;
                    btnFicha.Visible = false;
                }
                else
                {
                    btnEditar.Visible = true;
                    btnEliminar.Visible = true;
                    btnFicha.Visible = true;
                }
                gvInmuebles.DataBind();
                gvInmuebles.SelectedIndex = -1;
            }
            else
            {
                InmueblesBLL bllInmuebles = new InmueblesBLL();
                DataTable dt = bllInmuebles.SeleccionaInmuebles(Convert.ToInt32(ddlTipoDeInmueble.SelectedValue), Convert.ToInt32(rdOperacion.SelectedValue), ddlOrdenar.SelectedValue.ToString());
                gvInmuebles.DataSource = dt;
                Session["grd_ItemList2"] = dt;

                if (dt.Rows.Count == 0)
                {
                    btnEditar.Visible = false;
                    btnEliminar.Visible = false;
                    btnFicha.Visible = false;
                }
                else
                {
                    btnEditar.Visible = true;
                    btnEliminar.Visible = true;
                    btnFicha.Visible = true;
                }
                gvInmuebles.DataBind();
                gvInmuebles.SelectedIndex = -1;
            }

        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if (gvInmuebles.SelectedIndex != -1)
            {
                InmueblesBLL bllInmuebles = new InmueblesBLL();
                bllInmuebles.Delete(gvInmuebles.SelectedValue.ToString());


                for (int i = 1; i <= 10; i++)
                {
                    try
                    {
                        File.Delete(Server.MapPath("~\\Image_Upload\\" + gvInmuebles.SelectedValue.ToString() + "-" + i + ".jpg"));
                        File.Delete(Server.MapPath("~\\Image_Upload\\" + gvInmuebles.SelectedValue.ToString() + "-" + i + "_thumb.jpg"));

                    }
                    catch
                    {
                    }
                }

                IniciaGridView();
            }
        }
        protected void btnFicha_Click(object sender, EventArgs e)
        {
            if (gvInmuebles.SelectedIndex != -1)
            {
                Session["IdInmueble"] = gvInmuebles.SelectedValue.ToString();
                Response.Redirect("FichaPropiedad.Aspx");
            }
        }
        protected void gvInmuebles_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvInmuebles.PageIndex = e.NewPageIndex;
            if (Session["grd_ItemList2"] != null)
            {
                gvInmuebles.DataSource = Session["grd_ItemList2"];
                gvInmuebles.DataBind();
            }
        }
        protected void gvInmuebles_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            //FORMATEA ROWS
            if (e.Row.RowType == DataControlRowType.DataRow)
            {//ASIGNA EVENTOS
                e.Row.Attributes.Add("OnMouseOver", "Resaltar_On(this);");
                e.Row.Attributes.Add("OnMouseOut", "Resaltar_Off(this);");
                e.Row.Attributes["OnClick"] = Page.ClientScript.GetPostBackClientHyperlink(gvInmuebles, "Select$" + e.Row.RowIndex.ToString());

                // determine the value of the UnitsInStock field
                DateTime FechaActualiza = Convert.ToDateTime(DataBinder.Eval(e.Row.DataItem, "FechaActualiza"));

                TimeSpan diferencia = DateTime.Now - FechaActualiza;

                if (diferencia.Days >= 300)
                {
                    e.Row.BackColor = Color.FromKnownColor(KnownColor.Red);
                    e.Row.Attributes.Add("onClick", "font-weight='bold'; ");
                }



            }

        }
        protected void gvInmuebles_SelectedIndexChanged(object sender, EventArgs e)
        {
            gvInmuebles.SelectedRowStyle.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            List<Inmueble> lista = new List<Inmueble>();
            foreach (GridViewRow dr in gvInmuebles.Rows)
            {
                //lb_IdInmueble
                Inmueble inmu = new Inmueble();
                inmu.IDInmueble = int.Parse((dr.Cells[0].FindControl("lb_IdInmueble") as Label).Text);
                inmu.Favorito = (dr.Cells[7].FindControl("chkFavoritos") as CheckBox).Checked;
                if (inmu.Favorito)
                    lista.Add(inmu);
            }
            InmueblesBLL bllInmueble = new InmueblesBLL();
            bllInmueble.UpdateFavoritos(lista);
        }
    }
}