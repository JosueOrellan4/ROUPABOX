using roupabox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Roupabox
{
    internal class Clientes
    {
        List<ClienteCad>listaClientes = new List<ClienteCad>();
        public ClienteCad cadCliente()
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


            Regex regex = new Regex(@"^[a-zA-ZÀ-ÿ\s]+$");

            while (string.IsNullOrWhiteSpace(nomeCli) || nomeCli.Trim().Split(' ').Length < 2 || !regex.IsMatch(nomeCli)) //verifica se o usuario não digitou nada ou apenas pressionou espaços||divide o texto em tudas partes e verifica se há pelo menos dois elementos||o regex faz com que ele aceite apenas os caracteres que eu coloquei na instancia 

                    {
                Console.WriteLine("Erro: O nome deve conter apenas letras, espaços e pelo menos dois nomes (nome e sobrenome).");
                Console.WriteLine("\nDigite o nome novamente:");
                nomeCli = Console.ReadLine();   
            }
            
            var Cliente  = new ClienteCad(nomeCli);


            Console.WriteLine("\nDigite o CPF do Cliente:");
            string cpfCli = Console.ReadLine();

            while (cpfCli.Length != 11 || !cpfCli.All(char.IsDigit))
            {
                Console.WriteLine("Erro: O CPF deve conter exatamente 11 digitos.");
                Console.WriteLine("\nDigite o CPF novamente:");
                cpfCli = Console.ReadLine();
            }


             Console.WriteLine("\nDigite o Telefone do Cliente:");
             int telCli = int.Parse(Console.ReadLine());

             Console.WriteLine("\nDigite a idade do Cliente:");
             int idadeCli = int.Parse(Console.ReadLine());

             Console.WriteLine("\nDigite o E-mail do Cliente:");
             string emailCli = Console.ReadLine();

            while (!emailCli.Contains("@"))
            {
                Console.WriteLine("Erro: E-mail inválido.");
                Console.WriteLine("\nDigite o E-mail novamente:");
                emailCli = Console.ReadLine();
            }


             Console.WriteLine("\nDigite o Sexo do Cliente:");
             string sexoCli = Console.ReadLine();

             Console.WriteLine("\nDigite a Rua / Avenida do Cliente:");
             string ruaCli = Console.ReadLine();

             Console.WriteLine("\nDigite o complemento da rua caso tenha:");
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

            listaClientes.Add(Cliente);

            Console.WriteLine("Cliente cadastrado com sucesso!!!!");

            foreach (var cliente in listaClientes)
            {
                Console.WriteLine($"Nome: {cliente.nomeCli}, " + $"CPF: {cliente.cpfCli} " );
            }

            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey(); 
            Console.Clear();

            Cabec variavelCabecalho = new Cabec();
            variavelCabecalho.Cabecalho();

            Clientes varCli  = new Clientes();

            ExibirMenu variavelMenu = new ExibirMenu();

            return Cliente;

        }
    }
}
