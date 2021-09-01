using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBases
{
    class HistoriaLogin
    {
        private int log_Id;

        public int Log_Id
        {
            get { return log_Id; }
            set { log_Id = value; }
        }
        private DateTime log_Fecha_Hora;

        public DateTime Log_Fecha_Hora
        {
            get { return log_Fecha_Hora; }
            set { log_Fecha_Hora = value; }
        }
        private string log_Descripcion;

        public string Log_Descripcion
        {
            get { return log_Descripcion; }
            set { log_Descripcion = value; }
        }
    }
}
