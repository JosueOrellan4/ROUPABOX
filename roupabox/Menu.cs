using Roupabox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roupabox
{
    internal class Menu
    {
        public static void ExibirMenu()
        {
            Console.WriteLine("Digite 0 para Sair");
            Console.WriteLine("Digite 1 Cadastro de Clientes");
            Console.WriteLine("Digite 2 Listar Clientes");
            Console.WriteLine("Digite 3 Cadastro de Produtos");
            Console.WriteLine("Digite 4 Listar Produtos");
            Console.WriteLine("\nDigite a opção escolhida:");
            int numero = int.Parse(Console.ReadLine());

            switch (numero)
            {
                
                case 1:
                   Clientes variavelCliente = new Clientes();
                    variavelCliente.cadCliente();
                    break;
                case 2:
                    
                    break;
                case 3:
                    Produto variavelProduto = new Produto();
                    variavelProduto.cadProduto();
                    break;
                case 4:
                  
                    break;
            }
        }
    }
}
