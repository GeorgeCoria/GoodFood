using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBases
{
    class ItemPedido
    {
        private int ip_Id;
        private double ip_Precio;
        private double ip_Cantidad;
        private double ip_Importe;
        private int art_Id;
        private int ped_Id;

        public int Ped_Id
        {
            get { return ped_Id; }
            set { ped_Id = value; }
        }


        public int Ip_Id
        {
            get { return ip_Id; }
            set { ip_Id = value; }
        }
        

        public double Ip_Precio
        {
            get { return ip_Precio; }
            set { ip_Precio = value; }
        }
        

        public double Ip_Cantidad
        {
            get { return ip_Cantidad; }
            set { ip_Cantidad = value; }
        }
        
        public double Ip_Importe
        {
            get { return ip_Importe; }
            set { ip_Importe = value; }
        }
        

        public int Art_Id
        {
            get { return art_Id; }
            set { art_Id = value; }
        }

    }
}
