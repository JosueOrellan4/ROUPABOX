using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace roupabox
{
    public class Cabecalho
    {
        public static void ExibirCabecalho()
        { 
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("════════════════════════════════════");
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("Autor: Mr. Josue");
            Console.ForegroundColor = ConsoleColor.Red ;
            Console.WriteLine("════════════════════════════════════");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
██████╗░░█████╗░██╗░░░██╗██████╗░░█████╗░██████╗░░█████╗░██╗░░██╗
██╔══██╗██╔══██╗██║░░░██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗╚██╗██╔╝
██████╔╝██║░░██║██║░░░██║██████╔╝███████║██████╦╝██║░░██║░╚███╔╝░
██╔══██╗██║░░██║██║░░░██║██╔═══╝░██╔══██║██╔══██╗██║░░██║░██╔██╗░
██║░░██║╚█████╔╝╚██████╔╝██║░░░░░██║░░██║██████╦╝╚█████╔╝██╔╝╚██╗
╚═╝░░╚═╝░╚════╝░░╚═════╝░╚═╝░░░░░╚═╝░░╚═╝╚═════╝░░╚════╝░╚═╝░░╚═╝");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("════════════════════════════════════");
            Console.ResetColor();
            Thread.Sleep(4000);
            Console.Clear();
            
        }

    }
}
