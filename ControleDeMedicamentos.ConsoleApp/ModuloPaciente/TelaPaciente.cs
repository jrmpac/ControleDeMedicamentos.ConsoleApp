using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.ConsoleApp.ModuloPaciente
{
    public class TelaPaciente
    {
        public string ApresentarMenu()
        {
            Console.Clear();

            Console.WriteLine("Digite 1 para inserir paciente");
            Console.WriteLine("Digite 2 para visualizar pacientes");
            Console.WriteLine("Digite 3 para editar pacientes");
            Console.WriteLine("Digite 4 para excluir pacientes");

            Console.WriteLine("Digite S para Sair");

            string opcao = Console.ReadLine();
            return opcao;
        }

        public void InserirPaciente()
        {
            Console.Clear();

            Console.WriteLine(  "Cadastro de Pacientes \n" );

            Console.WriteLine("Cadastrando um novo paciente...");

            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Paciente cadastrado com sucesso!");

            Console.ResetColor();

            Console.ReadLine();
        }

        public void VisualizarPaciente()
        {
            Console.Clear();

            Console.WriteLine("Cadastro de Pacientes \n");

            Console.WriteLine("Visualizando todos os pacientes...");

            Console.ReadLine();
        }

        public void EditarPaciente()
        {
            throw new NotImplementedException();
        }

        public void ExcluirPaciente()
        {
            throw new NotImplementedException();
        }
    }
}
