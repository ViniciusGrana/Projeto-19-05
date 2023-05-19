using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetos_de_produtos
{
    public class Marca
    {
        public int Codigo { get; set; }
        public string NomeMarca { get; set; }
        public DateTime DataCadastro { get; set; }

        List<Marca> listaDeMarcas = new List<Marca>();

        public Marca Cadastrar()
        {

            //instanciar o objeto
            Marca novaMarca = new Marca();
            Console.WriteLine($"Informe o codigo da nova marca");
            novaMarca.Codigo = int.Parse (Console.ReadLine());
            
            Console.WriteLine($"Informe o nome da marca");
            novaMarca.NomeMarca = Console.ReadLine();
            
            novaMarca.DataCadastro = DateTime.Now;
            
            listaDeMarcas.Add(novaMarca);
            
            return novaMarca;
        }

        public void Listar()
        {
            //aqui vai a lógica
            //exibir os objetos cadastrados na lista
            foreach (var item in listaDeMarcas)
            {
                Marca novaMarca = new Marca();
                Console.WriteLine(@$"
                Codigo da marca adicionada: {item.Codigo}
                Nome da marca adicionada: {item.NomeMarca}
                Data: {item.DataCadastro}");
                
            }
        }

        public void Deletar(int codigo)
        {
            //aqui vai a lógica
            //buscar um objeto na lista pelo seu código
            //remove-lo
            Marca marcaEncontrada = listaDeMarcas.Find(x=> x.Codigo == codigo);
             listaDeMarcas.Remove(marcaEncontrada);
             Console.WriteLine($"Marca deletada com sucesso! ");
             
        }
    }
}