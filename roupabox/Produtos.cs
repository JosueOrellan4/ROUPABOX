using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roupabox
{
    internal class Produtos
    {
        List<ProdutoCad> listaProdutos = new List<ProdutoCad>();
        public ProdutoCad cadProduto()
        {


            Console.Clear();
            Console.WriteLine("Registro de Produto");

            Console.WriteLine("Digite a descrição do produto:");
            string descPro = Console.ReadLine();

            var Produto = new ProdutoCad(descPro);

            Console.WriteLine("\nDigite a marca do produto:");
            string marcaPro = Console.ReadLine();
            Produto.marcaPro = marcaPro;

            Console.WriteLine("Digite o tamanho do produto (P M G GG XGG:");
            string tamPro = Console.ReadLine();
            Produto.tamPro = tamPro;


            Console.WriteLine("Digite a cor do produto:");
            string corPro = Console.ReadLine();
            Produto.corPro = corPro;

            Console.WriteLine("Digite a categoria do produto:");
            string catPro = Console.ReadLine();
            Produto.catPro = catPro;

            Console.WriteLine("Digite o valor do produto:");
            double valPro = double.Parse(Console.ReadLine());
            Produto.valPro = valPro;

            Console.WriteLine("Digite o peso do produto:");
            double pesoPro = double.Parse(Console.ReadLine());
            Produto.pesoPro = pesoPro;

            listaProdutos.Add(Produto);

            Console.WriteLine($"O Produto foi cadastrado");

            foreach (var produto in listaProdutos)
            {
                Console.WriteLine($"Descrição: {produto.descPro}, " + $"Valor: {produto.valPro} ");
            }

            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();



            Cabec variavelCabecalho = new Cabec();
            variavelCabecalho.Cabecalho();

            Produtos varPro = new Produtos();
            ExibirMenu variavelMenu = new ExibirMenu();

            return Produto;


        }
        public void listarProdutos()
        {
            Console.Clear();
            Console.WriteLine("Lista de Produtos Cadastrados");

            foreach(var produto in listaProdutos)
            {
                Console.WriteLine($"Descrição: {produto.descPro}," + $"Valor:{ produto.valPro} " + $"Peso: {produto.pesoPro} ");
            }
            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();

            Cabec variavelCabecalho = new Cabec();
            variavelCabecalho.Cabecalho();
            Produtos varPro = new Produtos();
            ExibirMenu variavelmenu = new ExibirMenu();


        }
    }
}