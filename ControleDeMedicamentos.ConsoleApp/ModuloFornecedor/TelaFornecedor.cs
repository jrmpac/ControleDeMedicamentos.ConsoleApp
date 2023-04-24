using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.ConsoleApp.ModuloFornecedor
{
    public class TelaFornecedor
    {
        public string ApresentarMenu()
        {
            Console.Clear();

            Console.WriteLine("Digite 1 para inserir fornecedor");
            Console.WriteLine("Digite 2 para visualizar fornecedores");
            Console.WriteLine("Digite 3 para editar fornecedores");
            Console.WriteLine("Digite 4 para excluir fornecedores");

            Console.WriteLine("Digite S para Sair");

            string opcao = Console.ReadLine();
            return opcao;
        }

        internal void EditarFornecedor()
        {
            throw new NotImplementedException();
        }

        internal void ExcluirFornecedor()
        {
            throw new NotImplementedException();
        }

        internal void InserirFornecedores()
        {
            throw new NotImplementedException();
        }

        internal void VisualizarFornecedor()
        {
            throw new NotImplementedException();
        }
    }
}
