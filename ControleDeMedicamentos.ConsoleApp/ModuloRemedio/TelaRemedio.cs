using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.ConsoleApp.ModuloRemedio
{
    public class TelaRemedio
    {
        public string ApresentarMenu()
        {
            Console.Clear();

            Console.WriteLine("Digite 1 para inserir medicamento");
            Console.WriteLine("Digite 2 para visualizar medicamentos");
            Console.WriteLine("Digite 3 para editar medicamentos");
            Console.WriteLine("Digite 4 para excluir medicamentos");

            Console.WriteLine("Digite S para Sair");

            string opcao = Console.ReadLine();
            return opcao;
        }

        internal void EditarRemedio()
        {
            throw new NotImplementedException();
        }

        internal void ExcluirRemedio()
        {
            throw new NotImplementedException();
        }

        internal void InserirRemedios()
        {
            throw new NotImplementedException();
        }

        internal void VisualizarRemedio()
        {
            throw new NotImplementedException();
        }
    }
}
