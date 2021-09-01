using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBases
{
    class UnidadMedida
    {
        private int um_Id;

        public int Um_Id
        {
            get { return um_Id; }
            set { um_Id = value; }
        }
        private string um_Descripcion;

        public string Um_Descripcion
        {
            get { return um_Descripcion; }
            set { um_Descripcion = value; }
        }
        private string um_Abreviatura;

        public string Um_Abreviatura
        {
            get { return um_Abreviatura; }
            set { um_Abreviatura = value; }
        }
    }
}
