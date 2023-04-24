using ControleDeMedicamentos.ConsoleApp.ModuloFornecedor;
using ControleDeMedicamentos.ConsoleApp.ModuloFuncionario;
using ControleDeMedicamentos.ConsoleApp.ModuloPaciente;
using ControleDeMedicamentos.ConsoleApp.ModuloRemedio;

namespace ControleDeMedicamentos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Paciente paciente = new Paciente();
            Funcionario funcionario = new Funcionario();

            while (true)
            {
                TelaPrincipal telaPrincipal = new TelaPrincipal();
                string opcao = telaPrincipal.ApresentarMenu();

                if (opcao == "s")
                {
                    // sair do sistema
                    break;
                }

                if (opcao == "1")
                {
                    TelaPaciente telaPaciente = new TelaPaciente();
                    string opcaoPaciente = telaPaciente.ApresentarMenu();      
                    
                    if (opcaoPaciente == "1")
                    {
                        telaPaciente.InserirPaciente();
                    }

                    else if (opcaoPaciente == "2")
                    {
                        telaPaciente.VisualizarPaciente();
                    }

                    else if (opcaoPaciente == "3")
                    {
                        telaPaciente.EditarPaciente();
                    }

                    else if (opcaoPaciente == "4")
                    {
                        telaPaciente.ExcluirPaciente();
                    }
                }

                else if (opcao == "2")
                {
                    TelaFuncionario telaFuncionario = new TelaFuncionario();
                    string opcaoFuncionario = telaFuncionario.ApresentarMenu();

                    if (opcaoFuncionario == "1")
                    {
                        telaFuncionario.InserirFuncionario();
                    }

                    else if (opcaoFuncionario == "2")
                    {
                        telaFuncionario.EditarFuncionario();
                    }

                    else if (opcaoFuncionario == "3")
                    {
                        telaFuncionario.VisualizarFuncionario();
                    }

                    else if (opcaoFuncionario == "4")
                    {
                        telaFuncionario.ExcluirFuncionario();
                    }
                }

                else if (opcao == "3")
                {
                    TelaRemedio telaRemedio = new TelaRemedio();
                    string opcaoRemedio = telaRemedio.ApresentarMenu();

                    if (opcaoRemedio == "1")
                    {
                        telaRemedio.InserirRemedios();
                    }

                    else if (opcaoRemedio == "2")
                    {
                        telaRemedio.EditarRemedio();
                    }

                    else if (opcaoRemedio == "3")
                    {
                        telaRemedio.VisualizarRemedio();
                    }

                    else if (opcaoRemedio == "4")
                    {
                        telaRemedio.ExcluirRemedio();
                    }
                }

                else if (opcao == "4")
                {                    
                    TelaFornecedor telaFornecedor = new TelaFornecedor();
                    string opcaoFornecedor = telaFornecedor.ApresentarMenu();

                    if (opcaoFornecedor == "1")
                    {
                        telaFornecedor.InserirFornecedores();
                    }

                    else if (opcaoFornecedor == "2")
                    {
                        telaFornecedor.EditarFornecedor();
                    }

                    else if (opcaoFornecedor == "3")
                    {
                        telaFornecedor.VisualizarFornecedor();
                    }

                    else if (opcaoFornecedor == "4")
                    {
                        telaFornecedor.ExcluirFornecedor();
                    }
            }
        }
    }
}