using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RioParana.UserControls
{
    public partial class ucBuscador : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Compra_Click(object sender, ImageClickEventArgs e)
        {
            string xml = @"<xml>
                            <Nodo1>
	                            <Nodo1a/>
	                            <Nodo1b/>
                            <Nodo1/>
                            <Nodo2>
	                            <Nodo2a/>
	                            <Nodo2b/>
                            <Nodo2/>
                            <Nodo3>
	                            <Nodo3a/>
	                            <Nodo3b/>
                            <Nodo3/>
                            <Nodo4>
	                            <Nodo4a/>
	                            <Nodo4b/>
                            <Nodo4/>";
            
            
            TreeView1.DataSource = xml;
        }

        protected void Alquiler_Click(object sender, ImageClickEventArgs e)
        {

        }
    }
}