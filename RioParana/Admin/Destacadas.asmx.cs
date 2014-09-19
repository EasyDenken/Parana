using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Data;
using RioParanaBLL;
using System.Collections.Specialized;
using System.Text.RegularExpressions;

namespace RioParana.Admin
{
    /// <summary>
    /// Summary description for Destacadas1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class Destacadas1 : System.Web.Services.WebService
    {
        InmueblesBLL bllinmuebles;

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public AjaxControlToolkit.CascadingDropDownNameValue[] getInmuebles(string knownCategoryValues, string category)
        {
            bllinmuebles = new InmueblesBLL();

            List<AjaxControlToolkit.CascadingDropDownNameValue> values = new List<AjaxControlToolkit.CascadingDropDownNameValue>();

            DataTable dt = bllinmuebles.SeleccionaInmuebles();

            foreach (DataRow dRow in dt.Rows)
            {
                string categoryID = dRow["IdInmueble"].ToString();
                string categoryName = dRow["Calle"].ToString() + " " + dRow["Numero"].ToString();
                values.Add(new AjaxControlToolkit.CascadingDropDownNameValue(categoryName, categoryID));
            }

            return values.ToArray();
        }

        [WebMethod]
        public AjaxControlToolkit.CascadingDropDownNameValue[] getInmuebles1(string knownCategoryValues, string category)
        {
            bllinmuebles = new InmueblesBLL();

            StringDictionary categoryValues = AjaxControlToolkit.CascadingDropDown.ParseKnownCategoryValuesString(knownCategoryValues);

            int id = Convert.ToInt32(categoryValues["inmuebles"]);

            List<AjaxControlToolkit.CascadingDropDownNameValue> values = new List<AjaxControlToolkit.CascadingDropDownNameValue>();

            DataTable dt = bllinmuebles.SeleccionaInmueblesDistintosDeID(id, 0, 0);

            foreach (DataRow dRow in dt.Rows)
            {
                string categoryID = dRow["IdInmueble"].ToString();
                string categoryName = dRow["Calle"].ToString() + " " + dRow["Numero"].ToString();
                values.Add(new AjaxControlToolkit.CascadingDropDownNameValue(categoryName, categoryID));
            }

            return values.ToArray();
        }

        [WebMethod]
        public AjaxControlToolkit.CascadingDropDownNameValue[] getInmuebles2(string knownCategoryValues, string category)
        {
            bllinmuebles = new InmueblesBLL();

            StringDictionary categoryValues = AjaxControlToolkit.CascadingDropDown.ParseKnownCategoryValuesString(knownCategoryValues);

            int id = Convert.ToInt32(categoryValues["inmuebles"]);
            int id2 = Convert.ToInt32(categoryValues["inmuebles1"]);

            List<AjaxControlToolkit.CascadingDropDownNameValue> values = new List<AjaxControlToolkit.CascadingDropDownNameValue>();

            DataTable dt = bllinmuebles.SeleccionaInmueblesDistintosDeID(id, id2, 0);

            foreach (DataRow dRow in dt.Rows)
            {
                string categoryID = dRow["IdInmueble"].ToString();
                string categoryName = dRow["Calle"].ToString() + " " + dRow["Numero"].ToString();
                values.Add(new AjaxControlToolkit.CascadingDropDownNameValue(categoryName, categoryID));
            }

            return values.ToArray();
        }

        [WebMethod]
        public AjaxControlToolkit.CascadingDropDownNameValue[] getInmuebles3(string knownCategoryValues, string category)
        {
            bllinmuebles = new InmueblesBLL();

            StringDictionary categoryValues = AjaxControlToolkit.CascadingDropDown.ParseKnownCategoryValuesString(knownCategoryValues);

            int id = Convert.ToInt32(categoryValues["inmuebles"]);
            int id2 = Convert.ToInt32(categoryValues["inmuebles1"]);
            int id3 = Convert.ToInt32(categoryValues["inmuebles2"]);

            List<AjaxControlToolkit.CascadingDropDownNameValue> values = new List<AjaxControlToolkit.CascadingDropDownNameValue>();

            DataTable dt = bllinmuebles.SeleccionaInmueblesDistintosDeID(id, id2, id3);

            foreach (DataRow dRow in dt.Rows)
            {
                string categoryID = dRow["IdInmueble"].ToString();
                string categoryName = dRow["Calle"].ToString() + " " + dRow["Numero"].ToString();
                values.Add(new AjaxControlToolkit.CascadingDropDownNameValue(categoryName, categoryID));
            }

            return values.ToArray();
        }
    }
}
