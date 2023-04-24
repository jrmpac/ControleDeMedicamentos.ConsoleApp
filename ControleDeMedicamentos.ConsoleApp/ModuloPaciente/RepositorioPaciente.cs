using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.ConsoleApp.ModuloPaciente
{
    public class RepositorioPaciente
    {
        // Atributo
        ArrayList listaPaciente = new ArrayList();

        private int contadorPacientes = 0;

        public void Inserir(Paciente paciente)
        {     
            contadorPacientes++;

            paciente.id = contadorPacientes;

            listaPaciente.Add(paciente);
        }

        public void Editar(int id, Paciente pacienteAtualizado)
        {
            foreach (Paciente p in listaPaciente)
            {
                if (p.id == id)
                {
                    p.nome = pacienteAtualizado.nome;
                    p.cpf = pacienteAtualizado.cpf;
                    p.cartaoSus = pacienteAtualizado.cartaoSus;
                    p.telefone = pacienteAtualizado.telefone;
                    break;
                }
            }
        }       

        public void Excluir(int id)
        {
            Paciente pacienteSelecionado = null;

            foreach (Paciente p in listaPaciente)
            {
                if (p.id == id)
                {
                    pacienteSelecionado = p;
                    break;
                }
            }

            listaPaciente.Remove(pacienteSelecionado);
        }

        public ArrayList SelecionarTodos()
        {
            return listaPaciente;
        }
    }
}
