using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarioAtividadesAlusivas.Models
{
    public class Dias
    {
        public int Dia { get; set; }
        public string Dia_Semana { get; set; }
        public string DataEspecial { get; set; }
        public int LinhaCalendario { get; set; }
        public string Mes { get; set; } 
        public string linkVideo { get; set; }
        public string Texto { get; set; }
    }
}
