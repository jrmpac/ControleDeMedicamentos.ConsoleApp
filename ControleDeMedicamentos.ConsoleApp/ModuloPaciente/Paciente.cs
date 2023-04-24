using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeMedicamentos.ConsoleApp.ModuloPaciente
{
    public class Paciente
    {
        // atributos
        public int id;
        public string nome;
        public string cpf;
        public string cartaoSus;
        public string telefone;

        public Paciente(string nome, string cpf, string cartaoSus, string telefone)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.cartaoSus = cartaoSus;
            this.telefone = telefone;
        }
    }
}
