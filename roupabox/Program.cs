using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roupabox
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Cabecalho cabecalho = new Cabecalho();
            Cabecalho.ExibirCabecalho();

            Menu menu = new Menu();
            Menu.ExibirMenu();



            
        }
    }
}
