using System;
using System.Collections.Generic;
using System.Text;

namespace RioParanaOBJ
{
    public class Usuario
    {
        private string idUsuario;
        private string nombre;
        private string apellido;
        private string telefono;
        private string celular;
        private string dni;
        private Direcciones direcciones;
        private EMails emails;
        private int pais;
        private int provincia;
        private int ciudad;
        private int idInmobiliaria;
        private DateTime fechaNac;

        public Usuario()
        {

        }

        public string IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }
        public string DNI
        {
            get { return dni; }
            set { dni = value; }
        }
        public int IdInmobiliaria
        {
            get { return idInmobiliaria; }
            set { idInmobiliaria = value; }
        }
    }
}
