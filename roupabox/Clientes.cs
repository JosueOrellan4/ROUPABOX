using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roupabox
{
    internal class Clientes
    {
        public void cadCliente()
        {
            Console.Clear();
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ██████╗░███████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║█████╗░░
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██╔══╝░░
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝

░█████╗░██╗░░░░░██╗███████╗███╗░░██╗████████╗███████╗░██████╗
██╔══██╗██║░░░░░██║██╔════╝████╗░██║╚══██╔══╝██╔════╝██╔════╝
██║░░╚═╝██║░░░░░██║█████╗░░██╔██╗██║░░░██║░░░█████╗░░╚█████╗░
██║░░██╗██║░░░░░██║██╔══╝░░██║╚████║░░░██║░░░██╔══╝░░░╚═══██╗
╚█████╔╝███████╗██║███████╗██║░╚███║░░░██║░░░███████╗██████╔╝
░╚════╝░╚══════╝╚═╝╚══════╝╚═╝░░╚══╝░░░╚═╝░░░╚══════╝╚═════╝░");
            Console.WriteLine("\nDigite o Nome Completo do Cliente:");
            string nomeCli = Console.ReadLine(); //armazena nome do cliente na variavel

            Console.WriteLine("\nDigite o CPF do Cliente:");
            long cpfCli = long.Parse(Console.ReadLine()); //transforma em inteiro

            Console.WriteLine("\nDigite o Telefone do Cliente:");
            int telCli = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite a idade do Cliente:");
            int idadeCli = int.Parse(Console.ReadLine());

            Console.WriteLine("\n Digite o E-mail do Cliente:");
            string emailCli = Console.ReadLine();

            Console.WriteLine("\nDigite o Sexo do Cliente:");
            string sexoCli = Console.ReadLine();

            Console.WriteLine("\nDigite a Rua / Avenida do Cliente:");
            string ruaCli = Console.ReadLine();

            Console.WriteLine("\nDogite o complemento da rua caso tenha:");
            string compCli = Console.ReadLine();

            Console.WriteLine("\nDigite o número da casa:");
            int numCli = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite o Bairro do Cliente:");
            string bairroCli = Console.ReadLine();

            Console.WriteLine("\nDigite a Cidade do Cliente:");
            string cidCli = Console.ReadLine();

            Console.WriteLine("\nDigite o Estado do Cliente:");
            string estCli = Console.ReadLine();

            Console.WriteLine("\nDigite o CEP do Cliente:");
            long cepCli = long.Parse(Console.ReadLine());

            Console.WriteLine("Cliente cadastrado com sucesso!!!!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();


        }
    }
}
