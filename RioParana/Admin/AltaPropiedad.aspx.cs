using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RioParanaBLL;
using RioParanaOBJ;

namespace RioParana.Admin
{
    public partial class AltaPropiedad : System.Web.UI.Page
    {
        OperacionesBLL bllOperacionDeInmuebles;
        EstadosBLL bllEstadosDeInmuebles;
        TiposBLL bllTiposDeInmuebles;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                this.bllOperacionDeInmuebles = new OperacionesBLL();
                this.bllEstadosDeInmuebles = new EstadosBLL();
                this.bllTiposDeInmuebles = new TiposBLL();

                this.ddlProvincias.SelectedValue = "20";
            }

        }

        //Boton Aceptar - Guarda la propiedad y direcciona a la pagina de carga de imagenes
        protected void btnAceptar_Click1(object sender, EventArgs e)
        {

            cargarPropiedad();

            try
            {
                InmueblesBLL bllInmuebles = new InmueblesBLL();
                string ID = bllInmuebles.SeleccionaIdDelUltimoInmueble();

                Session["IdInmueble"] = ID;
                //Response.Redirect("AltaImagenes.Aspx?id=" + ID);
                Response.Redirect("~\\Admin\\AltaImagen.aspx");
            }
            catch
            {

            }

        }

        //Boton Finalizar - Guarda la propiedad y direcciona a la pagina de la Ficha
        protected void btnAceptar0_Click(object sender, EventArgs e)
        {

            cargarPropiedad();

            try
            {
                InmueblesBLL bllInmuebles = new InmueblesBLL();
                string ID = bllInmuebles.SeleccionaIdDelUltimoInmueble();

                Session["IdInmueble"] = ID;
                //Response.Redirect("AltaImagenes.Aspx?id=" + ID);
                Response.Redirect("~\\Admin\\FichaPropiedad.aspx");
            }
            catch
            {

            }
        }



        protected void cargarPropiedad()
        {
            try
            {
                Inmueble objInmueble = new Inmueble();
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
                {
                    objInmueble.AntiguedadA = int.Parse(txtAntiguedad.Text);
                }

                if (txtMetrosCuadradosSemi.Text != "")
                {
                    objInmueble.MetrosCuadradosSemiCubiertos = double.Parse(txtMetrosCuadradosSemi.Text);
                }

                if (txtFrente.Text != "")
                {
                    objInmueble.Frente = double.Parse(txtFrente.Text);
                }

                if (txtFondo.Text != "")
                {
                    objInmueble.Fondo = double.Parse(txtFondo.Text);
                }

                if (txtPrecioDeVenta.Text != "")
                {
                    objInmueble.PrecioVenta = double.Parse(txtPrecioDeVenta.Text);
                }

                if (txtPrecioDeAlquiler.Text != "")
                {
                    objInmueble.PrecioAlquiler = double.Parse(txtPrecioDeAlquiler.Text);
                }
                objInmueble.Observaciones = txtObservaciones.Content;
                objInmueble.Publica = rblVisible.SelectedValue.ToString();
                objInmueble.Cocheras = rblCocheras.SelectedValue.ToString();
                objInmueble.Antiguedad = rblAntiguedad.SelectedValue.ToString();

                if (rblPosicion.SelectedValue.ToString() != "Sin Posición")
                {
                    objInmueble.Posicion = rblPosicion.SelectedValue.ToString();
                }

                objInmueble.MonedaAlquiler = ddlMonedaAlquiler.SelectedValue.ToString();
                objInmueble.MonedaVenta = ddlMonedaVenta.SelectedValue.ToString();


                InmueblesBLL bllInmuebles = new InmueblesBLL();
                bllInmuebles.Insert(objInmueble);

            }
            catch (Exception exe)
            {
                lblError.Text = exe.Message.ToString();

            }
            finally
            {

            }
        }





        //Botton Cancelar
        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Propiedades.aspx");
        }

        //DropDownList Tipo de Operacion habilita o deshabilita Campos
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


        //DropDownList Tipo de Inmueble habilita o deshabilita Campos
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

        protected void ddlZonas_DataBound(object sender, EventArgs e)
        {
            if (ddlZonas.Items.Count <= 1)
            {
                rfvZonas.Enabled = false;
            }
            else
            {
                rfvZonas.Enabled = true;
            }
        }
    }
}