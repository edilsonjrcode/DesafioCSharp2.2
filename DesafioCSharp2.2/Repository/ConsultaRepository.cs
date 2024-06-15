using DesafioCSharp2._2.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCSharp2._2.Repository {
    class ConsultaRepository {

        private List<Paciente> pacientes;

        public void IncluirPaciente(Paciente paciente) {
            pacientes.Add(paciente);
        }

        public void ExcluirPaciente(Paciente paciente) {
            pacientes.Remove(paciente);
        }

        public List<Paciente> ListarPacientes() {
            return pacientes;
        }

    }
}
