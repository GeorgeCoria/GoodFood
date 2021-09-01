using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBases.Model
{
    class Pedido
    {
        private int ped_Id;
        private DateTime ped_Fecha_Emision;
        private DateTime ped_Fecha_Entrega;
        private int ped_Comensales;
        private bool ped_Facturado;
        private int mesa_Id;
        private int cli_Id;
        private int usu_Id;

        public int Ped_Id
        {
            get { return ped_Id; }
            set { ped_Id = value; }
        }
        

        public DateTime Ped_Fecha_Emision
        {
            get { return ped_Fecha_Emision; }
            set { ped_Fecha_Emision = value; }
        }
        

        public DateTime Ped_Fecha_Entrega
        {
            get { return ped_Fecha_Entrega; }
            set { ped_Fecha_Entrega = value; }
        }
        

        public int Ped_Comensales
        {
            get { return ped_Comensales; }
            set { ped_Comensales = value; }
        }
        

        public bool Ped_Facturado
        {
            get { return ped_Facturado; }
            set { ped_Facturado = value; }
        }
        

        public int Mesa_Id
        {
            get { return mesa_Id; }
            set { mesa_Id = value; }
        }
        

        public int Cli_Id
        {
            get { return cli_Id; }
            set { cli_Id = value; }
        }
        

        public int Usu_Id
        {
            get { return usu_Id; }
            set { usu_Id = value; }
        }
        

       
    }
}
