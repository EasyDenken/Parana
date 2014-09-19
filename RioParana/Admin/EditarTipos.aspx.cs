using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RioParanaBLL;
using RioParanaOBJ;

namespace RioParana.Admin
{
    public partial class EditarTipos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["IDTipo"].ToString() != "0")
                {
                    TiposBLL bllTipos = new TiposBLL();
                    Tipos objTipos = bllTipos.TraerTipoDeInmuebles(Session["IDTipo"].ToString());
                    txtTipo.Text = objTipos.Tipo;
                    txtPadre.Text = objTipos.Padre;
                    txtMenu.Text = objTipos.Menu;
                    rbMostrar.SelectedValue = objTipos.Mostrar;
                }
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Tipos objTipos = new Tipos();
                objTipos.IDTipoInmueble = int.Parse(Session["IDTipo"].ToString());
                objTipos.Tipo = txtTipo.Text;
                objTipos.Padre = txtPadre.Text;
                objTipos.Menu = txtMenu.Text;
                objTipos.Mostrar = rbMostrar.SelectedValue;
                TiposBLL bllTipos = new TiposBLL();
                if (objTipos.IDTipoInmueble == 0)
                    bllTipos.InsertTipoDeInmuebles(objTipos);
                else
                    bllTipos.UpdateTipoDeInmuebles(objTipos);
                Response.Redirect("TipoPropiedades.aspx");
            }
            catch { }
        }
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("TipoPropiedades.aspx");
        }
    }
}