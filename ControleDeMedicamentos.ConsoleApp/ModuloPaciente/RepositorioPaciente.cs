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

        public ArrayList SelecionarTodos()
        {
            return listaPaciente;
        }

        public void Inserir(Paciente paciente)
        {     
            contadorPacientes++;

            paciente.id = contadorPacientes;

            listaPaciente.Add(paciente);
        }

        public void Editar(int id, Paciente pacienteAtualizado)
        {
            Paciente pacienteSelecionado = SelecionarPorId(id);

            pacienteSelecionado.nome = pacienteAtualizado.nome;
            pacienteSelecionado.cpf = pacienteAtualizado.cpf;
            pacienteSelecionado.cartaoSus = pacienteAtualizado.cartaoSus;
            pacienteSelecionado.telefone = pacienteAtualizado.telefone;
               
        }       

        public void Excluir(int id)
        {
            Paciente pacienteSelecionado = SelecionarPorId(id);

            listaPaciente.Remove(pacienteSelecionado);
        }

        private Paciente SelecionarPorId(int id)
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

            return pacienteSelecionado;
        }

        
    }
}
