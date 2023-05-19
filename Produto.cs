using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetos_de_produtos
{
    public class Produto
    {

        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public Marca Marca = new Marca();
        public string CadastroPor { get; set; }
        List<Produto> listaDeProdutos = new List<Produto>();

        public void Cadastrar()
        {
            Produto novoProduto = new Produto();

            Console.WriteLine($"CADASTRAR UM PRODUTO !!");


            Console.WriteLine($"Digite o codigo do produto");
            novoProduto.Codigo = int.Parse(Console.ReadLine());
            Console.WriteLine($"Digite o nome do produto");
            novoProduto.NomeProduto = (Console.ReadLine());
            Console.WriteLine($"Digite o preco do produto");
            novoProduto.Preco = float.Parse(Console.ReadLine());
            Console.WriteLine($"Digite a marca do produto");
            Marca.NomeMarca = Console.ReadLine();
            Console.WriteLine($"Informe quem cadastrou o produto");
            novoProduto.CadastroPor = Console.ReadLine();

            novoProduto.DataCadastro = DateTime.Now;

    listaDeProdutos.Add(novoProduto);





        }

        public void Listar()
        {
            foreach (var item in listaDeProdutos)
            {
                  Produto novoProduto = new Produto();
            Console.WriteLine(@$"
            Codigo: {item.Codigo}
            Nome do produto: {item.NomeProduto}
            Preço: {item.Preco}
            Marca: {Marca.NomeMarca}
            Cadastrado por: {item.CadastroPor}");

            }
          
        }

        public void Deletar(int codigo)
        {
            Produto produtoEncontrado = listaDeProdutos.Find(x=> x.Codigo == codigo);

            listaDeProdutos.Remove(produtoEncontrado);
            Console.WriteLine($"Produto Deletado");
            
        }
    }
}