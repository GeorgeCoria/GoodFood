using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBases
{
    class Familia
    {
        private int fam_Id;

        public int Fam_Id
        {
            get { return fam_Id; }
            set { fam_Id = value; }
        }
        private string fam_descripcion;

        public string Fam_descripcion
        {
            get { return fam_descripcion; }
            set { fam_descripcion = value; }
        }

    }
}
