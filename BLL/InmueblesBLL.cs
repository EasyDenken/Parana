using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using RioParanaDAL;
using RioParanaOBJ;
using System.Collections;

namespace RioParanaBLL
{
    public class InmueblesBLL
    {
        InmueblesDAL dataAccessInmuebles;

        public InmueblesBLL()
        {
            this.dataAccessInmuebles = new InmueblesDAL();
        }

        public DataTable SeleccionaInmuebles()
        {
            return this.dataAccessInmuebles.SeleccionaInmuebles(0, 0, "");
        }

        public DataTable SeleccionaInmuebles(int tipo, int operacion, string orden)
        {
            return this.dataAccessInmuebles.SeleccionaInmuebles(tipo, operacion, orden);
        }

        public DataTable SeleccionaInmueblesBusqueda2(int tipo, int operacion, string orden)
        {
            return this.dataAccessInmuebles.SeleccionaInmueblesBusqueda2(tipo, operacion, orden);
        }

        public DataTable SeleccionaInmueblesBusqueda(Inmueble objInmueble, int tipoPropiedad)
        {
            return this.dataAccessInmuebles.SeleccionaInmueblesBusqueda(objInmueble, tipoPropiedad);
        }

        public DataTable SeleccionaInmueblesFavoritos(string operacion)
        {
            return this.dataAccessInmuebles.SeleccionaInmueblesFavoritos(operacion);
        }

        public DataTable SeleccionaTiposDeInmueblesPorPadre(string tipoPadre)
        {
            return this.dataAccessInmuebles.SeleccionaTiposDeInmueblesPorPadre(tipoPadre);
        }

        public DataTable SeleccionaTiposDeInmuebles()
        {
            return this.dataAccessInmuebles.SeleccionaTiposDeInmuebles();
        }

        public void Insert(Inmueble objInmueble)
        {
            this.dataAccessInmuebles.Insert(objInmueble);
        }

        public void Update(Inmueble objInmueble)
        {
            this.dataAccessInmuebles.Update(objInmueble);
        }

        public DataTable SeleccionaInmueblesPorID(int IDInmueble)
        {
            return this.dataAccessInmuebles.SeleccionaInmueblePorID(IDInmueble);
        }

        public DataTable SeleccionaInmueblesDistintosDeID(int IDInmueble, int IDInmueble2, int IDInmueble3)
        {
            return this.dataAccessInmuebles.SeleccionaInmueblesDistintosDeID(IDInmueble, IDInmueble2, IDInmueble3);
        }

        public Inmueble SeleccionaInmueblePorID(string IdInmueble)
        {
            Inmueble objInmueble = new Inmueble();
            DataTable dt = this.dataAccessInmuebles.SeleccionaInmueblePorID(IdInmueble);
            objInmueble.Calle = dt.Rows[0]["Calle"].ToString();
            objInmueble.Numero = dt.Rows[0]["Numero"].ToString();
            objInmueble.Piso = dt.Rows[0]["Piso"].ToString();
            objInmueble.Departamento = dt.Rows[0]["Departamento"].ToString();
            objInmueble.Cocheras = dt.Rows[0]["Cocheras"].ToString();
            objInmueble.Calle1 = dt.Rows[0]["Calle1"].ToString();
            objInmueble.Calle2 = dt.Rows[0]["Calle2"].ToString();
            objInmueble.AntiguedadA = int.Parse(dt.Rows[0]["AntiguedadA"].ToString());
            objInmueble.MetrosCuadrados = double.Parse(dt.Rows[0]["MetroCuadrados"].ToString());
            objInmueble.PrecioVenta = double.Parse(dt.Rows[0]["PrecioVenta"].ToString());
            objInmueble.PrecioAlquiler = double.Parse(dt.Rows[0]["PrecioAlquiler"].ToString());
            objInmueble.Observaciones = dt.Rows[0]["Observaciones"].ToString();
            objInmueble.IDEstado = int.Parse(dt.Rows[0]["IdEstado"].ToString());
            objInmueble.IDTipoDeInmueble = int.Parse(dt.Rows[0]["IdTipoDeInmueble"].ToString());
            objInmueble.IDOperacion = int.Parse(dt.Rows[0]["IdOperacion"].ToString());
            objInmueble.Publica = dt.Rows[0]["Publica"].ToString();
            objInmueble.IDProvincia = int.Parse(dt.Rows[0]["idProvincia"].ToString());
            objInmueble.IDLocalidad = int.Parse(dt.Rows[0]["idLocalidad"].ToString());
            objInmueble.MonedaAlquiler = dt.Rows[0]["MonedaAlquiler"].ToString();
            objInmueble.MonedaVenta = dt.Rows[0]["MonedaVenta"].ToString();
            objInmueble.Antiguedad = dt.Rows[0]["Antiguedad"].ToString();
            objInmueble.Posicion = dt.Rows[0]["Posicion"].ToString();
            objInmueble.IDZona = int.Parse(dt.Rows[0]["IdZona"].ToString());
            if (dt.Rows[0]["MetrosCuadradosSemiCub"].ToString() != "")
            {
                objInmueble.MetrosCuadradosSemiCubiertos = double.Parse(dt.Rows[0]["MetrosCuadradosSemiCub"].ToString());
            }

            if (dt.Rows[0]["Frente"].ToString() != "")
            {
                objInmueble.Frente = double.Parse(dt.Rows[0]["Frente"].ToString());
            }

            if (dt.Rows[0]["Fondo"].ToString() != "")
            {
                objInmueble.Fondo = double.Parse(dt.Rows[0]["Fondo"].ToString());
            }

            return objInmueble;
        }

        public string SeleccionaIdDelUltimoInmueble()
        {
            DataTable dt = this.dataAccessInmuebles.SeleccionaIdDelUltimoInmueble();
            return dt.Rows[0]["IdInmueble"].ToString();
        }

        public void Delete(string IdInmueble)
        {
            this.dataAccessInmuebles.Delete(IdInmueble);
        }

        public int SeleccionaCantidadInmuebles(int TipoInmueble)
        {
            DataTable dt = this.dataAccessInmuebles.SeleccionaCantidadInmueble(TipoInmueble);
            return Convert.ToInt32(dt.Rows[0]["cantidad"]);
        }

        public void UpdateFavoritos(List<Inmueble> lstInmuebles)
        {
            try
            {
                this.dataAccessInmuebles.UpdateFavoritos(lstInmuebles);
            }
            catch (Exception exe)
            {
                throw exe;
            }
        }

    }
}