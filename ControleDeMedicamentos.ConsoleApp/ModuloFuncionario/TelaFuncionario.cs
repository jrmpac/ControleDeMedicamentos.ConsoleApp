using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.ConsoleApp.ModuloFuncionario
{
    public class TelaFuncionario
    {
        public string ApresentarMenu()
        {
            Console.Clear();

            Console.WriteLine("Digite 1 para inserir funcionario");
            Console.WriteLine("Digite 2 para visualizar funcionarios");
            Console.WriteLine("Digite 3 para editar funcionarios");
            Console.WriteLine("Digite 4 para excluir funcionarios");

            Console.WriteLine("Digite S para Sair");

            string opcao = Console.ReadLine();

            return opcao;
        }

        public void InserirFuncionario()
        {
            Console.Clear();

            Console.WriteLine("Cadastro de Funcionarios \n");

            Console.WriteLine("Cadastrando um novo funcionario...");

            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Funcionario cadastrado com sucesso!");

            Console.ResetColor();

            Console.ReadLine();
        }

        public void VisualizarFuncionario()
        {
            Console.Clear();

            Console.WriteLine("Cadastro de Funcionario \n");

            Console.WriteLine("Visualizando todos os pacientes...");

            Console.ReadLine();
        }

        public void EditarFuncionario()
        {
            throw new NotImplementedException();
        }

        public void ExcluirFuncionario()
        {
            throw new NotImplementedException();
        }
    }
}
