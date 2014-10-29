using System;
using System.Collections.Generic;
using System.Text;

namespace RioParanaOBJ
{
    public class Inmueble
    {
        private int idinmueble;
        private int idprovincia;
        private int idlocalidad;
        private int idZona;
        private string calle;
        private string numero;
        private string piso;
        private string departamento;
        private string calle1;
        private string calle2;
        private string observaciones;
        private int antiguedadA;
        private string cocheras;
        private double metrosCuadrados;
        private double metrosCuadradosSemiCubiertos;
        private double frente;
        private double fondo;
        private double precioVenta;
        private double precioAlquiler;
        private DateTime fechaAlta;
        private DateTime fechaActualiza;
        private string idUsuario;
        private int idEstado;
        private int idTipoDeInmueble;
        private int idOperacion;
        private string publica;
        private string monedaVenta;
        private string monedaAlquiler;
        private string antiguedad;
        private string posicion;

        private string monedaPrecioDesdeHasta;
        private double precioDesde;
        private double precioHasta;

        private int idInmobiliaria;
        private bool favorito;

        public Inmueble()
        {

        }
        public int IDInmueble
        {
            get { return idinmueble; }
            set { idinmueble = value; }
        }
        public int IDProvincia
        {
            get { return idprovincia; }
            set { idprovincia = value; }
        }
        public int IDLocalidad
        {
            get { return idlocalidad; }
            set { idlocalidad = value; }
        }
        public int IDZona
        {
            get { return idZona; }
            set { idZona = value; }
        }
        public string Calle
        {
            get { return calle; }
            set { calle = value; }
        }
        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Piso
        {
            get { return piso; }
            set { piso = value; }
        }
        public string Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }
        public string Calle1
        {
            get { return calle1; }
            set { calle1 = value; }
        }
        public string Calle2
        {
            get { return calle2; }
            set { calle2 = value; }
        }
        public string Observaciones
        {
            get { return observaciones; }
            set { observaciones = value; }
        }
        public int AntiguedadA
        {
            get { return antiguedadA; }
            set { antiguedadA = value; }
        }
        public string Cocheras
        {
            get { return cocheras; }
            set { cocheras = value; }
        }
        public double MetrosCuadrados
        {
            get { return metrosCuadrados; }
            set { metrosCuadrados = value; }
        }
        public double MetrosCuadradosSemiCubiertos
        {
            get { return metrosCuadradosSemiCubiertos; }
            set { metrosCuadradosSemiCubiertos = value; }
        }
        public double Frente
        {
            get { return frente; }
            set { frente = value; }
        }
        public double Fondo
        {
            get { return fondo; }
            set { fondo = value; }
        }
        public double PrecioVenta
        {
            get { return precioVenta; }
            set { precioVenta = value; }
        }
        public double PrecioAlquiler
        {
            get { return precioAlquiler; }
            set { precioAlquiler = value; }
        }
        public DateTime FechaAlta
        {
            get { return FechaAlta; }
            set { fechaAlta = value; }
        }
        public DateTime FechaActualiza
        {
            get { return fechaActualiza; }
            set { fechaActualiza = value; }
        }
        public string IDUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }
        public int IDEstado
        {
            get { return idEstado; }
            set { idEstado = value; }
        }
        public int IDTipoDeInmueble
        {
            get { return idTipoDeInmueble; }
            set { idTipoDeInmueble = value; }
        }
        public int IDOperacion
        {
            get { return idOperacion; }
            set { idOperacion = value; }
        }
        public string Publica
        {
            get { return publica; }
            set { publica = value; }
        }
        public string MonedaVenta
        {
            get { return monedaVenta; }
            set { monedaVenta = value; }
        }
        public string MonedaAlquiler
        {
            get { return monedaAlquiler; }
            set { monedaAlquiler = value; }
        }

        public string MonedaPrecioDesdeHasta
        {
            get { return monedaPrecioDesdeHasta; }
            set { monedaPrecioDesdeHasta = value; }
        }

        public double PrecioDesde
        {
            get { return precioDesde; }
            set { precioDesde = value; }
        }

        public double PrecioHasta
        {
            get { return precioHasta; }
            set { precioHasta = value; } 
        }

        public int IDInmobiliaria
        {
            get { return idInmobiliaria; }
            set { idInmobiliaria = value; }
        }

        public string Antiguedad
        {
            get { return antiguedad; }
            set { antiguedad = value; }
        }

        public string Posicion
        {
            get { return posicion; }
            set { posicion = value; }
        }

        public bool Favorito
        {
            get { return favorito; }
            set { favorito = value; }
        }
    }
}
