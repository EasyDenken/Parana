using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RioParanaBLL;
using RioParanaOBJ;
using System.Data;

namespace RioParana.Admin
{
    public partial class ModificarPropiedad : System.Web.UI.Page
    {
        InmueblesBLL bllInmuebles;
        Inmueble objInmueble;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["IdInmueble"] == null || Session["IdInmueble"].ToString() == "")
                    Response.Redirect("Propiedades.aspx");
                this.bllInmuebles = new InmueblesBLL();
                EditarPropiedad();
            }
        }
        protected void EditarPropiedad()
        {
            try
            {
                if (Session["IdInmueble"].ToString() != "")
                {
                    objInmueble = bllInmuebles.SeleccionaInmueblePorID(Session["IdInmueble"].ToString());
                    ddlTipoDeInmueble.SelectedValue = objInmueble.IDTipoDeInmueble.ToString();
                    ddlEstado.SelectedValue = objInmueble.IDEstado.ToString();
                    ddlOperacion.SelectedValue = objInmueble.IDOperacion.ToString();
                    rblVisible.SelectedValue = objInmueble.Publica;
                    txtCalle.Text = objInmueble.Calle;
                    txtNumero.Text = objInmueble.Numero;
                    txtPiso.Text = objInmueble.Piso;
                    txtDepartamento.Text = objInmueble.Departamento;
                    txtCalle1.Text = objInmueble.Calle1;
                    txtCalle2.Text = objInmueble.Calle2;
                    if (objInmueble.AntiguedadA.ToString() != "0")
                        txtAntiguedad.Text = objInmueble.AntiguedadA.ToString();
                    if (objInmueble.MetrosCuadrados.ToString() != "0")
                        txtMetrosCuadrados.Text = objInmueble.MetrosCuadrados.ToString();
                    if (objInmueble.MetrosCuadradosSemiCubiertos.ToString() != "0")
                        txtMetrosCuadradosSemi.Text = objInmueble.MetrosCuadradosSemiCubiertos.ToString();
                    if (objInmueble.Frente.ToString() != "0")
                        txtFrente.Text = objInmueble.Frente.ToString();
                    if (objInmueble.Fondo.ToString() != "0")
                        txtFondo.Text = objInmueble.Fondo.ToString();
                    rblCocheras.SelectedValue = objInmueble.Cocheras;
                    rblPosicion.SelectedValue = objInmueble.Posicion;
                    rblAntiguedad.SelectedValue = objInmueble.Antiguedad;
                    if (rblAntiguedad.SelectedValue == "Usado")
                        txtAntiguedad.Enabled = true;
                    if (objInmueble.PrecioVenta.ToString() != "0")
                        txtPrecioDeVenta.Text = objInmueble.PrecioVenta.ToString();
                    if (objInmueble.PrecioAlquiler.ToString() != "0")
                        txtPrecioDeAlquiler.Text = objInmueble.PrecioAlquiler.ToString();

                    txtObservaciones.Content = objInmueble.Observaciones;
                    ddlMonedaAlquiler.SelectedValue = objInmueble.MonedaAlquiler;
                    ddlMonedaVenta.SelectedValue = objInmueble.MonedaVenta;
                    if (objInmueble.IDOperacion.ToString() == "1")
                    {
                        txtPrecioDeAlquiler.Enabled = false;
                        ddlMonedaAlquiler.Enabled = false;
                        txtPrecioDeVenta.Enabled = true;
                        ddlMonedaVenta.Enabled = true;
                        txtPrecioDeAlquiler.Text = "";

                        rfvPrecioDeAlquiler.Enabled = false;
                        rfvPrecioDeVenta.Enabled = true;
                    }

                    else if (objInmueble.IDOperacion.ToString() == "2")
                    {
                        txtPrecioDeAlquiler.Enabled = true;
                        ddlMonedaAlquiler.Enabled = true;

                        txtPrecioDeVenta.Enabled = false;
                        ddlMonedaVenta.Enabled = false;
                        txtPrecioDeVenta.Text = "";

                        rfvPrecioDeAlquiler.Enabled = true;
                        rfvPrecioDeVenta.Enabled = false;
                    }
                    else if (objInmueble.IDOperacion.ToString() == "3")
                    {
                        txtPrecioDeAlquiler.Enabled = true;
                        ddlMonedaAlquiler.Enabled = true;

                        txtPrecioDeVenta.Enabled = true;
                        ddlMonedaVenta.Enabled = true;

                        rfvPrecioDeAlquiler.Enabled = true;
                        rfvPrecioDeVenta.Enabled = true;
                    }



                    //1 DEPARTAMENTOS DE PASILLO
                    //2 DEPARTAMENTOS AMUEBLADOS
                    //3 DEPARTAMENTOS DE 1 AMBIENTE
                    //4 DEPARTAMENTOS DE 1 DORMITORIO
                    //5 DEPARTAMENTOS DE 2 DORMITORIOS
                    //6 DEPARTAMENTOS DE 3 DORMITORIOS
                    //7 DEPARTAMENTOS DE 4 DORMITORIOS O MAS
                    //8 CASAS DE 1 DORMITORIO
                    //9 CASAS DE 2 DORMITORIOS
                    //10 CASAS DE 3 DORMITORIOS
                    //11 CASAS DE 4 DORMITORIOS O MAS
                    //13 DEPOSITOS Y GALPONES
                    //14 HOTELES, PENSIONES Y PIEZAS
                    //15 LOCALES COMERCIALES,INDUSTRIALES Y OFICINAS
                    //17 OTROS ALQUILERES
                    //16 TERRENOS
                    if (objInmueble.IDTipoDeInmueble.ToString() == "2"
                        || objInmueble.IDTipoDeInmueble.ToString() == "3"
                        || objInmueble.IDTipoDeInmueble.ToString() == "4"
                        || objInmueble.IDTipoDeInmueble.ToString() == "5"
                        || objInmueble.IDTipoDeInmueble.ToString() == "6"
                        || objInmueble.IDTipoDeInmueble.ToString() == "7")
                    {
                        txtPiso.Enabled = true;
                        txtDepartamento.Enabled = true;
                        txtFondo.Enabled = false;
                        txtFrente.Enabled = false;

                        rfvFrente.Enabled = false;
                        rfvDepartamento.Enabled = true;
                        rfvPiso.Enabled = true;
                    }
                    else if (objInmueble.IDTipoDeInmueble.ToString() == "1"
                        || objInmueble.IDTipoDeInmueble.ToString() == "13"
                        || objInmueble.IDTipoDeInmueble.ToString() == "14"
                        || objInmueble.IDTipoDeInmueble.ToString() == "15"
                        || objInmueble.IDTipoDeInmueble.ToString() == "17")
                    {
                        txtPiso.Enabled = true;
                        txtDepartamento.Enabled = true;

                        if (objInmueble.IDTipoDeInmueble.ToString() == "13")
                        {
                            txtFrente.Enabled = true;
                            txtFondo.Enabled = true;

                            rfvFrente.Enabled = true;
                        }
                        else
                        {
                            txtFrente.Enabled = false;
                            txtFondo.Enabled = false;

                            rfvFrente.Enabled = false;
                        }
                    }
                    else
                    {
                        txtPiso.Enabled = false;
                        txtDepartamento.Enabled = false;

                        txtPiso.Text = "";
                        txtDepartamento.Text = "";

                        rfvDepartamento.Enabled = false;
                        rfvPiso.Enabled = false;

                        if (objInmueble.IDTipoDeInmueble.ToString() == "8"
                            || objInmueble.IDTipoDeInmueble.ToString() == "9"
                            || objInmueble.IDTipoDeInmueble.ToString() == "10"
                            || objInmueble.IDTipoDeInmueble.ToString() == "11"
                            || objInmueble.IDTipoDeInmueble.ToString() == "16")
                        {
                            txtFrente.Enabled = true;
                            txtFondo.Enabled = true;

                            rfvFrente.Enabled = true;
                        }
                        else
                        {
                            txtFrente.Enabled = false;
                            txtFondo.Enabled = false;

                            rfvFrente.Enabled = false;
                        }
                    }
                }
            }
            catch (Exception exe)
            {
                lblError.Text = exe.Message;
            }
        }
        protected void btnAceptar_Click1(object sender, EventArgs e)
        {
            cargarPropiedad();
            Response.Redirect("~\\Admin\\AltaImagen.Aspx");
        }
        protected void btnAceptar0_Click(object sender, EventArgs e)
        {
            cargarPropiedad();
            Response.Redirect("~\\Admin\\FichaPropiedad.Aspx");
        }
        protected void cargarPropiedad()
        {
            try
            {
                Inmueble objInmueble = new Inmueble();
                objInmueble.IDInmueble = Convert.ToInt32(Session["IdInmueble"].ToString());
                objInmueble.IDTipoDeInmueble = int.Parse(ddlTipoDeInmueble.SelectedValue.ToString());
                objInmueble.IDEstado = int.Parse(ddlEstado.SelectedValue.ToString());
                objInmueble.IDOperacion = int.Parse(ddlOperacion.SelectedValue.ToString());
                objInmueble.IDLocalidad = int.Parse(ddlLocalidades.SelectedValue.ToString());
                objInmueble.IDZona = int.Parse(ddlZonas.SelectedValue.ToString());
                objInmueble.IDProvincia = int.Parse(ddlProvincias.SelectedValue.ToString());
                objInmueble.Calle = txtCalle.Text;
                objInmueble.Numero = txtNumero.Text;
                objInmueble.Piso = txtPiso.Text;
                objInmueble.Departamento = txtDepartamento.Text;
                objInmueble.Calle1 = txtCalle1.Text;
                objInmueble.Calle2 = txtCalle2.Text;
                objInmueble.MetrosCuadrados = double.Parse(txtMetrosCuadrados.Text);


                if (txtAntiguedad.Text != "")
                    objInmueble.AntiguedadA = int.Parse(txtAntiguedad.Text);
                if (txtMetrosCuadradosSemi.Text != "")
                    objInmueble.MetrosCuadradosSemiCubiertos = double.Parse(txtMetrosCuadradosSemi.Text);
                if (txtFrente.Text != "")
                    objInmueble.Frente = double.Parse(txtFrente.Text);
                if (txtFondo.Text != "")
                    objInmueble.Fondo = double.Parse(txtFondo.Text);
                if (txtPrecioDeVenta.Text != "")
                    objInmueble.PrecioVenta = double.Parse(txtPrecioDeVenta.Text);
                if (txtPrecioDeAlquiler.Text != "")
                    objInmueble.PrecioAlquiler = double.Parse(txtPrecioDeAlquiler.Text);

                objInmueble.Observaciones = txtObservaciones.Content;
                objInmueble.Publica = rblVisible.SelectedValue.ToString();
                objInmueble.Cocheras = rblCocheras.SelectedValue.ToString();
                objInmueble.Antiguedad = rblAntiguedad.SelectedValue.ToString();

                if (rblPosicion.SelectedValue.ToString() != "Sin Posición")
                    objInmueble.Posicion = rblPosicion.SelectedValue.ToString();

                objInmueble.MonedaAlquiler = ddlMonedaAlquiler.SelectedValue.ToString();
                objInmueble.MonedaVenta = ddlMonedaVenta.SelectedValue.ToString();

                InmueblesBLL bllInmuebles = new InmueblesBLL();
                bllInmuebles.Update(objInmueble);
            }
            catch (Exception exe)
            {
                lblError.Text = exe.Message.ToString();

            }
        }
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Propiedades.aspx");
        }
        protected void ddlLocalidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlLocalidades.SelectedIndex == 0)
                rfvLocalidades.Visible = true;
            if (ddlZonas.Items.Count <= 1)
                rfvZonas.Enabled = false;
            else
                rfvZonas.Enabled = true;
        }
        protected void ddlOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlOperacion.SelectedValue.ToString() == "1")
            {
                txtPrecioDeAlquiler.Enabled = false;
                ddlMonedaAlquiler.Enabled = false;
                txtPrecioDeVenta.Enabled = true;
                ddlMonedaVenta.Enabled = true;
                txtPrecioDeAlquiler.Text = "";

                rfvPrecioDeAlquiler.Enabled = false;
                rfvPrecioDeVenta.Enabled = true;
            }
            else if (ddlOperacion.SelectedValue.ToString() == "2")
            {
                txtPrecioDeAlquiler.Enabled = true;
                ddlMonedaAlquiler.Enabled = true;
                txtPrecioDeVenta.Enabled = false;
                ddlMonedaVenta.Enabled = false;
                txtPrecioDeVenta.Text = "";

                rfvPrecioDeAlquiler.Enabled = true;
                rfvPrecioDeVenta.Enabled = false;
            }
            else if (ddlOperacion.SelectedValue.ToString() == "3")
            {
                txtPrecioDeAlquiler.Enabled = true;
                ddlMonedaAlquiler.Enabled = true;
                txtPrecioDeVenta.Enabled = true;
                ddlMonedaVenta.Enabled = true;

                rfvPrecioDeAlquiler.Enabled = true;
                rfvPrecioDeVenta.Enabled = true;
            }
        }
        protected void ddlTipoDeInmueble_SelectedIndexChanged(object sender, EventArgs e)
        {
            //2 	DEPARTAMENTOS AMUEBLADOS 
            //3 	DEPARTAMENTOS DE 1 AMBIENTE 
            //4 	DEPARTAMENTOS DE 1 DORMITORIO 
            //5 	DEPARTAMENTOS DE 2 DORMITORIOS 
            //6 	DEPARTAMENTOS DE 3 DORMITORIOS 
            //7 	DEPARTAMENTOS DE 4 DORMITORIOS O MAS
            if (ddlTipoDeInmueble.SelectedValue.ToString() == "2"
             || ddlTipoDeInmueble.SelectedValue.ToString() == "3"
             || ddlTipoDeInmueble.SelectedValue.ToString() == "4"
             || ddlTipoDeInmueble.SelectedValue.ToString() == "5"
             || ddlTipoDeInmueble.SelectedValue.ToString() == "6"
             || ddlTipoDeInmueble.SelectedValue.ToString() == "7")
            {
                txtPiso.Enabled = true;
                txtDepartamento.Enabled = true;
                txtFrente.Enabled = false;
                txtFondo.Enabled = false;
                txtPiso.Text = "";
                txtDepartamento.Text = "";
                txtFrente.Text = "";
                txtFondo.Text = "";

                rfvDepartamento.Enabled = true;
                rfvPiso.Enabled = true;
                rfvFrente.Enabled = false;


            }

            //1 	DEPARTAMENTOS DE PASILLO 
            //13 	DEPOSITOS Y GALPONES 
            //14 	HOTELES, PENSIONES Y PIEZAS 
            //15 	LOCALES COMERCIALES,INDUSTRIALES Y OFICINAS        
            //17 	OTROS INMUEBLES 

            else if (ddlTipoDeInmueble.SelectedValue.ToString() == "1"
                || ddlTipoDeInmueble.SelectedValue.ToString() == "13"
                || ddlTipoDeInmueble.SelectedValue.ToString() == "14"
                || ddlTipoDeInmueble.SelectedValue.ToString() == "15"
                || ddlTipoDeInmueble.SelectedValue.ToString() == "17")
            {
                txtPiso.Enabled = true;
                txtDepartamento.Enabled = true;
                txtPiso.Text = "";
                txtDepartamento.Text = "";

                //13 	DEPOSITOS Y GALPONES 
                if (ddlTipoDeInmueble.SelectedValue.ToString() == "13")
                {
                    txtFrente.Enabled = true;
                    txtFondo.Enabled = true;
                    rfvFrente.Enabled = true;
                }
                else
                {
                    txtFrente.Enabled = false;
                    txtFondo.Enabled = false;
                    rfvFrente.Enabled = false;

                    txtFrente.Text = "";
                    txtFondo.Text = "";
                }
            }


            //12 	COCHERAS, ESTACIONAMIENTOS Y GARAGES         
            //18 	FONDOS DE COMERCIO 
            else
            {
                txtPiso.Enabled = false;
                txtDepartamento.Enabled = false;
                txtPiso.Text = "";
                txtDepartamento.Text = "";

                rfvDepartamento.Enabled = false;
                rfvPiso.Enabled = false;

                //8 	CASAS DE 1 DORMITORIO 
                //9 	CASAS DE 2 DORMITORIOS 
                //10 	CASAS DE 3 DORMITORIOS 
                //11 	CASAS DE 4 DORMITORIOS O MAS 
                //16 	TERRENOS
                if (ddlTipoDeInmueble.SelectedValue.ToString() == "8"
                    || ddlTipoDeInmueble.SelectedValue.ToString() == "9"
                    || ddlTipoDeInmueble.SelectedValue.ToString() == "10"
                    || ddlTipoDeInmueble.SelectedValue.ToString() == "11"
                    || ddlTipoDeInmueble.SelectedValue.ToString() == "16")
                {
                    txtFrente.Enabled = true;
                    txtFondo.Enabled = true;
                    rfvFrente.Enabled = true;
                }

                else
                {
                    txtFrente.Enabled = false;
                    txtFondo.Enabled = false;
                    rfvFrente.Enabled = false;

                    txtFrente.Text = "";
                    txtFondo.Text = "";
                }
            }
        }
        protected void rblAntiguedad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rblAntiguedad.SelectedValue.ToString() == "A Estrenar" || rblAntiguedad.SelectedValue.ToString() == "En Construcción")
            {
                txtAntiguedad.Enabled = false;
                txtAntiguedad.Text = "";
            }
            else if (rblAntiguedad.SelectedValue.ToString() == "Usado")
            {
                txtAntiguedad.Enabled = true;
                txtAntiguedad.Text = "";
            }
        }
        protected void ddlProvincias_DataBound(object sender, EventArgs e)
        {
            if (!IsPostBack)
                if (objInmueble != null)
                    ddlProvincias.SelectedValue = objInmueble.IDProvincia.ToString();
        }
        protected void ddlLocalidades_DataBound(object sender, EventArgs e)
        {
            if (!IsPostBack)
                if (objInmueble != null)
                    ddlLocalidades.SelectedValue = objInmueble.IDLocalidad.ToString();
        }
        protected void ddlZonas_DataBound(object sender, EventArgs e)
        {
            if (!IsPostBack)
                if (objInmueble != null)
                    ddlZonas.SelectedValue = objInmueble.IDZona.ToString();
            if (ddlZonas.Items.Count <= 1)
                rfvZonas.Enabled = false;
            else
                rfvZonas.Enabled = true;
        }
    }
}