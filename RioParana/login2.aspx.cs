using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RioParanaBLL;

namespace RioParana
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAcceder_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text == string.Empty)
                {

                }
                else if (txtPassword.Text == string.Empty)
                {

                }
                else
                {
                    UsuarioBLL bllUsuario = new UsuarioBLL();
                    if (bllUsuario.TraeUsuario(txtUsuario.Text, txtPassword.Text).Rows.Count > 0)
                    {
                        Session["Usuario"] = txtUsuario.Text;
                        Response.Redirect("Admin/Propiedades.aspx");
                    }
                    else
                    {
                        lblMensaje.Text = "El Usuario o contraseña son incorrectos.....";
                    }
                }
            }
            catch
            {

            }
        }
    }
}