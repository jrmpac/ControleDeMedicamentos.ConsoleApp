using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.ConsoleApp
{
    public class TelaPrincipal
    {
        public string ApresentarMenu()
        {
            Console.WriteLine("Controle de Medicamentos \n");

            Console.WriteLine("Digite 1 para cadastrar paciente");
            Console.WriteLine("Digite 2 para cadastrar funcionario");
            Console.WriteLine("Digite 3 para cadastrar medicamento");
            Console.WriteLine("Digite 4 para cadastrar fornecedor");

            Console.WriteLine("Digite S para Sair");

            string opcao = Console.ReadLine();
            return opcao;
        }
    }
}
