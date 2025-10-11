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
        public string Data_Especial { get; set; }

        public class ListaJaneiro
        {
            public List<Dias> Janeiro { get; set; }
        }
        public class Lista_Janeiro
        {
            public ListaJaneiro ListaJaneiro { get; set; }
        }
    }
}
