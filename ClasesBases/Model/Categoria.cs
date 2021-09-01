using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBases
{
    class Categoria
    {
        private int cat_Id;

        public int Cat_Id
        {
            get { return cat_Id; }
            set { cat_Id = value; }
        }
        private string cat_Descripcion;

        public string Cat_Descripcion
        {
            get { return cat_Descripcion; }
            set { cat_Descripcion = value; }
        }
    }
}
