using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBases
{
    class Usuario
    {
        private int usu_Id;

        public int Usu_Id
        {
            get { return usu_Id; }
            set { usu_Id = value; }
        }
        private string usu_Apellido_Nombre;

        public string Usu_Apellido_Nombre
        {
            get { return usu_Apellido_Nombre; }
            set { usu_Apellido_Nombre = value; }
        }
        private string usu_Nombre_Usuario;

        public string Usu_Nombre_Usuario
        {
            get { return usu_Nombre_Usuario; }
            set { usu_Nombre_Usuario = value; }
        }
        private string usu_Password;

        public string Usu_Password
        {
            get { return usu_Password; }
            set { usu_Password = value; }
        }
        private int rol_Id;

        public int Rol_Id
        {
            get { return rol_Id; }
            set { rol_Id = value; }
        }
    }
}
