using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegradorReal
{
    public class status
    {
        public status(int registro, string tabela)
        {
            this.registro = registro;
            this.tabela = tabela;
        }

        public int registro { get; set; }
        public string tabela { get; set; }
        //public string sub1 { get; set; }
        //public string sub2 { get; set; }
        //public string sub3 { get; set; }

        public status ()
        {
        }

        public static List<status> list = new List<status> ();

    }
}
