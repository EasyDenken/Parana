using System;
using System.Collections.Generic;
using System.Text;

namespace ViveICASimuladorOBJ
{
    public class Plazas
    {
        private string nombre;
        private int plazaID;

        public Plazas()
        {
        }

        public Plazas(int _idPlazaID)
        {
            plazaID = _idPlazaID;
        }
        public int PlazaID
        {
            get { return plazaID; }
            set { plazaID = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }
}
