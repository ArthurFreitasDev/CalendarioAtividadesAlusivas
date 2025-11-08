using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarioAtividadesAlusivas.Classes
{
    public class ControleMes
    {
        public string MesAtual { get; set; }
        public void TrocaTela_MesAtual(string mesAtual)
        {
            
            MesAtual = mesAtual;
            Console.WriteLine("=======================================================================");
            Console.WriteLine($"MesAtual set to: {MesAtual}");
            Console.WriteLine("=====================================================================");
        }

        public string getTrocaTela_MesAtual()
        {
            return MesAtual;
        }
    }
}
