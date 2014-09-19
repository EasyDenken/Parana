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


/// <summary>
/// Descripción breve de cascading
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
[System.Web.Script.Services.ScriptService]
public class cascading : System.Web.Services.WebService
{
    PaisesBLL bllPaises;
    ProvinciasBLL bllProvincias;
    LocalidadesBLL bllLocalidades;
    ZonasBLL bllZonas;

    public cascading()
    {

        //Eliminar la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }


    [WebMethod]
    public AjaxControlToolkit.CascadingDropDownNameValue[] GetPaises(string knownCategoryValues, string category)
    {
        bllPaises = new PaisesBLL();

        List<AjaxControlToolkit.CascadingDropDownNameValue> values = new List<AjaxControlToolkit.CascadingDropDownNameValue>();

        DataTable dt = bllPaises.SelectPaises();

        foreach (DataRow dRow in dt.Rows)
        {
            string categoryID = dRow["IdPais"].ToString();
            string categoryName = dRow["Nombre"].ToString();
            values.Add(new AjaxControlToolkit.CascadingDropDownNameValue(categoryName, categoryID));
        }

        return values.ToArray();
    }

    [WebMethod]
    public AjaxControlToolkit.CascadingDropDownNameValue[] GetPaisesBusqueda(string knownCategoryValues, string category)
    {
        bllPaises = new PaisesBLL();

        List<AjaxControlToolkit.CascadingDropDownNameValue> values = new List<AjaxControlToolkit.CascadingDropDownNameValue>();

        DataTable dt = bllPaises.SelectPaisesBusqueda();

        foreach (DataRow dRow in dt.Rows)
        {
            string categoryID = dRow["IdPais"].ToString();
            string categoryName = dRow["Nombre"].ToString();
            values.Add(new AjaxControlToolkit.CascadingDropDownNameValue(categoryName, categoryID));
        }

        return values.ToArray();
    }

    [WebMethod]
    public AjaxControlToolkit.CascadingDropDownNameValue[] GetProvincias(string knownCategoryValues, string category)
    {
        bllProvincias = new ProvinciasBLL();

        StringDictionary categoryValues = AjaxControlToolkit.CascadingDropDown.ParseKnownCategoryValuesString(knownCategoryValues);

        int id = Convert.ToInt32(categoryValues["Pais"]);

        List<AjaxControlToolkit.CascadingDropDownNameValue> values = new List<AjaxControlToolkit.CascadingDropDownNameValue>();

        DataTable dt = bllProvincias.SelectProvinciasPorPais(id);

        foreach (DataRow dRow in dt.Rows)
        {
            string categoryID = dRow["IdProvincia"].ToString();
            string categoryName = dRow["Nombre"].ToString();
            values.Add(new AjaxControlToolkit.CascadingDropDownNameValue(categoryName, categoryID));
        }

        return values.ToArray();
    }

    [WebMethod]
    public AjaxControlToolkit.CascadingDropDownNameValue[] GetProvinciasBusqueda(string knownCategoryValues, string category)
    {
        bllProvincias = new ProvinciasBLL();

        StringDictionary categoryValues = AjaxControlToolkit.CascadingDropDown.ParseKnownCategoryValuesString(knownCategoryValues);

        int id = Convert.ToInt32(categoryValues["Pais"]);

        List<AjaxControlToolkit.CascadingDropDownNameValue> values = new List<AjaxControlToolkit.CascadingDropDownNameValue>();

        DataTable dt = bllProvincias.SelectProvinciasPorPaisBusqueda(id);

        foreach (DataRow dRow in dt.Rows)
        {
            string categoryID = dRow["IdProvincia"].ToString();
            string categoryName = dRow["Nombre"].ToString();
            values.Add(new AjaxControlToolkit.CascadingDropDownNameValue(categoryName, categoryID));
        }

        return values.ToArray();
    }

    [WebMethod]
    public AjaxControlToolkit.CascadingDropDownNameValue[] GetLocalidades(string knownCategoryValues, string category)
    {
        bllLocalidades = new LocalidadesBLL();

        StringDictionary categoryValues = AjaxControlToolkit.CascadingDropDown.ParseKnownCategoryValuesString(knownCategoryValues);

        int id = Convert.ToInt32(categoryValues["Provincia"]);

        List<AjaxControlToolkit.CascadingDropDownNameValue> values = new List<AjaxControlToolkit.CascadingDropDownNameValue>();

        DataTable dt = bllLocalidades.SelectLocalidades(id);

        foreach (DataRow dRow in dt.Rows)
        {
            //string categoryID = dRow["IdLocalidad"].ToString();
            //string categoryName = dRow["Nombre"].ToString();
            values.Add(new AjaxControlToolkit.CascadingDropDownNameValue(dRow["Nombre"].ToString(), dRow["IdLocalidad"].ToString()));
        }

        return values.ToArray();
    }

    [WebMethod]
    public AjaxControlToolkit.CascadingDropDownNameValue[] GetLocalidadesBusqueda(string knownCategoryValues, string category)
    {
        bllLocalidades = new LocalidadesBLL();

        StringDictionary categoryValues = AjaxControlToolkit.CascadingDropDown.ParseKnownCategoryValuesString(knownCategoryValues);

        int id = Convert.ToInt32(categoryValues["Provincia"]);

        List<AjaxControlToolkit.CascadingDropDownNameValue> values = new List<AjaxControlToolkit.CascadingDropDownNameValue>();

        DataTable dt = bllLocalidades.SelectLocalidadesBusqueda(id);

        foreach (DataRow dRow in dt.Rows)
        {
            //string categoryID = dRow["IdLocalidad"].ToString();
            //string categoryName = dRow["Nombre"].ToString();
            values.Add(new AjaxControlToolkit.CascadingDropDownNameValue(dRow["Nombre"].ToString(), dRow["IdLocalidad"].ToString()));
        }

        return values.ToArray();
    }

    [WebMethod]
    public AjaxControlToolkit.CascadingDropDownNameValue[] GetZonas(string knownCategoryValues, string category)
    {
        bllZonas = new ZonasBLL();

        StringDictionary categoryValues = AjaxControlToolkit.CascadingDropDown.ParseKnownCategoryValuesString(knownCategoryValues);

        int id = Convert.ToInt32(categoryValues["Localidad"]);

        List<AjaxControlToolkit.CascadingDropDownNameValue> values = new List<AjaxControlToolkit.CascadingDropDownNameValue>();

        DataTable dt = bllZonas.SelectZonasPorLocalidad(id);

        foreach (DataRow dRow in dt.Rows)
        {
            string categoryID = dRow["IdZona"].ToString();
            string categoryName = dRow["Nombre"].ToString();
            values.Add(new AjaxControlToolkit.CascadingDropDownNameValue(categoryName, categoryID));
        }

        return values.ToArray();
    }

}