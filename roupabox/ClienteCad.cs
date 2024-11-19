using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roupabox
{
    internal class ClienteCad
    {
        public ClienteCad(string cli) 
        {
            nomeCli = cli;
        }
        public string nomeCli { get; set;}
        public string cpfCli { get; set;}
        public int telCli { get; set;}
        public int idadeCli { get; set;}

        public string emailCli { get; set; }

        public string sexoCli { get; set;}

        public string ruaCli { get; set;}

        public string compCli { get; set;}

        public int numCli { get; set;}

        public string bairroCli { get; set;}

        public string cidCli { get; set;}

        public string estCli { get; set;}

        public long cepCli { get; set;}


    }
}
