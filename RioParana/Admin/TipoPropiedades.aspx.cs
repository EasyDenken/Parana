using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace RioParana.Admin
{
    public partial class TipoPropiedades : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void dgTiposInmueble_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes.Add("OnMouseOver", "Resaltar_On(this);");
                e.Row.Attributes.Add("OnMouseOut", "Resaltar_Off(this);");
                e.Row.Attributes["OnClick"] = Page.ClientScript.GetPostBackClientHyperlink(dgTiposInmueble, "Select$" + e.Row.RowIndex.ToString());
            }

        }

        protected void dgTiposInmueble_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgTiposInmueble.SelectedRowStyle.BackColor = System.Drawing.Color.FromArgb(200, 200, 200);
        }

        protected void btnFicha_Click(object sender, EventArgs e)
        {
            Session["IDTipo"] = "0";
            Response.Redirect("EditarTipos.aspx");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgTiposInmueble.SelectedIndex != -1)
            {
                RioParanaBLL.TiposBLL bllTipos = new RioParanaBLL.TiposBLL();
                bllTipos.EliminaTipoDeInmuebles(dgTiposInmueble.SelectedValue.ToString());
                odsTipoInmuebles.DataBind();
                dgTiposInmueble.DataBind();
                upGrilla.Update();
            }
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            Session["IDTipo"] = dgTiposInmueble.SelectedValue.ToString();
            Response.Redirect("EditarTipos.aspx");
        }
    }
}