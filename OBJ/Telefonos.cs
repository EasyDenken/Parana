using System;
using System.Collections.Generic;
using System.Text;

namespace RioParanaOBJ
{
    public class Telefonos
    {
        private string telefono1;
        private string telefono2;
        private string telefono3;
        private string telefono4;

        public Telefonos()
        {

        }
        public Telefonos(string _telefono1)
        {
            telefono1 = _telefono1;
        }
        public Telefonos(string _telefono1, string _telefono2)
        {
            telefono1 = _telefono1;
            telefono2 = _telefono2;
        }
        public Telefonos(string _telefono1, string _telefono2, string _telefono3)
        {
            telefono1 = _telefono1;
            telefono2 = _telefono2;
            telefono3 = _telefono3;
        }

        public Telefonos(string _telefono1, string _telefono2, string _telefono3, string _telefono4)
        {
            telefono1 = _telefono1;
            telefono2 = _telefono2;
            telefono3 = _telefono3;
            telefono4 = _telefono4;
        }

        public string Telefono1
        {
            get { return telefono1; }
            set { telefono1 = value; }
        }
        
        public string Telefono2
        {
            get { return telefono2; }
            set { telefono2 = value; }
        }

        public string Telefono3
        {
            get { return telefono3; }
            set { telefono3 = value; }
        }
        
        public string Telefono4
        {
            get { return telefono4; }
            set { telefono4 = value; }
        }
    }
}
