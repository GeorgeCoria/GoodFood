using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBases
{
    class Articulo
    {
        private int art_Id;
        private string art_Descripcion;
        private double art_Precio;
        private bool art_Maneja_Stock;
        private int fam_Id; 
        private int cat_Id;
        private int um_Id;

        public int Fam_Id
        {
            get { return fam_Id; }
            set { fam_Id = value; }
        }
       

        public int Cat_Id
        {
            get { return cat_Id; }
            set { cat_Id = value; }
        }
        

        public int Um_Id
        {
            get { return um_Id; }
            set { um_Id = value; }
        }

        public int Art_Id
        {
            get { return art_Id; }
            set { art_Id = value; }
        }
        

        public string Art_Descripcion
        {
            get { return art_Descripcion; }
            set { art_Descripcion = value; }
        }
                

        public double Art_Precio
        {
            get { return art_Precio; }
            set { art_Precio = value; }
        }


        public bool Art_Maneja_Stock
        {
            get { return art_Maneja_Stock; }
            set { art_Maneja_Stock = value; }
        }
    }
}
