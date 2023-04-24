using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.ConsoleApp.ModuloPaciente
{
    public class TelaPaciente
    {
        RepositorioPaciente repositorioPaciente = new RepositorioPaciente();

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
            MostrarCabecalho("Cadastro de Pacientes", "Inserindo um novo paciente...");

            Paciente paciente = ObterPaciente();

            repositorioPaciente.Inserir(paciente);

            ApresentarMensagem();
        }

        private void ApresentarMensagem()
        {
            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Paciente cadastrado com sucesso!");

            Console.ResetColor();

            Console.ReadLine();
        }

        private void MostrarCabecalho(string titulo, string subtitulo)
        {
            Console.Clear();

            Console.WriteLine(titulo + "\n");

            Console.WriteLine(subtitulo + "\n");
        }

        private Paciente ObterPaciente()
        {
            Console.WriteLine("Digite o nome do paciente");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o CPF do paciente");
            string cpf = Console.ReadLine();

            Console.WriteLine("Digite o cartão do SUS do paciente");
            string cartaoSus = Console.ReadLine();

            Console.WriteLine("Digite o telefone do paciente");
            string telefone = Console.ReadLine();

            Paciente paciente = new Paciente(nome, cpf, cartaoSus, telefone);

            return paciente;
        }

        public void VisualizarPaciente()
        {
            MostrarCabecalho("Cadastro de Pacientes", "Visualizando pacientes ja cadastrados");

            ArrayList pacientes = repositorioPaciente.SelecionarTodos();

            if (pacientes.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;

                Console.WriteLine("Nenhuma caixa cadastrada");

                Console.ResetColor();

                Console.ReadLine();

                return;
            }

            Console.WriteLine("{0,-10} | {1, -10} | {2, -10}", "Id", "Nome", "Telefone");

            Console.WriteLine("--------------------------------------------------------------------"    );

            foreach (Paciente paciente in pacientes)
            {
                Console.WriteLine("{0,-10} | {1, -10} | {2, -10}", paciente.id, paciente.nome, paciente.telefone);
            }

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
