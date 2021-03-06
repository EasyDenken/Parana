﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RioParanaBLL;
using System.Data;
using System.Xml;

namespace RioParana.Admin
{
    public partial class Destacadas : System.Web.UI.Page
    {
        DestacadasBLL bllDestacadas;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                //XmlTextReader reader = new XmlTextReader(Server.MapPath("~\\Admin\\Destacadas.xml"));

                XmlReader reader = XmlTextReader.Create(Server.MapPath("~\\Admin\\Destacadas.xml"));

                reader.MoveToContent();
                reader.ReadStartElement();

                try
                {
                    reader.ReadToNextSibling("Destacadas1");
                    CascadingDropDown1.SelectedValue = reader.ReadString();

                    reader.ReadToNextSibling("Destacadas2");
                    CascadingDropDown2.SelectedValue = reader.ReadString();

                    reader.ReadToNextSibling("Destacadas3");
                    CascadingDropDown3.SelectedValue = reader.ReadString();

                    reader.ReadToNextSibling("Destacadas4");
                    CascadingDropDown4.SelectedValue = reader.ReadString();

                    reader.Close();
                }
                catch
                {
                    
                }

                /*
                bllDestacadas = new DestacadasBLL();

                DataTable dt = bllDestacadas.SeleccionaInmueblesDestacados();

                CascadingDropDown1.SelectedValue = dt.Rows[0]["IdDestacadas"].ToString();
                CascadingDropDown2.SelectedValue = dt.Rows[1]["IdDestacadas"].ToString();
                CascadingDropDown3.SelectedValue = dt.Rows[2]["IdDestacadas"].ToString();
                CascadingDropDown4.SelectedValue = dt.Rows[3]["IdDestacadas"].ToString();
                 */
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {

            /*
            bllDestacadas = new DestacadasBLL();

            bllDestacadas.update(Convert.ToInt32(ddlInmuebles.SelectedValue), 1);

            bllDestacadas.update(Convert.ToInt32(ddlInmuebles1.SelectedValue), 2);

            bllDestacadas.update(Convert.ToInt32(ddlInmuebles2.SelectedValue), 3);

            bllDestacadas.update(Convert.ToInt32(ddlInmuebles3.SelectedValue), 4);
            */


            XmlTextWriter writer = new XmlTextWriter(Server.MapPath("~\\Admin\\Destacadas.xml"), null);
            //XmlTextWriter writer = XmlTextWriter.Create(Server.MapPath("~\\Admin\\Destacadas.xml"));

            writer.Formatting = Formatting.Indented;

            //Write the root element
            writer.WriteStartElement("Destacadas");

             //Write sub-elements
            writer.WriteElementString("Destacadas1", ddlInmuebles.SelectedValue.ToString());
            writer.WriteElementString("Destacadas2", ddlInmuebles1.SelectedValue.ToString());
            writer.WriteElementString("Destacadas3", ddlInmuebles2.SelectedValue.ToString());
            writer.WriteElementString("Destacadas4", ddlInmuebles3.SelectedValue.ToString());

            // end the root element
            writer.WriteEndElement();

            //Write the XML to file and close the writer
            writer.Close();

        }
    }
}