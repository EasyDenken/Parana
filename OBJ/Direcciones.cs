using System;
using System.Collections.Generic;
using System.Text;

namespace RioParanaOBJ
{
    public class Direcciones
    {
        private string direccion1;
        private string direccion2;
        private string direccion3;
        private string direccion4;

        public Direcciones()
        {

        }
        public Direcciones(string _direccion1)
        {
            direccion1 = _direccion1;
        }
        public Direcciones(string _direccion1, string _direccion2)
        {
            direccion1 = _direccion1;
            direccion2 = _direccion2;
        }
        public Direcciones(string _direccion1, string _direccion2, string _direccion3)
        {
            direccion1 = _direccion1;
            direccion2 = _direccion2;
            direccion3 = _direccion3;
        }

        public Direcciones(string _direccion1, string _direccion2, string _direccion3, string _direccion4)
        {
            direccion1 = _direccion1;
            direccion2 = _direccion2;
            direccion3 = _direccion3;
            direccion4 = _direccion4;
        }

        public string Direccion1
        {
            get { return direccion1; }
            set { direccion1 = value; }
        }

        public string Direccion2
        {
            get { return direccion2; }
            set { direccion2 = value; }
        }

        public string Direccion3
        {
            get { return direccion3; }
            set { direccion3 = value; }
        }

        public string Direccion4
        {
            get { return direccion4; }
            set { direccion4 = value; }
        }
    }
}
