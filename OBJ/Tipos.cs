using System;
using System.Collections.Generic;
using System.Text;

namespace RioParanaOBJ
{
    public class Tipos
    {
        public Tipos()
        {

        }

        public int IDTipoInmueble
        {
            get { return idTipoInmueble; }
            set { idTipoInmueble = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public string Padre
        {
            get { return padre; }
            set { padre = value; }
        }

        public string Menu
        {
            get { return menu; }
            set { menu = value; }
        }

        public string Mostrar
        {
            get { return mostrar; }
            set { mostrar = value; }
        }

        private int idTipoInmueble;
        private string tipo;
        private string padre;
        private string menu;
        private string mostrar;
    }
}
