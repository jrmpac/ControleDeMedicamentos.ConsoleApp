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

        internal ArrayList SelecionarTodos()
    {
            return listaPaciente;
        }
    }
}
